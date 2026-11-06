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
    public partial class frmStaffAcc : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        private int selectedRowIndex = -1;
        private int selectedColIndex = -1;

        public frmStaffAcc()
        {
            InitializeComponent();
            LoadStaffAccounts();

            btnDelete.Click += btnDelete_Click;
            btnUpdate.Click += btnUpdate_Click;
            dgvStaff.CellClick += dgvStaff_CellClick;
        }

        private void LoadStaffAccounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblStaffAccount";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStaff.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected account(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                foreach (DataGridViewRow row in dgvStaff.SelectedRows)
                {
                    var idValue = row.Cells["staffID"].Value;
                    if (idValue == null) continue;

                    string query = "DELETE FROM tblStaffAccount WHERE staffID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", idValue);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            LoadStaffAccounts();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                selectedColIndex = e.ColumnIndex;
                var cellValue = dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                txbUp.Text = cellValue?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0 || selectedColIndex < 0)
            {
                MessageBox.Show("Please select a cell to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idValue = dgvStaff.Rows[selectedRowIndex].Cells["staffID"].Value;
            if (idValue == null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string columnName = dgvStaff.Columns[selectedColIndex].Name;
            string newValue = txbUp.Text.Trim();

            if (columnName == "staffID" || columnName == "staffCode")
            {
                MessageBox.Show("Cannot update this column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"UPDATE tblSTaffAccount SET {columnName} = @newValue WHERE staffID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newValue", newValue);
                    cmd.Parameters.AddWithValue("@Id", idValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            LoadStaffAccounts();
            MessageBox.Show($"{columnName} updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadStaffAccounts();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM tblStaffAccount
            WHERE 
                CONVERT(NVARCHAR(50), staffID) LIKE @search
                OR fullName LIKE @search
                OR department LIKE @search
                OR position LIKE @search
                OR username LIKE @search
                OR password LIKE @search";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvStaff.DataSource = dt;

                        if (dgvStaff.Columns.Count > 0)
                            dgvStaff.Columns[0].ReadOnly = true;
                        if (dgvStaff.Columns.Count > 1)
                            dgvStaff.Columns[1].ReadOnly = true;
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
