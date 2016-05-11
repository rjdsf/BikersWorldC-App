namespace BikersWorld
{
    partial class frmReportSales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpMonthlySalesComparasion = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSalesPresonReport = new System.Windows.Forms.GroupBox();
            this.cboSalesPerson = new System.Windows.Forms.ComboBox();
            this.dtpSalePersonEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpSalesPersonStart = new System.Windows.Forms.DateTimePicker();
            this.grpReportByProduct = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.grpMonthlyComparasion = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRunSalesPerson = new System.Windows.Forms.Button();
            this.grpMonthlySalesComparasion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpSalesPresonReport.SuspendLayout();
            this.grpReportByProduct.SuspendLayout();
            this.grpMonthlyComparasion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMonthlySalesComparasion
            // 
            this.grpMonthlySalesComparasion.Controls.Add(this.chart1);
            this.grpMonthlySalesComparasion.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpMonthlySalesComparasion.Location = new System.Drawing.Point(13, 13);
            this.grpMonthlySalesComparasion.Name = "grpMonthlySalesComparasion";
            this.grpMonthlySalesComparasion.Size = new System.Drawing.Size(458, 574);
            this.grpMonthlySalesComparasion.TabIndex = 0;
            this.grpMonthlySalesComparasion.TabStop = false;
            this.grpMonthlySalesComparasion.Text = "Sales Comparasion By Month";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(445, 548);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // grpSalesPresonReport
            // 
            this.grpSalesPresonReport.Controls.Add(this.btnRunSalesPerson);
            this.grpSalesPresonReport.Controls.Add(this.cboSalesPerson);
            this.grpSalesPresonReport.Controls.Add(this.dtpSalePersonEnd);
            this.grpSalesPresonReport.Controls.Add(this.dtpSalesPersonStart);
            this.grpSalesPresonReport.Location = new System.Drawing.Point(478, 13);
            this.grpSalesPresonReport.Name = "grpSalesPresonReport";
            this.grpSalesPresonReport.Size = new System.Drawing.Size(512, 162);
            this.grpSalesPresonReport.TabIndex = 1;
            this.grpSalesPresonReport.TabStop = false;
            this.grpSalesPresonReport.Text = "Sales Person Report";
            // 
            // cboSalesPerson
            // 
            this.cboSalesPerson.FormattingEnabled = true;
            this.cboSalesPerson.Location = new System.Drawing.Point(7, 122);
            this.cboSalesPerson.Name = "cboSalesPerson";
            this.cboSalesPerson.Size = new System.Drawing.Size(200, 21);
            this.cboSalesPerson.TabIndex = 2;
            // 
            // dtpSalePersonEnd
            // 
            this.dtpSalePersonEnd.Location = new System.Drawing.Point(6, 74);
            this.dtpSalePersonEnd.Name = "dtpSalePersonEnd";
            this.dtpSalePersonEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpSalePersonEnd.TabIndex = 1;
            // 
            // dtpSalesPersonStart
            // 
            this.dtpSalesPersonStart.Location = new System.Drawing.Point(7, 30);
            this.dtpSalesPersonStart.Name = "dtpSalesPersonStart";
            this.dtpSalesPersonStart.Size = new System.Drawing.Size(200, 20);
            this.dtpSalesPersonStart.TabIndex = 0;
            // 
            // grpReportByProduct
            // 
            this.grpReportByProduct.Controls.Add(this.comboBox1);
            this.grpReportByProduct.Controls.Add(this.dateTimePicker4);
            this.grpReportByProduct.Controls.Add(this.dateTimePicker3);
            this.grpReportByProduct.Location = new System.Drawing.Point(478, 181);
            this.grpReportByProduct.Name = "grpReportByProduct";
            this.grpReportByProduct.Size = new System.Drawing.Size(512, 193);
            this.grpReportByProduct.TabIndex = 2;
            this.grpReportByProduct.TabStop = false;
            this.grpReportByProduct.Text = "Report by Product";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(7, 112);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(7, 50);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // grpMonthlyComparasion
            // 
            this.grpMonthlyComparasion.Controls.Add(this.dateTimePicker2);
            this.grpMonthlyComparasion.Controls.Add(this.dateTimePicker1);
            this.grpMonthlyComparasion.Location = new System.Drawing.Point(478, 381);
            this.grpMonthlyComparasion.Name = "grpMonthlyComparasion";
            this.grpMonthlyComparasion.Size = new System.Drawing.Size(512, 206);
            this.grpMonthlyComparasion.TabIndex = 3;
            this.grpMonthlyComparasion.TabStop = false;
            this.grpMonthlyComparasion.Text = "Month Sales Comparasion";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 141);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnRunSalesPerson
            // 
            this.btnRunSalesPerson.Location = new System.Drawing.Point(283, 120);
            this.btnRunSalesPerson.Name = "btnRunSalesPerson";
            this.btnRunSalesPerson.Size = new System.Drawing.Size(167, 23);
            this.btnRunSalesPerson.TabIndex = 3;
            this.btnRunSalesPerson.Text = "Get &Sales Person Report";
            this.btnRunSalesPerson.UseVisualStyleBackColor = true;
            this.btnRunSalesPerson.Click += new System.EventHandler(this.btnRunSalesPerson_Click);
            // 
            // frmReportSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 600);
            this.Controls.Add(this.grpMonthlyComparasion);
            this.Controls.Add(this.grpReportByProduct);
            this.Controls.Add(this.grpSalesPresonReport);
            this.Controls.Add(this.grpMonthlySalesComparasion);
            this.Name = "frmReportSales";
            this.Text = "Sales Reports";
            this.Load += new System.EventHandler(this.frmReportSales_Load);
            this.grpMonthlySalesComparasion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpSalesPresonReport.ResumeLayout(false);
            this.grpReportByProduct.ResumeLayout(false);
            this.grpMonthlyComparasion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMonthlySalesComparasion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox grpSalesPresonReport;
        private System.Windows.Forms.ComboBox cboSalesPerson;
        private System.Windows.Forms.DateTimePicker dtpSalePersonEnd;
        private System.Windows.Forms.DateTimePicker dtpSalesPersonStart;
        private System.Windows.Forms.GroupBox grpReportByProduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.GroupBox grpMonthlyComparasion;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRunSalesPerson;
    }
}