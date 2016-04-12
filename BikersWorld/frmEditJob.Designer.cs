namespace BikersWorld
{
    partial class frmLogNewJob
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
            this.lblEditJob = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateLogged = new System.Windows.Forms.Label();
            this.lblDateStarted = new System.Windows.Forms.Label();
            this.lblEstimatedCompletionDate = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.lblJobOpenClosed = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.combJobOpenClosed = new System.Windows.Forms.ComboBox();
            this.txtDateLogged = new System.Windows.Forms.MaskedTextBox();
            this.txtDateStarted = new System.Windows.Forms.MaskedTextBox();
            this.txtEstimatedCompletionDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCompletionDate = new System.Windows.Forms.MaskedTextBox();
            this.lblIDSearch = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditJob
            // 
            this.lblEditJob.AutoSize = true;
            this.lblEditJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditJob.Location = new System.Drawing.Point(271, 33);
            this.lblEditJob.Name = "lblEditJob";
            this.lblEditJob.Size = new System.Drawing.Size(83, 25);
            this.lblEditJob.TabIndex = 1;
            this.lblEditJob.Text = "Edit Job";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "&Functions";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.submitToolStripMenuItem.Text = "S&ubmit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(22, 140);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(22, 193);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 252);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblDateLogged
            // 
            this.lblDateLogged.AutoSize = true;
            this.lblDateLogged.Location = new System.Drawing.Point(22, 313);
            this.lblDateLogged.Name = "lblDateLogged";
            this.lblDateLogged.Size = new System.Drawing.Size(69, 13);
            this.lblDateLogged.TabIndex = 6;
            this.lblDateLogged.Text = "Date Logged";
            // 
            // lblDateStarted
            // 
            this.lblDateStarted.AutoSize = true;
            this.lblDateStarted.Location = new System.Drawing.Point(331, 140);
            this.lblDateStarted.Name = "lblDateStarted";
            this.lblDateStarted.Size = new System.Drawing.Size(67, 13);
            this.lblDateStarted.TabIndex = 7;
            this.lblDateStarted.Text = "Date Started";
            // 
            // lblEstimatedCompletionDate
            // 
            this.lblEstimatedCompletionDate.AutoSize = true;
            this.lblEstimatedCompletionDate.Location = new System.Drawing.Point(331, 193);
            this.lblEstimatedCompletionDate.Name = "lblEstimatedCompletionDate";
            this.lblEstimatedCompletionDate.Size = new System.Drawing.Size(134, 13);
            this.lblEstimatedCompletionDate.TabIndex = 8;
            this.lblEstimatedCompletionDate.Text = "Estimated Completion Date";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(331, 252);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(85, 13);
            this.lblCompletionDate.TabIndex = 9;
            this.lblCompletionDate.Text = "Completion Date";
            // 
            // lblJobOpenClosed
            // 
            this.lblJobOpenClosed.AutoSize = true;
            this.lblJobOpenClosed.Location = new System.Drawing.Point(331, 313);
            this.lblJobOpenClosed.Name = "lblJobOpenClosed";
            this.lblJobOpenClosed.Size = new System.Drawing.Size(90, 13);
            this.lblJobOpenClosed.TabIndex = 10;
            this.lblJobOpenClosed.Text = "Job Open/Closed";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 233);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 55);
            this.txtDescription.TabIndex = 30;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(168, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 31);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(334, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 31);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 25);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(107, 137);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerID.TabIndex = 28;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(107, 190);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(108, 20);
            this.txtEmployeeID.TabIndex = 29;
            // 
            // combJobOpenClosed
            // 
            this.combJobOpenClosed.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed"});
            this.combJobOpenClosed.FormattingEnabled = true;
            this.combJobOpenClosed.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.combJobOpenClosed.Location = new System.Drawing.Point(467, 313);
            this.combJobOpenClosed.Name = "combJobOpenClosed";
            this.combJobOpenClosed.Size = new System.Drawing.Size(108, 21);
            this.combJobOpenClosed.TabIndex = 35;
            // 
            // txtDateLogged
            // 
            this.txtDateLogged.Location = new System.Drawing.Point(107, 313);
            this.txtDateLogged.Mask = "00/00/0000 90:00";
            this.txtDateLogged.Name = "txtDateLogged";
            this.txtDateLogged.Size = new System.Drawing.Size(108, 20);
            this.txtDateLogged.TabIndex = 31;
            this.txtDateLogged.Text = "000000000000";
            this.txtDateLogged.ValidatingType = typeof(System.DateTime);
            this.txtDateLogged.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDateLogged_MaskInputRejected);
            // 
            // txtDateStarted
            // 
            this.txtDateStarted.Location = new System.Drawing.Point(467, 137);
            this.txtDateStarted.Mask = "00/00/0000 90:00";
            this.txtDateStarted.Name = "txtDateStarted";
            this.txtDateStarted.Size = new System.Drawing.Size(108, 20);
            this.txtDateStarted.TabIndex = 32;
            this.txtDateStarted.Text = "000000000000";
            this.txtDateStarted.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstimatedCompletionDate
            // 
            this.txtEstimatedCompletionDate.Location = new System.Drawing.Point(467, 190);
            this.txtEstimatedCompletionDate.Mask = "00/00/0000 90:00";
            this.txtEstimatedCompletionDate.Name = "txtEstimatedCompletionDate";
            this.txtEstimatedCompletionDate.Size = new System.Drawing.Size(108, 20);
            this.txtEstimatedCompletionDate.TabIndex = 33;
            this.txtEstimatedCompletionDate.Text = "000000000000";
            this.txtEstimatedCompletionDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.Location = new System.Drawing.Point(467, 249);
            this.txtCompletionDate.Mask = "00/00/0000 90:00";
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.Size = new System.Drawing.Size(108, 20);
            this.txtCompletionDate.TabIndex = 34;
            this.txtCompletionDate.Text = "000000000000";
            this.txtCompletionDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblIDSearch
            // 
            this.lblIDSearch.AutoSize = true;
            this.lblIDSearch.Location = new System.Drawing.Point(168, 83);
            this.lblIDSearch.Name = "lblIDSearch";
            this.lblIDSearch.Size = new System.Drawing.Size(75, 13);
            this.lblIDSearch.TabIndex = 39;
            this.lblIDSearch.Text = "Job ID Search";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(253, 80);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(127, 20);
            this.txtIDSearch.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(392, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 20);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmLogNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 422);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.lblIDSearch);
            this.Controls.Add(this.txtCompletionDate);
            this.Controls.Add(this.txtEstimatedCompletionDate);
            this.Controls.Add(this.txtDateStarted);
            this.Controls.Add(this.txtDateLogged);
            this.Controls.Add(this.combJobOpenClosed);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblJobOpenClosed);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblEstimatedCompletionDate);
            this.Controls.Add(this.lblDateStarted);
            this.Controls.Add(this.lblDateLogged);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblEditJob);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogNewJob";
            this.Text = "Edit Job";
            this.Load += new System.EventHandler(this.frmLogNewJob_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateLogged;
        private System.Windows.Forms.Label lblDateStarted;
        private System.Windows.Forms.Label lblEstimatedCompletionDate;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Label lblJobOpenClosed;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.ComboBox combJobOpenClosed;
        private System.Windows.Forms.MaskedTextBox txtDateLogged;
        private System.Windows.Forms.MaskedTextBox txtDateStarted;
        private System.Windows.Forms.MaskedTextBox txtEstimatedCompletionDate;
        private System.Windows.Forms.MaskedTextBox txtCompletionDate;
        private System.Windows.Forms.Label lblIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}