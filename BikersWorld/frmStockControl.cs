using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;
using System.Diagnostics;

namespace BikersWorld
{
    public partial class frmStockControl : Form
    {
        Item items = new Item();
        db accessDB = new db();
        DataTable dt = new DataTable();
        Item thisItem = new Item();

        public frmStockControl()
        {
            

            InitializeComponent();
        }

        
        private void frmStockControl_Load(object sender, EventArgs e)
        {
            //code in this region used to populate the dataGridView with all current products
            getAllProducts();
        }


        public void getAllProducts()
        {
            dt = items.Populate_dgvProducts();
            dgvProductInformation.DataSource = dt;
            hideUnwantedColumns();
        }

        //used to hide unwanted columns within the datagride that are still required for instantiation
        public void hideUnwantedColumns()
        {
            for (int i = 0; i < dgvProductInformation.ColumnCount; i++)
            {
                switch (i)
                {
                    case 0:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 3:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 6:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 8:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 9:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 10:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 11:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 13:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 14:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;
                    case 15:
                        this.dgvProductInformation.Columns[i].Visible = false;
                        break;

                }



            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) && string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Please enter some criteria in order to search upon!", "No Seatch Criteria", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtProductName.Focus();
            }
            else if (txtProductName.Text.Length > 0 && string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                dt = items.searchProducts(txtProductName.Text ,null, "product");
                dgvProductInformation.DataSource = dt;
                hideUnwantedColumns();
            }
            else if (string.IsNullOrWhiteSpace(txtProductName.Text) && txtSupplier.Text.Length > 0)
            {
                dt = items.searchProducts(txtSupplier.Text, null , "supplier");
                dgvProductInformation.DataSource = dt;
                hideUnwantedColumns();
            }
            else if (txtProductName.Text.Length > 0 && txtSupplier.Text.Length > 0)
            {
                dt = items.searchProducts(txtProductName.Text, txtSupplier.Text, "both");
                dgvProductInformation.DataSource = dt;
                hideUnwantedColumns();
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            getAllProducts();
            dgvProductInformation.ClearSelection();
        }

       
        private void dgvProductInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thisItem.ItemID = Convert.ToInt32(dgvProductInformation.CurrentRow.Cells[0].Value);
            thisItem.ItemName = (dgvProductInformation.CurrentRow.Cells[1].Value.ToString());
            thisItem.ItemDescription = (dgvProductInformation.CurrentRow.Cells[2].Value.ToString());
            thisItem.ItemSupplierID = Convert.ToInt32(dgvProductInformation.CurrentRow.Cells[3].Value);
            thisItem.ItemSupplierName = (dgvProductInformation.CurrentRow.Cells[7].Value.ToString());
            thisItem.ItemPrice = Convert.ToDouble(dgvProductInformation.CurrentRow.Cells[4].Value);
            thisItem.ItemStock = Convert.ToInt32(dgvProductInformation.CurrentRow.Cells[5].Value);
                     
            txtItemName.Text = thisItem.ItemName;
            txtItemDesctiption.Text = thisItem.ItemDescription;
            txtCurrentStock.Text = thisItem.ItemStock.ToString();
            txtUnitPrice.Text = "£" + thisItem.ItemPrice.ToString();
            txtItemSupplier.Text = thisItem.ItemSupplierName;


        }

        private void dgvProductInformation_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvProductInformation.ClearSelection();
        }

        private void btnAdjustStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) && string.IsNullOrWhiteSpace(txtItemDesctiption.Text) && string.IsNullOrWhiteSpace(txtCurrentStock.Text) &&
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) && string.IsNullOrWhiteSpace(txtItemSupplier.Text))
            {
                MessageBox.Show("No item selected to adjust stock on!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                chkAddStock.Enabled = true;
                chkAdjustStock.Enabled = true;
                tkbStock.Enabled = true;
                txtStockAdjust.Enabled = true;
                btnSave.Enabled = true;
            }
        }
   
        private void chkAdjustStock_Click(object sender, EventArgs e)
        {
            if (chkAddStock.Checked)
            {
                chkAddStock.Checked = false;
                chkAdjustStock.Checked = true;
            }
            if (chkAdjustStock.Checked)
            {
                tkbStock.Value = thisItem.ItemStock;
                txtStockAdjust.Text = thisItem.ItemStock.ToString();
            }
        }

        private void chkAddStock_Click(object sender, EventArgs e)
        {
            if (chkAdjustStock.Checked)
            {
                chkAdjustStock.Checked = false;
                chkAddStock.Checked = true;
            }
        }

        private void tkbStock_ValueChanged(object sender, EventArgs e)
        {
            txtStockAdjust.Text = tkbStock.Value.ToString();
        }

        private void txtStockAdjust_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tkbStock.Value = Convert.ToInt32(txtStockAdjust.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Only whole numbers can be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockAdjust.Focus();
                txtStockAdjust.SelectionStart = 0;
                txtStockAdjust.SelectionLength = txtStockAdjust.Text.Length;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkAddStock.Checked)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add " + txtStockAdjust.Text + " of " + thisItem.ItemName + 
                        "?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        thisItem.ItemStock = thisItem.ItemStock + Convert.ToInt32(txtStockAdjust.Text);
                        items.updateStock(thisItem.ItemID, thisItem.ItemStock);
                        
                    }
                }
                else if  (chkAdjustStock.Checked)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to amend the stock of " + thisItem.ItemName + " from "
                        + thisItem.ItemStock + " to " + txtStockAdjust.Text + "?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        thisItem.ItemStock = Convert.ToInt32(txtStockAdjust.Text);
                        items.updateStock(thisItem.ItemID, thisItem.ItemStock);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please select if you are adding stock or amending stock quantity?", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string refresh = "SELECT * FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";
                dt = accessDB.getProducts(refresh);
                dgvProductInformation.DataSource = dt;
                hideUnwantedColumns();
                

            } catch (Exception ex)
            {
                MessageBox.Show("Only whole numbers can be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockAdjust.Focus();
            }
        }
        
        private void btnPrintStockLevels_Click(object sender, EventArgs e)
        {
            // inform user where file is to be saved
            MessageBox.Show("This document will be saved as default to your desktop", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\StockReport.docx";
            var doc = DocX.Create(fileName);
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tStock Report");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis report details all items in stock at the time of print");
            doc.InsertParagraph();


            string query = "SELECT item_id, item_name, description, quantity, supplier_name FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";
            dt = accessDB.getProducts(query);
            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;

            Table t = doc.AddTable(rows+1, columns);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.MediumGrid1Accent5;

            t.Rows[0].Cells[0].Paragraphs.First().Append("Item ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Item Name");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Description");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Stock Level");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Supplier");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    t.Rows[i+1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(t);

                                    
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);


        }

        private void grpStockAdjustment_Enter(object sender, EventArgs e)
        {

        }

        private void dgvProductInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
