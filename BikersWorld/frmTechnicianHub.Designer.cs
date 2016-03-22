namespace BikersWorld
{
    partial class frmTechnicianHub
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
            this.lblTechnicianHub = new System.Windows.Forms.Label();
            this.btnOpenJobs = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.btnCompletedJobs = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logNewJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOpenJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCompletedJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblJobs = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTechnicianHub
            // 
            this.lblTechnicianHub.AutoSize = true;
            this.lblTechnicianHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianHub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTechnicianHub.Location = new System.Drawing.Point(169, 37);
            this.lblTechnicianHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTechnicianHub.Name = "lblTechnicianHub";
            this.lblTechnicianHub.Size = new System.Drawing.Size(149, 25);
            this.lblTechnicianHub.TabIndex = 0;
            this.lblTechnicianHub.Text = "Technician Hub";
            // 
            // btnOpenJobs
            // 
            this.btnOpenJobs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenJobs.Location = new System.Drawing.Point(180, 96);
            this.btnOpenJobs.Name = "btnOpenJobs";
            this.btnOpenJobs.Size = new System.Drawing.Size(122, 45);
            this.btnOpenJobs.TabIndex = 2;
            this.btnOpenJobs.Text = "View &Open Jobs";
            this.btnOpenJobs.UseVisualStyleBackColor = true;
            this.btnOpenJobs.Click += new System.EventHandler(this.btnOpenJobs_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewJob.Location = new System.Drawing.Point(30, 96);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(122, 45);
            this.btnNewJob.TabIndex = 1;
            this.btnNewJob.Text = "Log &New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // btnCompletedJobs
            // 
            this.btnCompletedJobs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletedJobs.Location = new System.Drawing.Point(329, 97);
            this.btnCompletedJobs.Name = "btnCompletedJobs";
            this.btnCompletedJobs.Size = new System.Drawing.Size(122, 45);
            this.btnCompletedJobs.TabIndex = 3;
            this.btnCompletedJobs.Text = "View Completed &Jobs";
            this.btnCompletedJobs.UseVisualStyleBackColor = true;
            this.btnCompletedJobs.Click += new System.EventHandler(this.btnCompletedJobs_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(30, 173);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(122, 45);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "Add New &Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Location = new System.Drawing.Point(30, 249);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(122, 45);
            this.btnManagement.TabIndex = 6;
            this.btnManagement.Text = "&Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "&Function";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Lo&g Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logNewJobToolStripMenuItem,
            this.viewOpenJobsToolStripMenuItem,
            this.viewCompletedJobsToolStripMenuItem});
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.jobsToolStripMenuItem.Text = "Jo&bs";
            // 
            // logNewJobToolStripMenuItem
            // 
            this.logNewJobToolStripMenuItem.Name = "logNewJobToolStripMenuItem";
            this.logNewJobToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logNewJobToolStripMenuItem.Text = "Log Ne&w Job";
            this.logNewJobToolStripMenuItem.Click += new System.EventHandler(this.logNewJobToolStripMenuItem_Click);
            // 
            // viewOpenJobsToolStripMenuItem
            // 
            this.viewOpenJobsToolStripMenuItem.Name = "viewOpenJobsToolStripMenuItem";
            this.viewOpenJobsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewOpenJobsToolStripMenuItem.Text = "V&iew Open Jobs";
            this.viewOpenJobsToolStripMenuItem.Click += new System.EventHandler(this.viewOpenJobsToolStripMenuItem_Click);
            // 
            // viewCompletedJobsToolStripMenuItem
            // 
            this.viewCompletedJobsToolStripMenuItem.Name = "viewCompletedJobsToolStripMenuItem";
            this.viewCompletedJobsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewCompletedJobsToolStripMenuItem.Text = "View Complete&d Jobs";
            this.viewCompletedJobsToolStripMenuItem.Click += new System.EventHandler(this.viewCompletedJobsToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Cus&tomer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewCustomerToolStripMenuItem.Text = "&Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Custome&rs";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem1});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.managementToolStripMenuItem.Text = "Management Tool&s";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem1
            // 
            this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            this.managementToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.managementToolStripMenuItem1.Text = "O&pen Management";
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobs.Location = new System.Drawing.Point(33, 76);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(34, 14);
            this.lblJobs.TabIndex = 7;
            this.lblJobs.Text = "Jobs";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(33, 156);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 14);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer";
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.Location = new System.Drawing.Point(33, 232);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(79, 14);
            this.lblManagement.TabIndex = 9;
            this.lblManagement.Text = "Management";
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.Location = new System.Drawing.Point(180, 173);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(122, 45);
            this.btnViewCustomers.TabIndex = 5;
            this.btnViewCustomers.Text = "&View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(305, 303);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 30);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(392, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTechnicianHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(480, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnCompletedJobs);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.btnOpenJobs);
            this.Controls.Add(this.lblTechnicianHub);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmTechnicianHub";
            this.Text = "Technician Hub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechnicianHub;
        private System.Windows.Forms.Button btnOpenJobs;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.Button btnCompletedJobs;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logNewJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOpenJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCompletedJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
    }
}

