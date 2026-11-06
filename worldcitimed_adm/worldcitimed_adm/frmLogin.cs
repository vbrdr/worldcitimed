using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace worldcitimed_adm
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public frmLogin()
        {
            InitializeComponent();

            ttLogin.SetToolTip(btnLogin, "Click to Login.");
            ttLogin.SetToolTip(txbUN, "Input your username.");
            ttLogin.SetToolTip(txbPass, "Input your password.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUN.Text.Trim();
            string password = txbPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM tblAdmAccount WHERE newUsername = @username AND newPassword = @password";

            SqlConnection con = new SqlConnection("Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True");
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);  
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        frmDashboard frm = new frmDashboard();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
