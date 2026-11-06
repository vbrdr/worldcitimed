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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace worldcitimed
{
    public partial class frmBillregi : Form
    {

        SqlConnection con = new SqlConnection(
            @"Data Source=allari\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        private bool isPriority;

        public frmBillregi(bool isPriority)
        {
            InitializeComponent();
            this.isPriority = isPriority;

            ttBILL.SetToolTip(txbBillfirst, "Input your First Name.");
            ttBILL.SetToolTip(txbBillmiddle, "Input your Middle Initial.");
            ttBILL.SetToolTip(txbBilllast, "Input your Last Name.");
            ttBILL.SetToolTip(btnBillenter, "Confirm.");
            ttBILL.SetToolTip(btnBillback, "Back to Main Interface");

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

        private void btnBillback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPage1 frm = new frmPage1();
            frm.ShowDialog();
        }

        private void btnBillenter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbBillfirst.Text) ||
                string.IsNullOrWhiteSpace(txbBilllast.Text))
            {
                MessageBox.Show("Please fill in all required fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int nextQNum = GetNextQNum();

                string QueueNumber = $"B0{nextQNum}";

                SavePHRegi(QueueNumber);

                GenerateQueueSlip(QueueNumber);

                MessageBox.Show($"Queue number {QueueNumber} has been saved and printed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            frmPage1 frm = new frmPage1();
            frm.ShowDialog();
            this.Close();
        }

        private int GetNextQNum()
        {
            int nextQNum = 1;
            string query = "SELECT MAX(CAST(SUBSTRING(billQueueNum, 3, LEN(billQueueNum) - 2) AS INT)) FROM tblBILLqrec";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    nextQNum = Convert.ToInt32(result) + 1;
                }
                con.Close();
            }

            return nextQNum;
        }

        private void SavePHRegi(string QueueNumber)
        {
            try
            {
                Guid patientId = Guid.NewGuid();
                DateTime date = DateTime.Now;

                con.Open();


                string query = "INSERT INTO tblBILLqrec (isPriority, billQueueNum, firstName, middleInitial, lastName, dateTime, billID) " +
                              "VALUES (@prio, @qnum, @first, @middle, @last, @dateTime, @ID)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@prio", isPriority);
                cmd.Parameters.AddWithValue("@qnum", QueueNumber);
                cmd.Parameters.AddWithValue("@first", txbBillfirst.Text);
                cmd.Parameters.AddWithValue("@middle", txbBillmiddle.Text);
                cmd.Parameters.AddWithValue("@last", txbBilllast.Text);
                cmd.Parameters.AddWithValue("@dateTime", date);
                cmd.Parameters.AddWithValue("@ID", patientId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thank You!");
                }
                else
                {
                    MessageBox.Show("Please Try Again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void GenerateQueueSlip(string queueNumber)
        {
            iTextSharp.text.Rectangle smallPage = new iTextSharp.text.Rectangle(216, 144);
            string fileName = $"QueueSlip_{queueNumber}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            Document doc = new Document(smallPage, 10, 10, 5, 10);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                var billFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var emeFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                var queueFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 21);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);

                Paragraph bill = new Paragraph("Billing", billFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 2f
                };
                Paragraph title = new Paragraph("Counter 4", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 2f
                };
                Paragraph number = new Paragraph(queueNumber, queueFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 2f
                };
                Paragraph validity = new Paragraph("Valid only for today", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 2f
                };
                Paragraph date = new Paragraph(DateTime.Now.ToString("F"), normalFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };

                doc.Add(bill);
                doc.Add(title);
                doc.Add(number);
                doc.Add(validity);
                doc.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate PDF: " + ex.Message);
                return;
            }
            finally
            {
                doc.Close();
            }

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open PDF: " + ex.Message);
            }
        }
    }
}
