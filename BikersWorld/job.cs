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
        private int _JobID;
        private int _CustomerID;
        private int _EmployeeID;
        private string _Description;
        private string _DateLogged;
        private string _DateStarted;
        private string _EstimatedCompletionDate;
        private string _DateCompleted;
        private int _JobOpenClose;


        public int JobID
        {
            get
            {
                return _JobID;
            }
            set
            {
                _JobID = value;
            }
        }

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

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }

        public string DateLogged
        {
            get
            {
                return _DateLogged;
            }
            set
            {
                _DateLogged = value;
            }
        }

        public string DateStarted
        {
            get
            {
                return _DateStarted;
            }
            set
            {
                _DateStarted = value;
            }
        }

        public string EstimatedCompletionDate
        {
            get
            {
                return _EstimatedCompletionDate;
            }
            set
            {
                _EstimatedCompletionDate = value;
            }
        }

        public string DateCompleted
        {
            get
            {
                return _DateCompleted;
            }
            set
            {
                _DateCompleted = value;
            }
        }

        public int JobOpenClose
        {
            get
            {
                return _JobOpenClose;
            }
            set
            {
                _JobOpenClose = value;
            }
        }

        public void insertJob(job currentJob)
        {
            string query = "INSERT INTO jobs(customer_id, employee_id, description, date_logged, date_started, estimated_completion, date_completed, job_open_close) VALUES ('" + currentJob.CustomerID + "', '" + currentJob.EmployeeID + "', '" + currentJob.Description + "', '" + currentJob.DateLogged + "', '" + currentJob.DateStarted + "', '" + currentJob.EstimatedCompletionDate + "', '" + currentJob.DateCompleted + "', '" + currentJob.JobOpenClose + "')";
            accessDB.DataInsert(query);
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

        public DataTable searchJob(string value, string optional, string criteriaType)
        {
            string query = "SELECT * FROM jobs";
            switch (criteriaType)
            {
                case "CustomerID":
                    dt = accessDB.grabAll(query + " WHERE customer_id = " + value);
                    break;
                case "Description":
                    dt = accessDB.grabAll(query + " WHERE description LIKE '%" + value + "%'");
                    break;
                case "both":
                    dt = accessDB.grabAll(query + " WHERE customer_id = " + value + " AND description LIKE '%" + optional + "%'");

                    break;
            }
            return dt;

        }



    }

}