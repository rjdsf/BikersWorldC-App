namespace BikersWorld
{
    partial class frmStockControl
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
            this.grbProductSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintStockLevels = new System.Windows.Forms.Button();
            this.btnAdjustStock = new System.Windows.Forms.Button();
            this.dgvProductInformation = new System.Windows.Forms.DataGridView();
            this.grpStockAdjustment = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStockAdjust = new System.Windows.Forms.TextBox();
            this.tkbStock = new System.Windows.Forms.TrackBar();
            this.chkAdjustStock = new System.Windows.Forms.CheckBox();
            this.chkAddStock = new System.Windows.Forms.CheckBox();
            this.txtItemSupplier = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtItemDesctiption = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.grbProductSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).BeginInit();
            this.grpStockAdjustment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStock)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProductSearch
            // 
            this.grbProductSearch.Controls.Add(this.btnClear);
            this.grbProductSearch.Controls.Add(this.btnSearch);
            this.grbProductSearch.Controls.Add(this.txtSupplier);
            this.grbProductSearch.Controls.Add(this.txtProductName);
            this.grbProductSearch.Controls.Add(this.lblSupplier);
            this.grbProductSearch.Controls.Add(this.lblProductName);
            this.grbProductSearch.Location = new System.Drawing.Point(48, 26);
            this.grbProductSearch.Name = "grbProductSearch";
            this.grbProductSearch.Size = new System.Drawing.Size(413, 102);
            this.grbProductSearch.TabIndex = 0;
            this.grbProductSearch.TabStop = false;
            this.grbProductSearch.Text = "Product Search";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(319, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 63);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 64);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(101, 63);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtSupplier.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(101, 27);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(17, 66);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(17, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintStockLevels);
            this.groupBox1.Controls.Add(this.btnAdjustStock);
            this.groupBox1.Location = new System.Drawing.Point(501, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnPrintStockLevels
            // 
            this.btnPrintStockLevels.Location = new System.Drawing.Point(146, 24);
            this.btnPrintStockLevels.Name = "btnPrintStockLevels";
            this.btnPrintStockLevels.Size = new System.Drawing.Size(92, 59);
            this.btnPrintStockLevels.TabIndex = 2;
            this.btnPrintStockLevels.Text = "&Print Stock Check Report";
            this.btnPrintStockLevels.UseVisualStyleBackColor = true;
            this.btnPrintStockLevels.Click += new System.EventHandler(this.btnPrintStockLevels_Click);
            // 
            // btnAdjustStock
            // 
            this.btnAdjustStock.Location = new System.Drawing.Point(16, 27);
            this.btnAdjustStock.Name = "btnAdjustStock";
            this.btnAdjustStock.Size = new System.Drawing.Size(98, 56);
            this.btnAdjustStock.TabIndex = 0;
            this.btnAdjustStock.Text = "&Adjust Stock";
            this.btnAdjustStock.UseVisualStyleBackColor = true;
            this.btnAdjustStock.Click += new System.EventHandler(this.btnAdjustStock_Click);
            // 
            // dgvProductInformation
            // 
            this.dgvProductInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInformation.Location = new System.Drawing.Point(48, 134);
            this.dgvProductInformation.Name = "dgvProductInformation";
            this.dgvProductInformation.ReadOnly = true;
            this.dgvProductInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInformation.Size = new System.Drawing.Size(720, 231);
            this.dgvProductInformation.TabIndex = 2;
            this.dgvProductInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInformation_CellClick);
            this.dgvProductInformation.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductInformation_ColumnHeaderMouseClick);
            // 
            // grpStockAdjustment
            // 
            this.grpStockAdjustment.Controls.Add(this.btnSave);
            this.grpStockAdjustment.Controls.Add(this.txtStockAdjust);
            this.grpStockAdjustment.Controls.Add(this.tkbStock);
            this.grpStockAdjustment.Controls.Add(this.chkAdjustStock);
            this.grpStockAdjustment.Controls.Add(this.chkAddStock);
            this.grpStockAdjustment.Controls.Add(this.txtItemSupplier);
            this.grpStockAdjustment.Controls.Add(this.txtUnitPrice);
            this.grpStockAdjustment.Controls.Add(this.txtItemDesctiption);
            this.grpStockAdjustment.Controls.Add(this.txtItemName);
            this.grpStockAdjustment.Controls.Add(this.txtCurrentStock);
            this.grpStockAdjustment.Controls.Add(this.lblSupplierName);
            this.grpStockAdjustment.Controls.Add(this.lblCurrentStock);
            this.grpStockAdjustment.Controls.Add(this.lblPrice);
            this.grpStockAdjustment.Controls.Add(this.lblDescription);
            this.grpStockAdjustment.Controls.Add(this.lblItemName);
            this.grpStockAdjustment.Location = new System.Drawing.Point(49, 384);
            this.grpStockAdjustment.Name = "grpStockAdjustment";
            this.grpStockAdjustment.Size = new System.Drawing.Size(719, 225);
            this.grpStockAdjustment.TabIndex = 3;
            this.grpStockAdjustment.TabStop = false;
            this.grpStockAdjustment.Text = "Stock Adjustment";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(491, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Sa&ve";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStockAdjust
            // 
            this.txtStockAdjust.Enabled = false;
            this.txtStockAdjust.Location = new System.Drawing.Point(478, 142);
            this.txtStockAdjust.Name = "txtStockAdjust";
            this.txtStockAdjust.Size = new System.Drawing.Size(100, 20);
            this.txtStockAdjust.TabIndex = 13;
            this.txtStockAdjust.TextChanged += new System.EventHandler(this.txtStockAdjust_TextChanged);
            // 
            // tkbStock
            // 
            this.tkbStock.Enabled = false;
            this.tkbStock.Location = new System.Drawing.Point(381, 91);
            this.tkbStock.Maximum = 100;
            this.tkbStock.Name = "tkbStock";
            this.tkbStock.Size = new System.Drawing.Size(309, 45);
            this.tkbStock.TabIndex = 12;
            this.tkbStock.ValueChanged += new System.EventHandler(this.tkbStock_ValueChanged);
            // 
            // chkAdjustStock
            // 
            this.chkAdjustStock.AutoSize = true;
            this.chkAdjustStock.Enabled = false;
            this.chkAdjustStock.Location = new System.Drawing.Point(525, 34);
            this.chkAdjustStock.Name = "chkAdjustStock";
            this.chkAdjustStock.Size = new System.Drawing.Size(115, 17);
            this.chkAdjustStock.TabIndex = 11;
            this.chkAdjustStock.Text = "Adjust Stock Level";
            this.chkAdjustStock.UseVisualStyleBackColor = true;
            this.chkAdjustStock.Click += new System.EventHandler(this.chkAdjustStock_Click);
            // 
            // chkAddStock
            // 
            this.chkAddStock.AutoSize = true;
            this.chkAddStock.Enabled = false;
            this.chkAddStock.Location = new System.Drawing.Point(431, 33);
            this.chkAddStock.Name = "chkAddStock";
            this.chkAddStock.Size = new System.Drawing.Size(76, 17);
            this.chkAddStock.TabIndex = 10;
            this.chkAddStock.Text = "Add Stock";
            this.chkAddStock.UseVisualStyleBackColor = true;
            this.chkAddStock.Click += new System.EventHandler(this.chkAddStock_Click);
            // 
            // txtItemSupplier
            // 
            this.txtItemSupplier.Enabled = false;
            this.txtItemSupplier.Location = new System.Drawing.Point(88, 189);
            this.txtItemSupplier.Name = "txtItemSupplier";
            this.txtItemSupplier.Size = new System.Drawing.Size(233, 20);
            this.txtItemSupplier.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(221, 146);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // txtItemDesctiption
            // 
            this.txtItemDesctiption.Enabled = false;
            this.txtItemDesctiption.Location = new System.Drawing.Point(88, 70);
            this.txtItemDesctiption.Multiline = true;
            this.txtItemDesctiption.Name = "txtItemDesctiption";
            this.txtItemDesctiption.Size = new System.Drawing.Size(233, 57);
            this.txtItemDesctiption.TabIndex = 7;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(88, 31);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(233, 20);
            this.txtItemName.TabIndex = 6;
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Enabled = false;
            this.txtCurrentStock.Location = new System.Drawing.Point(88, 146);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.Size = new System.Drawing.Size(48, 20);
            this.txtCurrentStock.TabIndex = 5;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(7, 192);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(48, 13);
            this.lblSupplierName.TabIndex = 4;
            this.lblSupplierName.Text = "Supplier:";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Location = new System.Drawing.Point(7, 149);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentStock.TabIndex = 3;
            this.lblCurrentStock.Text = "Current Stock:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(159, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Unit Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(7, 34);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(30, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item:";
            // 
            // frmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 636);
            this.Controls.Add(this.grpStockAdjustment);
            this.Controls.Add(this.dgvProductInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbProductSearch);
            this.Name = "frmStockControl";
            this.Text = "Stock Control";
            this.Load += new System.EventHandler(this.frmStockControl_Load);
            this.grbProductSearch.ResumeLayout(false);
            this.grbProductSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).EndInit();
            this.grpStockAdjustment.ResumeLayout(false);
            this.grpStockAdjustment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintStockLevels;
        private System.Windows.Forms.Button btnAdjustStock;
        private System.Windows.Forms.DataGridView dgvProductInformation;
        private System.Windows.Forms.GroupBox grpStockAdjustment;
        private System.Windows.Forms.CheckBox chkAddStock;
        private System.Windows.Forms.TextBox txtItemSupplier;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtItemDesctiption;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.CheckBox chkAdjustStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStockAdjust;
        private System.Windows.Forms.TrackBar tkbStock;
    }
}