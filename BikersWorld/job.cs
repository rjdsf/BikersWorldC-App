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
        private DateTime _DateLogged;
        private DateTime _DateStarted;
        private DateTime _EstimatedCompletionDate;
        private DateTime _DateCompleted;
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

        public DateTime DateLogged
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

        public DateTime DateStarted
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

        public DateTime EstimatedCompletionDate
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

        public DateTime DateCompleted
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



    }

}