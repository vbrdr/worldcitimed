using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldcitimed_adm
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.ShowDialog();
        }

        private void btnPH_Click_1(object sender, EventArgs e)
        {
            frmPrintPH frmPrint = new frmPrintPH();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();
        }
        
        private void btnBILL_Click_1(object sender, EventArgs e)
        {
            frmPrintBILL frmPrint = new frmPrintBILL();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();
        }

        private void btnCASH_Click(object sender, EventArgs e)
        {
            frmPrintCASH frmPrint = new frmPrintCASH();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();

        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            frmPrintOPD frmPrint = new frmPrintOPD();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            frmPrintADM frmPrint = new frmPrintADM();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();
        }

        private void btnHMO_Click(object sender, EventArgs e)
        {
            frmPrintHMO frmPrint = new frmPrintHMO();
            frmPrint.TopLevel = false;
            pnPrint.Controls.Add(frmPrint);
            frmPrint.BringToFront();
            frmPrint.Show();
        }
    }
}
