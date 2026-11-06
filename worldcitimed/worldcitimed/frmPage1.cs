using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldcitimed
{
    public partial class frmPage1 : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=allari\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

    
        public frmPage1()
        {
            InitializeComponent();

            ttPage1.SetToolTip(btnPhilhealth, "Click to get queue number for PhilHealth.");
            ttPage1.SetToolTip(btnBilling, "Click to get queue number for Billing.");
            ttPage1.SetToolTip(btnCashier, "Click to get queue number for Cashier.");
            ttPage1.SetToolTip(btnAdmi, "Click to get queue number for Admission.");
            ttPage1.SetToolTip(btnOPD, "Click to get queue number for OPD Registration.");
            ttPage1.SetToolTip(btnHMO, "Click to get queue number for HMO Approval.");
            ttPage1.SetToolTip(cbPrio, "Check this box if you are a priority patient.");


            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick;
            timer.Start();

            if (this.Controls["lblDateTime"] == null)
            {
                Label lblDateTime = new Label();
                lblDateTime.Name = "lblDateTime";
                lblDateTime.AutoSize = true;
                lblDateTime.Font = new System.Drawing.Font("Arial", 12);
                lblDateTime.Location = new System.Drawing.Point(10, 10);
                this.Controls.Add(lblDateTime);

                lblDateTime.Text = DateTime.Now.ToString("F");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label lblDateTime = this.Controls["lblDateTime"] as Label;
            if (lblDateTime != null)
            {
                lblDateTime.Text = DateTime.Now.ToString("F");
            }
        }

        private void btnPhilhealth_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmPHregi frm = new frmPHregi(isPriority);
            frm.ShowDialog();
            this.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmBillregi frm = new frmBillregi(isPriority);
            frm.ShowDialog();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmCashregi frm = new frmCashregi(isPriority);
            frm.ShowDialog();
        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmOPDregi frm = new frmOPDregi(isPriority);
            frm.ShowDialog();
        }

        private void btnAdmi_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmAdmregi frm = new frmAdmregi(isPriority);
            frm.ShowDialog();
        }

        private void btnHMO_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool isPriority = cbPrio.Checked;
            frmHMOregi frm = new frmHMOregi(isPriority);
            frm.ShowDialog();
        }
    }
}
