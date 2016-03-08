using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Customer : Person
    {
        private int _CustomerID;


        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }


        }

        public Customer(int _CustomerID, string _Title, string _Fname, string _Lname, string _Address1, 
            string _Address2, string _Address3, string _Postcode, string _Email, string _Telephone1, string _Telephone2)
     {

            CustomerID =  _CustomerID;
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
   
    
    
    
    }

}
