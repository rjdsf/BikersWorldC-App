using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    public partial class frmReportJob : Form
    {
        job jobs = new job();
        DataTable dt = new DataTable();
        public frmReportJob()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmReportJob_Load(object sender, EventArgs e)
        {
            //Build chart data on workshop workflow
            DataTable dtOpen = new DataTable();
            DataTable dtClosed = new DataTable();
            dtOpen = jobs.getOpenJobs("Month");
            dtClosed = jobs.getClosedJobs("Month");

            int totalOpen = dtOpen.Rows.Count;
            int totalClosed = dtClosed.Rows.Count;

            chtMonthlyFigures.Series.RemoveAt(0);
            chtMonthlyFigures.Series.Add("Opened").Points.AddY(totalOpen);
            chtMonthlyFigures.Series.Add("Closed").Points.AddY(totalClosed);

            //populate report combobox
            cboStatus.Items.Add("Open");
            cboStatus.Items.Add("Closed");
            cboStatus.Items.Add("All");
            cboStatus.SelectedIndex = 0;


            // reuse totalOpen and totalClosed variables and dtOpen and dtClosed datatables to get statistical data
            dtOpen = jobs.getOpenJobs("All");
            dtClosed = jobs.getClosedJobs("All");
            totalOpen = dtOpen.Rows.Count;
            totalClosed = dtClosed.Rows.Count;
            lblOpenJobsResult.Text = totalOpen.ToString();
            lblClosedJobsResult.Text = totalClosed.ToString();

            //populate bar chart to show open closed percentages
            chtBarOpenClose.Series.RemoveAt(0);
            chtBarOpenClose.ChartAreas[0].AxisY.Maximum = 100;
            chtBarOpenClose.Series.Add("Open %").Points.AddY(100 / (totalClosed + totalOpen) * totalOpen);
            chtBarOpenClose.Series.Add("Closed %").Points.AddY(100 / (totalClosed + totalOpen) * totalClosed);
        }

        private void btnOpenJobs_Click(object sender, EventArgs e)
        {
            // inform user where file is to be saved
            MessageBox.Show("This document will be saved as default to your desktop", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\OpenJobReport.docx";
            var doc = DocX.Create(fileName);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tOpen Job Report");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis report details all workshop jobs that are currently open");
            doc.InsertParagraph();
            doc.InsertParagraph("Status: \t\tFalse = Closed / True = Open");
            doc.InsertParagraph();


            dt = jobs.getOpenJobs("All");
            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;

            Table t = doc.AddTable(rows + 1, columns);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.MediumGrid1Accent5;

            t.Rows[0].Cells[0].Paragraphs.First().Append("Job ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Customer ID");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Employee ID");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Description");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Date Logged");
            t.Rows[0].Cells[5].Paragraphs.First().Append("Date Started");
            t.Rows[0].Cells[6].Paragraphs.First().Append("Estimated Completion");
            t.Rows[0].Cells[7].Paragraphs.First().Append("Date Completed");
            t.Rows[0].Cells[8].Paragraphs.First().Append("Status");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    t.Rows[i + 1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(t);


            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            string start = dtpStartDate.Value.ToString("yyyy/MM/dd");
            string end = dtpEndDate.Value.ToString("yyyy/MM/dd");

            MessageBox.Show("This document will be saved as default to your desktop", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\CustomJobReport.docx";
            var doc = DocX.Create(fileName);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tCustom Job Report");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tCustom job report - Start: " + start + " to: " + end + " Status: " + cboStatus.Text);
            doc.InsertParagraph();
            doc.InsertParagraph("Status: \t\tFalse = Closed / True = Open");
            doc.InsertParagraph();

            dt = jobs.customReport(start, end, cboStatus.Text);

            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;

            Table t = doc.AddTable(rows + 1, columns);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.MediumGrid1Accent5;

            t.Rows[0].Cells[0].Paragraphs.First().Append("Job ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Customer ID");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Employee ID");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Description");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Date Logged");
            t.Rows[0].Cells[5].Paragraphs.First().Append("Date Started");
            t.Rows[0].Cells[6].Paragraphs.First().Append("Estimated Completion");
            t.Rows[0].Cells[7].Paragraphs.First().Append("Date Completed");
            t.Rows[0].Cells[8].Paragraphs.First().Append("Status");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    t.Rows[i + 1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(t);


            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
