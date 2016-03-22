using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class job
    {
        dbEW accessDB = new dbEW();
        DataTable dt = new DataTable();

        public int JobID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int CustomerID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int EmployeeID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Description
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public String DateLogged
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string DateStarted
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string EstimatedCompletionDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string DateCompleted
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool JobOpenClose
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DataTable getOpenJobs()
        {
            string query = "select * FROM jobs WHERE job_open_close = 1";
            dt = accessDB.grabAll(query);
            return dt;

        }

        public DataTable getCompletedJobs()
        {
            string query = "select * FROM jobs WHERE job_open_close = 2";
            dt = accessDB.grabAll(query);
            return dt;

        }



    }

}