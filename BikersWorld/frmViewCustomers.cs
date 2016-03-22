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

    
    public partial class frmViewCustomers : Form
    {
        Customer Cust = new Customer();
        DataTable dt = new DataTable();

        public frmViewCustomers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewCustomers_Load(object sender, EventArgs e)
        {
            dt = Cust.getCustomers();
            dgvViewCustomers.DataSource = dt;
        }
    }
}
