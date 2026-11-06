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

namespace worlcitimed_display
{
    public partial class frmDisplay : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        public frmDisplay()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();

            if (this.Controls["lblDateTime"] == null)
            {
                Label lblDateTime = new Label();
                lblDateTime.Name = "lblDateTime";
                lblDateTime.AutoSize = true;
                this.Controls.Add(lblDateTime);

                lblDateTime.Text = DateTime.Now.ToString("F");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAllQueueDisplays();

            Label lblDateTime = this.Controls["lblDateTime"] as Label;
            if (lblDateTime != null)
            {
                lblDateTime.Text = DateTime.Now.ToString("F");
            }
        }

        private void UpdateAllQueueDisplays()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                    SELECT
                        (SELECT TOP 1 phQueueNum FROM tblPHqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(phQueueNum, PATINDEX('%[0-9]%', phQueueNum), LEN(phQueueNum)) AS INT) ASC) AS phQueueNum,
                        (SELECT TOP 1 billQueueNum FROM tblBILLqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(billQueueNum, PATINDEX('%[0-9]%', billQueueNum), LEN(billQueueNum)) AS INT) ASC) AS billQueueNum,
                        (SELECT TOP 1 cashQueueNum FROM tblCASHqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(cashQueueNum, PATINDEX('%[0-9]%', cashQueueNum), LEN(cashQueueNum)) AS INT) ASC) AS cashQueueNum,
                        (SELECT TOP 1 opdQueueNum FROM tblOPDqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(opdQueueNum, PATINDEX('%[0-9]%', opdQueueNum), LEN(opdQueueNum)) AS INT) ASC) AS opdQueueNum,
                        (SELECT TOP 1 admQueueNum FROM tblADMqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(admQueueNum, PATINDEX('%[0-9]%', admQueueNum), LEN(admQueueNum)) AS INT) ASC) AS admQueueNum,
                        (SELECT TOP 1 hmoQueueNum FROM tblHMOqrec WHERE LTRIM(RTRIM(LOWER(Status))) <> 'done' ORDER BY IsPriority DESC, CAST(SUBSTRING(hmoQueueNum, PATINDEX('%[0-9]%', hmoQueueNum), LEN(hmoQueueNum)) AS INT) ASC) AS hmoQueueNum
                    ", conn);


                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbPH.Text = reader["phQueueNum"]?.ToString() ?? "-";
                            lbBILL.Text = reader["billQueueNum"]?.ToString() ?? "-";
                            lbCASH.Text = reader["cashQueueNum"]?.ToString() ?? "-";
                            lbOPD.Text = reader["opdQueueNum"]?.ToString() ?? "-";
                            lbADM.Text = reader["admQueueNum"]?.ToString() ?? "-";
                            lbHMO.Text = reader["hmoQueueNum"]?.ToString() ?? "-";
                        }
                        else
                        {
                            lbPH.Text = lbBILL.Text = lbCASH.Text = lbOPD.Text = lbADM.Text = lbHMO.Text = "-";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
