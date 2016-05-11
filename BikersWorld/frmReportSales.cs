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
    public partial class frmReportSales : Form
    {
        public frmReportSales()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        DataTable dt = new DataTable();
        salesNC sales = new salesNC();
        private void frmReportSales_Load(object sender, EventArgs e)
        {
            dt = employee.getEmployeeIDandName();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSalesPerson.Items.Add(dt.Rows[i]["employee_id"] + " " + dt.Rows[i]["forename"] + " " + dt.Rows[i]["surname"]);
            }

            cboSalesPerson.SelectedIndex = 0;
        }

        private void btnRunSalesPerson_Click(object sender, EventArgs e)
        {
            string salesPerson = cboSalesPerson.Text.ToString();
            //splits the string by null - in this instance null defaults to a space
            string[] split = salesPerson.Split(null);
            //grabs the first part of the split that is stored in an array and coverts it to an integer for report purposes
            int employeeID = Convert.ToInt16(split[0]);
            string concatenatedName = split[1] + " " + split[2];
            string start = dtpSalesPersonStart.Value.ToString("yyyy/MM/dd");
            string end = dtpSalePersonEnd.Value.ToString("yyyy/MM/dd");

            sales.reportSalesPerson(employeeID, concatenatedName, start, end);

        }
    }
}
