using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    public partial class frmSuppliersManagement : Form
    {

        Supplier suppSearch = new Supplier();
        public frmSuppliersManagement()
        {
            InitializeComponent();
        }

        private void frmSuppliersManagement_Load(object sender, EventArgs e)
        {
            dgvSuppList.DataSource = suppSearch.getAllSuppliers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            grbEdit.Text = "Supplier N:";
            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
            grbOptions.Visible = false;
            btnSubmit.Visible = false;


            if (string.IsNullOrWhiteSpace(txtSuppId.Text) && string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {




                MessageBox.Show("please insert a valid value");

            }
            else
            {


                dgvSuppList.DataSource = suppSearch.getSearchSuppliers(txtSuppId.Text, txtSupplierName.Text);

            }





        }
    }
}
