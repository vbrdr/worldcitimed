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
    public partial class frmOPD : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        public frmOPD()
        {
            InitializeComponent();

            ttOQ.SetToolTip(btnUpdate, "Click if Done.");
            ttOQ.SetToolTip(btnDelete, "Click to Delete.");
            ttOQ.SetToolTip(txbSearch, "Input the search keyword.");
            ttOQ.SetToolTip(btnSearch, "Click to Search.");

            LoadOPDData();
            dgvOPD.RowPrePaint += dgvOPD_RowPrePaint;
            dgvOPD.CellValueChanged += dgvOPD_CellValueChanged;
            dgvOPD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click_1;
            btnSearch.Click += btnSearch_Click;
        }

        private void LoadOPDData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority FROM tblOPDqrec ORDER BY opdQueueNum";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvOPD.DataSource = dt;

                        if (dgvOPD.Columns.Contains("ispriority"))
                            dgvOPD.Columns["ispriority"].Visible = false;

                        if (dgvOPD.Columns.Contains("Status"))
                            dgvOPD.Columns["Status"].DisplayIndex = 0;

                        if (dgvOPD.Columns.Contains("Priority"))
                            dgvOPD.Columns["Priority"].DisplayIndex = 1;

                        dgvOPD.ReadOnly = false;
                        dgvOPD.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvOPD.Columns)
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

        private void dgvOPD_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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

        private void dgvOPD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOPD.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                var row = dgvOPD.Rows[e.RowIndex];
                var status = row.Cells["Status"].Value?.ToString();
                var queueNum = row.Cells["opdQueueNum"].Value;

                if (queueNum == null) return;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE tblOPDqrec SET Status = @Status WHERE opdQueueNum = @QueueNum";
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
            if (dgvOPD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvOPD.SelectedRows[0];
            var queueNum = selectedRow.Cells["opdQueueNum"].Value;

            if (queueNum == null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE tblOPDqrec SET Status = @Status WHERE opdQueueNum = @QueueNum";
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
            if (dgvOPD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to remove this row from the table?",
                "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvOPD.SelectedRows)
            {
                dgvOPD.Rows.Remove(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadOPDData();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority
                         FROM tblOPDqrec
                         WHERE 
                            CAST(opdQueueNum AS NVARCHAR) LIKE @search
                            OR Status LIKE @search
                            OR firstname LIKE @search
                            OR lastname LIKE @search
                         ORDER BY opdQueueNum";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvOPD.DataSource = dt;

                        if (dgvOPD.Columns.Contains("ispriority"))
                            dgvOPD.Columns["ispriority"].Visible = false;

                        if (dgvOPD.Columns.Contains("Status"))
                            dgvOPD.Columns["Status"].DisplayIndex = 0;

                        if (dgvOPD.Columns.Contains("Priority"))
                            dgvOPD.Columns["Priority"].DisplayIndex = 1;

                        dgvOPD.ReadOnly = false;
                        dgvOPD.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvOPD.Columns)
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
