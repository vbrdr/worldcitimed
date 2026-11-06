using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace worldcitimed_adm
{
    public partial class frmPrintCASH : Form
    {
        private readonly string connectionString = "Data Source=allari\\SQLEXPRESS;" +
            "Initial Catalog=worldcitimed_db;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True";

        public frmPrintCASH()
        {
            InitializeComponent();

            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("Pending");
            cbStatus.Items.Add("Done");

            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;

            btnFilter.Click += btnFilter_Click;
            btnPrint.Click += btnPrint_Click;

            dtpFrom.Value = new DateTime(2025, 1, 1);
            dtpTo.Value = DateTime.Today;

            var selectedStatus = cbStatus.SelectedItem?.ToString() ?? "All";
            LoadCASHData(dtpFrom.Value, dtpTo.Value, selectedStatus);
        }

        private void LoadCASHData(DateTime from, DateTime to, string status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT *, CASE WHEN ispriority = 1 THEN 'Yes' ELSE 'No' END AS Priority
                         FROM tblCASHqrec
                         WHERE dateTime >= @from AND dateTime <= @to";

                if (status != "All")
                    query += " AND Status = @status";
                query += " ORDER BY cashQueueNum";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@from", from.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@to", to.Date.AddDays(1).AddTicks(-1));
                    if (status != "All")
                        adapter.SelectCommand.Parameters.AddWithValue("@status", status);

                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dgvPrintCASH.DataSource = dt;

                        if (dgvPrintCASH.Columns.Contains("ispriority"))
                            dgvPrintCASH.Columns["ispriority"].Visible = false;

                        if (dgvPrintCASH.Columns.Contains("Status"))
                            dgvPrintCASH.Columns["Status"].DisplayIndex = 0;

                        if (dgvPrintCASH.Columns.Contains("Priority"))
                            dgvPrintCASH.Columns["Priority"].DisplayIndex = 1;

                        dgvPrintCASH.AllowUserToAddRows = false;
                        foreach (DataGridViewColumn col in dgvPrintCASH.Columns)
                        {
                            if (col.Name == "Status")
                                col.ReadOnly = false;
                            else
                                col.ReadOnly = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var selectedStatus = cbStatus.SelectedItem?.ToString() ?? "All";
            LoadCASHData(dtpFrom.Value, dtpTo.Value, selectedStatus);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf", FileName = "CASH_Queue_Report.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Download(dgvPrintCASH, sfd.FileName);
                }
            }
        }

        private void Download(DataGridView dgv, string fileName)
        {
            Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 30f, 20f);
            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    Paragraph title = new Paragraph("Cashier Queuing Report", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 10f
                    };
                    pdfDoc.Add(title);

                    var dateFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    Paragraph date = new Paragraph("Downloaded: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), dateFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 15f
                    };
                    pdfDoc.Add(date);

                    int visibleColumnCount = 0;
                    foreach (DataGridViewColumn column in dgv.Columns)
                        if (column.Visible) visibleColumnCount++;

                    PdfPTable pdfTable = new PdfPTable(visibleColumnCount);
                    pdfTable.WidthPercentage = 100;

                    var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
                    var headerBg = new BaseColor(255, 165, 0);

                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        if (column.Visible)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                            {
                                BackgroundColor = headerBg,
                                Padding = 5,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(cell);
                        }
                    }

                    var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.OwningColumn.Visible)
                                {
                                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", cellFont))
                                    {
                                        Padding = 4,
                                        HorizontalAlignment = Element.ALIGN_CENTER
                                    };
                                    pdfTable.AddCell(pdfCell);
                                }
                            }
                        }
                    }
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("PDF downloaded successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading PDF: " + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}