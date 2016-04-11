﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Supplier : Person
    {

        dbR mydb = new dbR();
        DataTable dt = new DataTable();
        private string _SupplierName;
        private string _SupplierID;


        public string SupplierName
        {
            get
            {
                return _SupplierName;
            }
            set
            {
                _SupplierName = value;
            }
        }

        public string SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                _SupplierID = value;
            }
        }

        public Supplier(string SupplierID, string SupplierName, string _Address1,
            string _Address2, string _Address3, string _Postcode, string _Telephone1, string _Telephone2, string _Email)
        {

            _SupplierID = SupplierID;
            _SupplierName = SupplierName;
            this.Title = Title;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Address3 = Address3;
            this.Postcode = Postcode;
            this.Telephone1 = Telephone1;
            this.Telephone2 = Telephone2;
            this.Email = Email;
        }

        public Supplier()
        {
        }

        public DataTable getAllSuppliers()

        {

            string query = "SELECT * FROM suppliers;";

            return dt = mydb.getDataTable(query);

        }

        public DataTable getSearchSuppliers(string supplierId, string supplierName)

        {

            string query = "SELECT * FROM suppliers where supplier_id ='" + supplierId + "' or supplier_name LIKE '" + supplierName + "';";

            return dt = mydb.getDataTable(query);

        }
    }
}
