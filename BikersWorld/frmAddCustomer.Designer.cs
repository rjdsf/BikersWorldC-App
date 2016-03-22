namespace BikersWorld
{
    partial class frmAddCustomer
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtTelphone1 = new System.Windows.Forms.TextBox();
            this.txtTelephone2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblForeName = new System.Windows.Forms.Label();
            this.lblSureName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chekCosutomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addcosumersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 115);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(143, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(108, 154);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(145, 20);
            this.txtAddress1.TabIndex = 3;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(107, 195);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(146, 20);
            this.txtAddress2.TabIndex = 4;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(104, 237);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(148, 20);
            this.txtPostcode.TabIndex = 5;
            // 
            // txtTelphone1
            // 
            this.txtTelphone1.Location = new System.Drawing.Point(103, 278);
            this.txtTelphone1.Name = "txtTelphone1";
            this.txtTelphone1.Size = new System.Drawing.Size(150, 20);
            this.txtTelphone1.TabIndex = 6;
            // 
            // txtTelephone2
            // 
            this.txtTelephone2.Location = new System.Drawing.Point(102, 315);
            this.txtTelephone2.Name = "txtTelephone2";
            this.txtTelephone2.Size = new System.Drawing.Size(151, 20);
            this.txtTelephone2.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 354);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(523, 348);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(175, 41);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "add new coustomers ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // lblForeName
            // 
            this.lblForeName.AutoSize = true;
            this.lblForeName.Location = new System.Drawing.Point(36, 75);
            this.lblForeName.Name = "lblForeName";
            this.lblForeName.Size = new System.Drawing.Size(54, 13);
            this.lblForeName.TabIndex = 11;
            this.lblForeName.Text = "Forename";
            // 
            // lblSureName
            // 
            this.lblSureName.AutoSize = true;
            this.lblSureName.Location = new System.Drawing.Point(39, 115);
            this.lblSureName.Name = "lblSureName";
            this.lblSureName.Size = new System.Drawing.Size(47, 13);
            this.lblSureName.TabIndex = 12;
            this.lblSureName.Text = "surname";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(37, 155);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(47, 13);
            this.lblAddress1.TabIndex = 13;
            this.lblAddress1.Text = "adress 1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(35, 200);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(47, 13);
            this.lblAddress2.TabIndex = 14;
            this.lblAddress2.Text = "adress 2";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(35, 240);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 15;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(37, 285);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(27, 13);
            this.lblTel1.TabIndex = 16;
            this.lblTel1.Text = "tel 1";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(39, 322);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(27, 13);
            this.lblTel2.TabIndex = 17;
            this.lblTel2.Text = "tel 2";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 357);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "email";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fielToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fielToolStripMenuItem
            // 
            this.fielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.fielToolStripMenuItem.Name = "fielToolStripMenuItem";
            this.fielToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fielToolStripMenuItem.Text = "file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.chekCosutomerToolStripMenuItem,
            this.addcosumersToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.formToolStripMenuItem.Text = "form&z";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ordersToolStripMenuItem.Text = "orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.salesToolStripMenuItem.Text = "sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // chekCosutomerToolStripMenuItem
            // 
            this.chekCosutomerToolStripMenuItem.Name = "chekCosutomerToolStripMenuItem";
            this.chekCosutomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.chekCosutomerToolStripMenuItem.Text = "chek cosutomer ";
            this.chekCosutomerToolStripMenuItem.Click += new System.EventHandler(this.chekCosutomerToolStripMenuItem_Click);
            // 
            // addcosumersToolStripMenuItem
            // 
            this.addcosumersToolStripMenuItem.Name = "addcosumersToolStripMenuItem";
            this.addcosumersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addcosumersToolStripMenuItem.Text = "add cuostomers";
            this.addcosumersToolStripMenuItem.Click += new System.EventHandler(this.addcosumersToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 38);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCabcel_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblSureName);
            this.Controls.Add(this.lblForeName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone2);
            this.Controls.Add(this.txtTelphone1);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddCustomer";
            this.Text = "add costomer form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtTelphone1;
        private System.Windows.Forms.TextBox txtTelephone2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblForeName;
        private System.Windows.Forms.Label lblSureName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chekCosutomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addcosumersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}