namespace BikersWorld
{
    partial class frmReportJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpMonthlyFigures = new System.Windows.Forms.GroupBox();
            this.grpCustomReport = new System.Windows.Forms.GroupBox();
            this.btnOpenJobs = new System.Windows.Forms.Button();
            this.lblOpenJobs = new System.Windows.Forms.Label();
            this.lblClosedJobs = new System.Windows.Forms.Label();
            this.lblOpenJobsResult = new System.Windows.Forms.Label();
            this.lblClosedJobsResult = new System.Windows.Forms.Label();
            this.lblCustomReportInfo = new System.Windows.Forms.Label();
            this.chtMonthlyFigures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtBarOpenClose = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.grpMonthlyFigures.SuspendLayout();
            this.grpCustomReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMonthlyFigures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBarOpenClose)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMonthlyFigures
            // 
            this.grpMonthlyFigures.Controls.Add(this.chtMonthlyFigures);
            this.grpMonthlyFigures.Location = new System.Drawing.Point(13, 13);
            this.grpMonthlyFigures.Name = "grpMonthlyFigures";
            this.grpMonthlyFigures.Size = new System.Drawing.Size(314, 478);
            this.grpMonthlyFigures.TabIndex = 0;
            this.grpMonthlyFigures.TabStop = false;
            this.grpMonthlyFigures.Text = "Monthly Figures";
            // 
            // grpCustomReport
            // 
            this.grpCustomReport.Controls.Add(this.btnRunReport);
            this.grpCustomReport.Controls.Add(this.lblStatus);
            this.grpCustomReport.Controls.Add(this.lblEnd);
            this.grpCustomReport.Controls.Add(this.lblStart);
            this.grpCustomReport.Controls.Add(this.cboStatus);
            this.grpCustomReport.Controls.Add(this.dtpEndDate);
            this.grpCustomReport.Controls.Add(this.dtpStartDate);
            this.grpCustomReport.Controls.Add(this.lblCustomReportInfo);
            this.grpCustomReport.Location = new System.Drawing.Point(586, 13);
            this.grpCustomReport.Name = "grpCustomReport";
            this.grpCustomReport.Size = new System.Drawing.Size(318, 477);
            this.grpCustomReport.TabIndex = 1;
            this.grpCustomReport.TabStop = false;
            this.grpCustomReport.Text = "Custom Report";
            // 
            // btnOpenJobs
            // 
            this.btnOpenJobs.Location = new System.Drawing.Point(341, 20);
            this.btnOpenJobs.Name = "btnOpenJobs";
            this.btnOpenJobs.Size = new System.Drawing.Size(234, 105);
            this.btnOpenJobs.TabIndex = 2;
            this.btnOpenJobs.Text = "&Open Jobs Report";
            this.btnOpenJobs.UseVisualStyleBackColor = true;
            this.btnOpenJobs.Click += new System.EventHandler(this.btnOpenJobs_Click);
            // 
            // lblOpenJobs
            // 
            this.lblOpenJobs.AutoSize = true;
            this.lblOpenJobs.Location = new System.Drawing.Point(380, 141);
            this.lblOpenJobs.Name = "lblOpenJobs";
            this.lblOpenJobs.Size = new System.Drawing.Size(61, 13);
            this.lblOpenJobs.TabIndex = 3;
            this.lblOpenJobs.Text = "Open Jobs:";
            // 
            // lblClosedJobs
            // 
            this.lblClosedJobs.AutoSize = true;
            this.lblClosedJobs.Location = new System.Drawing.Point(380, 178);
            this.lblClosedJobs.Name = "lblClosedJobs";
            this.lblClosedJobs.Size = new System.Drawing.Size(67, 13);
            this.lblClosedJobs.TabIndex = 4;
            this.lblClosedJobs.Text = "Closed Jobs:";
            // 
            // lblOpenJobsResult
            // 
            this.lblOpenJobsResult.AutoSize = true;
            this.lblOpenJobsResult.Location = new System.Drawing.Point(468, 141);
            this.lblOpenJobsResult.Name = "lblOpenJobsResult";
            this.lblOpenJobsResult.Size = new System.Drawing.Size(14, 13);
            this.lblOpenJobsResult.TabIndex = 5;
            this.lblOpenJobsResult.Text = "#";
            // 
            // lblClosedJobsResult
            // 
            this.lblClosedJobsResult.AutoSize = true;
            this.lblClosedJobsResult.Location = new System.Drawing.Point(471, 178);
            this.lblClosedJobsResult.Name = "lblClosedJobsResult";
            this.lblClosedJobsResult.Size = new System.Drawing.Size(14, 13);
            this.lblClosedJobsResult.TabIndex = 6;
            this.lblClosedJobsResult.Text = "#";
            // 
            // lblCustomReportInfo
            // 
            this.lblCustomReportInfo.AutoSize = true;
            this.lblCustomReportInfo.Location = new System.Drawing.Point(42, 73);
            this.lblCustomReportInfo.Name = "lblCustomReportInfo";
            this.lblCustomReportInfo.Size = new System.Drawing.Size(238, 39);
            this.lblCustomReportInfo.TabIndex = 0;
            this.lblCustomReportInfo.Text = "Please select a start and end date for your \r\nreport below. The status of the job" +
    "s you wish the \r\nreport to be based upon is also changeable.\r\n";
            // 
            // chtMonthlyFigures
            // 
            chartArea5.Name = "ChartArea1";
            this.chtMonthlyFigures.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtMonthlyFigures.Legends.Add(legend5);
            this.chtMonthlyFigures.Location = new System.Drawing.Point(7, 20);
            this.chtMonthlyFigures.Name = "chtMonthlyFigures";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chtMonthlyFigures.Series.Add(series5);
            this.chtMonthlyFigures.Size = new System.Drawing.Size(300, 452);
            this.chtMonthlyFigures.TabIndex = 0;
            this.chtMonthlyFigures.Text = "chart1";
            // 
            // chtBarOpenClose
            // 
            chartArea6.Name = "ChartArea1";
            this.chtBarOpenClose.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtBarOpenClose.Legends.Add(legend6);
            this.chtBarOpenClose.Location = new System.Drawing.Point(341, 253);
            this.chtBarOpenClose.Name = "chtBarOpenClose";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chtBarOpenClose.Series.Add(series6);
            this.chtBarOpenClose.Size = new System.Drawing.Size(234, 232);
            this.chtBarOpenClose.TabIndex = 7;
            this.chtBarOpenClose.Text = "chart2";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(99, 188);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(99, 251);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(99, 322);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 21);
            this.cboStatus.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(25, 194);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(28, 257);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(219, 422);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnRunReport.TabIndex = 7;
            this.btnRunReport.Text = "&Run";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // frmReportJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 516);
            this.Controls.Add(this.chtBarOpenClose);
            this.Controls.Add(this.lblClosedJobsResult);
            this.Controls.Add(this.lblOpenJobsResult);
            this.Controls.Add(this.lblClosedJobs);
            this.Controls.Add(this.lblOpenJobs);
            this.Controls.Add(this.btnOpenJobs);
            this.Controls.Add(this.grpCustomReport);
            this.Controls.Add(this.grpMonthlyFigures);
            this.Name = "frmReportJob";
            this.Text = "frmReportJob";
            this.Load += new System.EventHandler(this.frmReportJob_Load);
            this.grpMonthlyFigures.ResumeLayout(false);
            this.grpCustomReport.ResumeLayout(false);
            this.grpCustomReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMonthlyFigures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBarOpenClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMonthlyFigures;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMonthlyFigures;
        private System.Windows.Forms.GroupBox grpCustomReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblCustomReportInfo;
        private System.Windows.Forms.Button btnOpenJobs;
        private System.Windows.Forms.Label lblOpenJobs;
        private System.Windows.Forms.Label lblClosedJobs;
        private System.Windows.Forms.Label lblOpenJobsResult;
        private System.Windows.Forms.Label lblClosedJobsResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBarOpenClose;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}