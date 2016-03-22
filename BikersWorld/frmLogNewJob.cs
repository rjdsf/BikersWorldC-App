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
 * Submit menu strip functionality
 */
#endregion

namespace BikersWorld
{
    public partial class frmLogNewJob : Form
    {
        public frmLogNewJob()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtDescription.Clear();
            txtDateLogged.Clear();
            txtDateStarted.Clear();
            txtEstimatedCompletionDate.Clear();
            txtCompletionDate.Clear();
            combJobOpenClosed.Text = ("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtDescription.Clear();
            txtDateLogged.Clear();
            txtDateStarted.Clear();
            txtEstimatedCompletionDate.Clear();
            txtCompletionDate.Clear();
            combJobOpenClosed.Text = ("");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogNewJob_Load(object sender, EventArgs e)
        {

        }
    }
}
