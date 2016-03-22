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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {

            this.Hide();  
            MessageBox.Show("congratulation costomer sucesfully added");
            frmSales fm1 = new frmSales();
            fm1.ShowDialog();

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCabcel_Click(object sender, EventArgs e)
        {
            this.Hide();   
            frmSales fm1 = new frmSales();
            fm1.ShowDialog();
            
        }

        private void addcosumersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer form3 = new frmAddCustomer();
            this.Hide();
            form3.Show();  
        }

        private void chekCosutomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckCustomers form4 = new frmCheckCustomers();
            this.Hide();
            form4.Show();   
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders1 form5 = new frmOrders1();
this.Hide();
            form5.Show();
            
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();  
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();
        }
    }

}
