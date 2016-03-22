using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region ToDoList

    /* 
     * Log Out Button Functionality
    */

#endregion

namespace BikersWorld
{
    public partial class frmTechnicianHub : Form
    {
        public frmTechnicianHub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            frmLogNewJob frm = new frmLogNewJob();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frm = new frmAddNewCustomer();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenJobs_Click(object sender, EventArgs e)
        {
            frmOpenJobs frm = new frmOpenJobs();
            frm.Show();
        }

        private void btnCompletedJobs_Click(object sender, EventArgs e)
        {
            frmCompletedJobs frm = new frmCompletedJobs();
            frm.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            frmViewCustomers frm = new frmViewCustomers();
            frm.Show();
        }

        private void viewOpenJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpenJobs frm = new frmOpenJobs();
            frm.Show();
        }

        private void viewCompletedJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompletedJobs frm = new frmCompletedJobs();
            frm.Show();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCustomers frm = new frmViewCustomers();
            frm.Show();
        }

        private void logNewJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogNewJob frm = new frmLogNewJob();
            frm.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frm = new frmAddNewCustomer();
            frm.Show();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            frmManagement frm = new frmManagement();
            frm.Show();
        }
    }
}
