using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
/*
 * Submit button functionality
 * Submit button menu strip
*/

#endregion

namespace BikersWorld
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            combTitle.Text = ("");
            txtForename.Clear();
            txtSurname.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtPostcode.Clear();
            txtTelephone1.Clear();
            txtTelephone2.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            combTitle.Text = ("");
            txtForename.Clear();
            txtSurname.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtPostcode.Clear();
            txtTelephone1.Clear();
            txtTelephone2.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
