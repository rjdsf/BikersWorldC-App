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
    public partial class frmLogins : Form
    {
        private string selectedID;

        #region To do
        /*
        build the management of logins  for the staff members

        */
        #endregion

        public frmLogins(string selectedID)
        {
            InitializeComponent();
            this.selectedID = selectedID;
        }
   

        private void frmLogins_Load(object sender, EventArgs e)
        {

            lblDebug.Text = selectedID;


        }
    }
}
