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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
            
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {

            frmStaffManagement formStaffManagement = new frmStaffManagement();

            formStaffManagement.Show();



        }   



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void stockControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            frmStockControl StockControl = new frmStockControl();
            StockControl.ShowDialog();
        }

        private void btnProcessJob_Click(object sender, EventArgs e)
        {
            frmTechnicianHub Technician = new frmTechnicianHub();
            Technician.ShowDialog();
        }
    }
}
