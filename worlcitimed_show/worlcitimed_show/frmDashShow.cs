using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcitimed_adm;

namespace worlcitimed_show
{
    public partial class frmDashShow : Form
    {
        public frmDashShow()
        {
            InitializeComponent();

            btnPH.Click += (s, e) => ShowForm(new frmPH());
            btnBILL.Click += (s, e) => ShowForm(new frmBILL());
            btnCASH.Click += (s, e) => ShowForm(new frmCASH());
            btnOPD.Click += (s, e) => ShowForm(new frmOPD());
            btnADM.Click += (s, e) => ShowForm(new frmADM());
            btnHMO.Click += (s, e) => ShowForm(new frmHMO());
        }

        private void ShowForm(Form form)
        {
            pnMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffLogin frm = new frmStaffLogin();
            frm.Show();
            this.Hide();
        }
    }
}
