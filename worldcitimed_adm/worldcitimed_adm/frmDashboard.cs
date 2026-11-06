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
    public partial class frmDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public frmDashboard()
        {
            InitializeComponent();

            ttdash.SetToolTip(btnPH, "Philhealth Queuing Interface.");
            ttdash.SetToolTip(btnBILL, "Billing Queuing Interface.");
            ttdash.SetToolTip(btnCASH, "Cashier Queuing Interface.");
            ttdash.SetToolTip(btnOPD, "OPD Queuing Interface.");
            ttdash.SetToolTip(btnADM, "Admission Queuing Interface.");
            ttdash.SetToolTip(btnHMO, "HMO Queuing Interface.");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrint frm = new frmPrint();
            frm.ShowDialog();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashCreate frm = new frmDashCreate();
            frm.ShowDialog();
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            frmPH frmDashboard = new frmPH(); 
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnBILL_Click(object sender, EventArgs e)
        {
            frmBILL frmDashboard = new frmBILL();
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnCASH_Click(object sender, EventArgs e)
        {
            frmCASH frmDashboard = new frmCASH();
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            frmOPD frmDashboard = new frmOPD();
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            frmADM frmDashboard = new frmADM();
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnHMO_Click(object sender, EventArgs e)
        {
            frmHMO frmDashboard = new frmHMO();
            frmDashboard.TopLevel = false;
            pMain.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
