using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

#region ToDoList
    /*
        Create help section
    */
#endregion




namespace BikersWorld
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display application info in msgbox
            MessageBox.Show("Bikers World EPOS was created by Students of Central College Nottingham as part of a .NET Assignment", "ABOUT");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //code used to fix forms size
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // instantiate db class
            db connection = new db();

            //test is fields contaion data
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                this.Hide();
                connection.authenticate(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Please complete your login credentials in order to login!");
            }


            
            
        }

       

      
    }
}
