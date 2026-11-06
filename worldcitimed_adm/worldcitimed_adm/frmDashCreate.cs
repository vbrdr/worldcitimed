using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace worldcitimed_adm
{
    public partial class frmDashCreate : Form
    {
        public frmDashCreate()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreate frm = new frmCreate();
            frm.ShowDialog();
        }

        private void backToDashboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateStaff frm = new frmCreateStaff();
            frm.ShowDialog();
        }

        private void backToDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.ShowDialog();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnCreate.Controls.Clear();

            Form formToShow = null;

            switch (cbSelect.SelectedItem.ToString())
            {
                case "Admin Account":
                    formToShow = new frmAdminAcc();
                    break;
                case "Staff Account":
                    formToShow = new frmStaffAcc();
                    break;
                    // Add more cases as needed
            }

            if (formToShow != null)
            {
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;
                pnCreate.Controls.Add(formToShow);
                formToShow.Show();
            }
        }
    }
}
