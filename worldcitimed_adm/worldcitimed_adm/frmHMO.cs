using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldcitimed_adm
{
    public partial class frmHMO : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        public frmHMO()
        {
            InitializeComponent();

            ttHQ.SetToolTip(btnUpdate, "Click if Done.");
            ttHQ.SetToolTip(btnDelete, "Click to Delete.");
            ttHQ.SetToolTip(txbSearch, "Input the search keyword.");
            ttHQ.SetToolTip(btnSearch, "Click to Search.");

            LoadHMOData();
            dgvHMO.RowPrePaint += dgvHMO_RowPrePaint;
            dgvHMO.CellValueChanged += dgvHMO_CellValueChanged;
            dgvHMO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click_1;
            btnSearch.Click += btnSearch_Click;
        }
        private void LoadHMOData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority FROM tblHMOqrec ORDER BY hmoQueueNum";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvHMO.DataSource = dt;

                        if (dgvHMO.Columns.Contains("ispriority"))
                            dgvHMO.Columns["ispriority"].Visible = false;

                        if (dgvHMO.Columns.Contains("Status"))
                            dgvHMO.Columns["Status"].DisplayIndex = 0;

                        if (dgvHMO.Columns.Contains("Priority"))
                            dgvHMO.Columns["Priority"].DisplayIndex = 1;

                        dgvHMO.ReadOnly = false;
                        dgvHMO.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvHMO.Columns)
                        {
                            if (col.Name == "Status")
                                col.ReadOnly = false;
                            else
                                col.ReadOnly = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvHMO_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            if (!dgv.Columns.Contains("Priority")) return;

            var value = dgv.Rows[e.RowIndex].Cells["Priority"].Value;
            if (value != null && value.ToString() == "Yes")
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;
            }
        }

        private void dgvHMO_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHMO.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                var row = dgvHMO.Rows[e.RowIndex];
                var status = row.Cells["Status"].Value?.ToString();
                var queueNum = row.Cells["hmoQueueNum"].Value;

                if (queueNum == null) return;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE tblHMOqrec SET Status = @Status WHERE hmoQueueNum = @QueueNum";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@QueueNum", queueNum);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvHMO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvHMO.SelectedRows[0];
            var queueNum = selectedRow.Cells["hmoQueueNum"].Value;

            if (queueNum == null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE tblHMOqrec SET Status = @Status WHERE hmoQueueNum = @QueueNum";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Status", "Done");
                    cmd.Parameters.AddWithValue("@QueueNum", queueNum);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        selectedRow.Cells["Status"].Value = "Done";
                        MessageBox.Show("Status updated to 'Done'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvHMO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to remove this row from the table?",
                "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvHMO.SelectedRows)
            {
                dgvHMO.Rows.Remove(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadHMOData();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority
                         FROM tblHMOqrec
                         WHERE 
                            CAST(hmoQueueNum AS NVARCHAR) LIKE @search
                            OR Status LIKE @search
                            OR firstname LIKE @search
                            OR lastname LIKE @search
                         ORDER BY hmoQueueNum";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvHMO.DataSource = dt;

                        if (dgvHMO.Columns.Contains("ispriority"))
                            dgvHMO.Columns["ispriority"].Visible = false;

                        if (dgvHMO.Columns.Contains("Status"))
                            dgvHMO.Columns["Status"].DisplayIndex = 0;

                        if (dgvHMO.Columns.Contains("Priority"))
                            dgvHMO.Columns["Priority"].DisplayIndex = 1;

                        dgvHMO.ReadOnly = false;
                        dgvHMO.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvHMO.Columns)
                        {
                            if (col.Name == "Status")
                                col.ReadOnly = false;
                            else
                                col.ReadOnly = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error searching data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
