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
 * Database Display 
 */ 
#endregion

namespace BikersWorld
{
    public partial class frmOpenJobs : Form
    {
        job job = new job();
        DataTable dt = new DataTable();

        public frmOpenJobs()
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvOpenJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOpenJobs_Load(object sender, EventArgs e)
        {
            dt = job.getOpenJobs();
            dgvOpenJobs.DataSource = dt;
        }
    }
}