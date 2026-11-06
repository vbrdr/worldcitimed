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
    public partial class frmCreate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=allari\\SQLEXPRESS;" +
                "Initial Catalog=worldcitimed_db;" +
                "Integrated Security=True;" +
                "Trusted_Connection=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public frmCreate()
        {
            InitializeComponent();

            ttCreate.SetToolTip(btnBack, "Back to Login Page.");
            ttCreate.SetToolTip(btnCreate, "Click to create an account.");
            ttCreate.SetToolTip(txbFullName, "Input your Full Name.");
            ttCreate.SetToolTip(cbDep, "Choose your Department.");
            ttCreate.SetToolTip(txbPosi, "Input your Position.");
            ttCreate.SetToolTip(txbNewUN, "Input your New Username.");
            ttCreate.SetToolTip(txbNewPass, "Input your New Password.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashCreate frm = new frmDashCreate();
            frm.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fullname = txbFullName.Text.Trim();
            string department = cbDep.SelectedItem?.ToString();
            string position = txbPosi.Text.Trim();
            string username = txbNewUN.Text.Trim();
            string password = txbNewPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
            "Are you sure you want to create this account?",
            "Confirm Account Creation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string query = "INSERT INTO tblAdmAccount (accountID, fullName, department, position, newUsername, newPassword)" + 
                " VALUES (@ID,@name, @dep, @posi, @newUN, @newPass)";

            try
            {
                con.Open();

                Guid adminAccID = Guid.NewGuid();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", adminAccID);
                    cmd.Parameters.AddWithValue("@name", fullname);
                    cmd.Parameters.AddWithValue("@dep", department);
                    cmd.Parameters.AddWithValue("@posi", position);
                    cmd.Parameters.AddWithValue("@newUN", username);
                    cmd.Parameters.AddWithValue("@newPass", password);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbFullName.Text = "";
                        cbDep.SelectedIndex = -1;
                        txbPosi.Text = "";
                        txbNewUN.Text = "";
                        txbNewPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
