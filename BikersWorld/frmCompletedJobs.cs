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
    public partial class frmCompletedJobs : Form
    {
        public frmCompletedJobs()
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

        private void frmCompletedJobs_Load(object sender, EventArgs e)
        {

        }
    }
}
