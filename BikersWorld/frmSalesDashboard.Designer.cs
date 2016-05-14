namespace BikersWorld
{
    partial class frmSalesDashboard
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
            this.grpSalesCharts = new System.Windows.Forms.GroupBox();
            this.chtSalesReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSalesCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSalesCharts
            // 
            this.grpSalesCharts.Controls.Add(this.chtSalesReport);
            this.grpSalesCharts.Location = new System.Drawing.Point(13, 13);
            this.grpSalesCharts.Name = "grpSalesCharts";
            this.grpSalesCharts.Size = new System.Drawing.Size(885, 273);
            this.grpSalesCharts.TabIndex = 0;
            this.grpSalesCharts.TabStop = false;
            this.grpSalesCharts.Text = "Sales Charts";
            // 
            // chtSalesReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chtSalesReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtSalesReport.Legends.Add(legend1);
            this.chtSalesReport.Location = new System.Drawing.Point(19, 19);
            this.chtSalesReport.Name = "chtSalesReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtSalesReport.Series.Add(series1);
            this.chtSalesReport.Size = new System.Drawing.Size(404, 239);
            this.chtSalesReport.TabIndex = 0;
            this.chtSalesReport.Text = "chart1";
            // 
            // frmSalesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 465);
            this.Controls.Add(this.grpSalesCharts);
            this.Name = "frmSalesDashboard";
            this.Text = "Sales Dashboard";
            this.Load += new System.EventHandler(this.frmSalesDashboard_Load);
            this.grpSalesCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtSalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalesCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSalesReport;

    }
}