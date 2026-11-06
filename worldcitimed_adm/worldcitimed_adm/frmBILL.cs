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
    public partial class frmBILL : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        public frmBILL()
        {
            InitializeComponent();

            ttBILLQ.SetToolTip(btnUpdate, "Click if Done.");
            ttBILLQ.SetToolTip(btnDelete, "Click to Delete.");
            ttBILLQ.SetToolTip(txbSearch, "Input the search keyword.");
            ttBILLQ.SetToolTip(btnSearch, "Click to Search.");

            LoadBILLData();
            dgvBILL.RowPrePaint += dgvBILL_RowPrePaint;
            dgvBILL.CellValueChanged += dgvBILL_CellValueChanged;
            dgvBILL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click_1;
            btnSearch.Click += btnSearch_Click;
        }

        private void LoadBILLData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority FROM tblBILLqrec ORDER BY billQueueNum";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvBILL.DataSource = dt;

                        if (dgvBILL.Columns.Contains("ispriority"))
                            dgvBILL.Columns["ispriority"].Visible = false;

                        if (dgvBILL.Columns.Contains("Status"))
                            dgvBILL.Columns["Status"].DisplayIndex = 0;

                        if (dgvBILL.Columns.Contains("Priority"))
                            dgvBILL.Columns["Priority"].DisplayIndex = 1;

                        dgvBILL.ReadOnly = false;
                        dgvBILL.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvBILL.Columns)
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

        private void dgvBILL_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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

        private void dgvBILL_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBILL.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                var row = dgvBILL.Rows[e.RowIndex];
                var status = row.Cells["Status"].Value?.ToString();
                var queueNum = row.Cells["billQueueNum"].Value;

                if (queueNum == null) return;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE tblBILLqrec SET Status = @Status WHERE billQueueNum = @QueueNum";
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
            if (dgvBILL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvBILL.SelectedRows[0];
            var queueNum = selectedRow.Cells["billQueueNum"].Value;

            if (queueNum == null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE tblBILLqrec SET Status = @Status WHERE billQueueNum = @QueueNum";
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
            if (dgvBILL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to remove this row from the table? (This will not delete from the database)",
                "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvBILL.SelectedRows)
            {
                dgvBILL.Rows.Remove(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadBILLData();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority
                         FROM tblBILLqrec
                         WHERE 
                            CAST(billQueueNum AS NVARCHAR) LIKE @search
                            OR Status LIKE @search
                            OR firstname LIKE @search
                            OR lastname LIKE @search
                         ORDER BY billQueueNum";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvBILL.DataSource = dt;

                        if (dgvBILL.Columns.Contains("ispriority"))
                            dgvBILL.Columns["ispriority"].Visible = false;

                        if (dgvBILL.Columns.Contains("Status"))
                            dgvBILL.Columns["Status"].DisplayIndex = 0;

                        if (dgvBILL.Columns.Contains("Priority"))
                            dgvBILL.Columns["Priority"].DisplayIndex = 1;

                        dgvBILL.ReadOnly = false;
                        dgvBILL.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvBILL.Columns)
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
