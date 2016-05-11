using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikersWorld
{
    public class Employee : Person
    {

        DataTable dt = new DataTable();
        dbNC accessDB = new dbNC();

        protected int _EmployeeID;
        protected string _Username;
        protected string _Password;
        protected int _JobRoleID;

        
        public Employee() { }

        public int EmployeeID
        {
            get
            {
                return EmployeeID;
            }
            set
            {
                EmployeeID = value;
            }
        }

        public string Username
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }

        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }

        public int JobRoleID
        {
            get
            {
                return JobRoleID; 
            }
            set
            {
                JobRoleID = value;
            }
        }

         public Employee(int _EmployeeID,string  _Username,string  _Password,int _JobRoleID, string _Title, string _Fname, string _Lname, string _Address1, 
            string _Address2, string _Address3, string _Postcode, string _Email, string _Telephone1, string _Telephone2)
     {

            EmployeeID =  _EmployeeID;
            Username = _Username;
            Password = _Password;
            JobRoleID = _JobRoleID;
            this.Title = _Title;
            this.Fname = _Fname;
            this.Lname = _Lname;
            this.Address1 = _Address1;
            this.Address2 = _Address2;
            this.Address3 = _Address3;
            this.Postcode = _Postcode;
            this.Email = _Email;
            this.Telephone1 = _Telephone1;
            this.Telephone2 = _Telephone2;


        }

        public DataTable getEmployeeIDandName()
        {
            string query = "SELECT employee_id, forename, surname FROM employee";

            try
            {
                dt = accessDB.getEmployeeDetails(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong, try again. If problem persists please contact your Network Administrator", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
