using System;
using System.Collections;
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
    public partial class frmSalesDashboard : Form
    {
        public frmSalesDashboard()
        {
            InitializeComponent();
        }

        private void frmSalesDashboard_Load(object sender, EventArgs e)
        {
            sale Sale = new sale();
            DataTable dt = new DataTable();
            dt = Sale.SalesmanReport();

            DataTable employees = new DataTable();
            employees = dt.DefaultView.ToTable(true, "employee_id");
            List<string> EmployeeIDs = new List<string>();

            List<int> NoOfSales = new List<int>();
            int countSale = 0;

            
            foreach (DataRow row in employees.Rows)
            {
                foreach (var id in row.ItemArray)
                {
                    EmployeeIDs.Add(id.ToString());
                }
            }

            for (int i = 0; i < EmployeeIDs.Count; i++)
            {
                foreach (DataRow id in dt.Rows)
                {
                    if (id[6].ToString() == EmployeeIDs[i])
                    {
                        countSale++;
                    }

                }

                NoOfSales.Add(countSale);
                countSale = 0;

            }

            ArrayList listDataSource = new ArrayList();

            //for (int i = 0; i < EmployeeIDs.Count; i++)
            //{
            //    listDataSource.Add(1, EmployeeIDs[i], NoOfSales[i]);
           // }

            
            
              

        }
    }
}
