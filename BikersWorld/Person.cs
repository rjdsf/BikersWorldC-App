using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Person
    {

        private string _Fname;
        private string _Title;
        private string _Lname;
        private string _Address1;
        private string _Address2;
        private string _Address3;
        private string _Telephone1;
        private string _Telephone2;
        private string _Email;
        private string _Postcode;

   
    
        protected string Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                _Fname = value;
            }
        }


        protected string Title
        {
            get
            {
                return _Title;  
            }
            set
            {
                _Title = value;

            }
        }

        protected string Lname
        {
            get
            {
                return _Lname;
            }
            set
            {
                _Lname = value;
            }
        }

        protected string Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                _Address1 = value;
            }
        }

        protected string Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                _Address2 = value;
            }
        }

        protected string Address3
        {
            get
            {
                return _Address3;
            }
            set
            {
                _Address3 = value;
            }
        }

        protected string Telephone1
        {
            get
            {
                return _Telephone1;
            }
            set
            {
                _Telephone1 = value;
            }
        }

        protected string Telephone2
        {
            get
            {
                return _Telephone2;
            }
            set
            {
                _Telephone2 = value;
            }
        }

        protected string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        protected string Postcode
        {
            get
            {
                return _Postcode;
            }
            set
            {
                _Postcode = value;
            }
        }
    }
}
