namespace BikersWorld.Reports
{
    partial class frmSalesReports
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
            this.grpSalesPersonReports = new System.Windows.Forms.GroupBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.grpSalesPersonReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSalesPersonReports
            // 
            this.grpSalesPersonReports.Controls.Add(this.btnGetReport);
            this.grpSalesPersonReports.Controls.Add(this.ckbAll);
            this.grpSalesPersonReports.Controls.Add(this.dtpTo);
            this.grpSalesPersonReports.Controls.Add(this.dtpFrom);
            this.grpSalesPersonReports.Controls.Add(this.cboEmployee);
            this.grpSalesPersonReports.Controls.Add(this.lblTo);
            this.grpSalesPersonReports.Controls.Add(this.lblFrom);
            this.grpSalesPersonReports.Controls.Add(this.lblEmployee);
            this.grpSalesPersonReports.Location = new System.Drawing.Point(13, 13);
            this.grpSalesPersonReports.Name = "grpSalesPersonReports";
            this.grpSalesPersonReports.Size = new System.Drawing.Size(294, 158);
            this.grpSalesPersonReports.TabIndex = 0;
            this.grpSalesPersonReports.TabStop = false;
            this.grpSalesPersonReports.Text = "Sales Person Report";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 44);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 75);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 102);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(67, 41);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(121, 21);
            this.cboEmployee.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(67, 69);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(67, 96);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 5;
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(206, 45);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(37, 17);
            this.ckbAll.TabIndex = 6;
            this.ckbAll.Text = "All";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(192, 122);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 7;
            this.btnGetReport.Text = "&Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            // 
            // frmSalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 452);
            this.Controls.Add(this.grpSalesPersonReports);
            this.Name = "frmSalesReports";
            this.Text = "Sales Reports";
            this.grpSalesPersonReports.ResumeLayout(false);
            this.grpSalesPersonReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalesPersonReports;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblEmployee;
    }
}