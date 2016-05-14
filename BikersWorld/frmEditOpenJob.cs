using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;
using System.Diagnostics;

namespace BikersWorld
{
    public partial class frmEditOpenJob : Form
    {
        job jobs = new job();
        dbEW accessDB = new dbEW();
        DataTable dt = new DataTable();
        job thisJob = new job();

        public frmEditOpenJob()
        {
            InitializeComponent();
        }

        private void frmEditOpenJob_Load(object sender, EventArgs e)
        {
            //code in this region used to populate the dataGridView with all current jobs
            getOpenJobs();
        }

        private void getOpenJobs()
        {
            dt = jobs.getOpenJobs();
            dgvEditOpenJob.DataSource = dt;
        }

        //used to hide unwanted columns within the datagride that are still required for instantiation
        public void hideUnwantedColumns()
        {
            for (int i = 0; i < dgvEditOpenJob.ColumnCount; i++)
            {
                switch (i)
                {
                    case 0:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 3:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 6:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 8:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 9:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 10:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 11:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 13:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 14:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;
                    case 15:
                        this.dgvEditOpenJob.Columns[i].Visible = false;
                        break;

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) && string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter some criteria in order to search upon!", "No Seatch Criteria", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtCustomerID.Focus();
            }
            else if (txtCustomerID.Text.Length > 0 && string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                dt = jobs.searchJob(txtCustomerID.Text, null, "CustomerID");
                dgvEditOpenJob.DataSource = dt;
            }
            else if (string.IsNullOrWhiteSpace(txtCustomerID.Text) && txtDescription.Text.Length > 0)
            {
                dt = jobs.searchJob(txtDescription.Text, null, "Description");
                dgvEditOpenJob.DataSource = dt;
            }
            else if (txtCustomerID.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                dt = jobs.searchJob(txtCustomerID.Text, txtDescription.Text, "both");
                dgvEditOpenJob.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtDescription.Clear();
            dgvEditOpenJob.ClearSelection();
            getOpenJobs();
        }

        private void dgvProductInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpEditJob_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditClear_Click(object sender, EventArgs e)
        {
            txtDesc.Clear();
            txtDateLogged.Clear();
            txtDateStarted.Clear();
            txtEstimatedCompletionDate.Clear();
            txtCompletionDate.Clear();
            combJobOpenClosed.Text = ("");
        }
       
        private void dgvEditOpenJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            thisJob.JobID = Convert.ToInt16(dgvEditOpenJob.CurrentRow.Cells[0].Value);
            thisJob.Description = (dgvEditOpenJob.CurrentRow.Cells[3].Value.ToString());
            thisJob.DateLogged = (dgvEditOpenJob.CurrentRow.Cells[4].Value.ToString());
            thisJob.DateStarted = (dgvEditOpenJob.CurrentRow.Cells[5].Value.ToString());
            thisJob.EstimatedCompletionDate = (dgvEditOpenJob.CurrentRow.Cells[6].Value.ToString());
            thisJob.DateCompleted = (dgvEditOpenJob.CurrentRow.Cells[7].Value.ToString());
            thisJob.JobOpenClose = Convert.ToInt16(dgvEditOpenJob.CurrentRow.Cells[8].Value);

            txtDesc.Text = thisJob.Description;
            txtDateLogged.Text = thisJob.DateLogged;
            txtDateStarted.Text = thisJob.DateStarted;
            txtEstimatedCompletionDate.Text = thisJob.EstimatedCompletionDate;
            txtCompletionDate.Text = thisJob.DateCompleted;

            grpEditJob.Text = "job N:" + thisJob.JobID;

            switch ( thisJob.JobOpenClose){
            
             case 2:

                    combJobOpenClosed.Text = "Closed";
                    break;

                case 1:
                    combJobOpenClosed.Text = "Open";
                    break;
            
            }

               

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int state = 1; 
            switch (combJobOpenClosed.Text)
            {

                case "Closed":

                    state = 2;
                    break;

                case "Open":
                    state = 1;
                    break;

            }
            string query = "update `jobs` SET `description` ='" + txtDesc.Text + "', `date_logged` ='" + txtDateLogged.Text + "'," +
                "`date_started` = '" + txtDateStarted.Text + "', `estimated_completion` = '" + txtEstimatedCompletionDate.Text + "'," +
                "`date_completed` = '" + txtCompletionDate.Text + "', `job_open_close` = " + state + " WHERE job_id='" + thisJob.JobID + "';";
            accessDB.UpdateDatabase(query);

            getOpenJobs();
        }

        private void txtDateLogged_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void txtEstimatedCompletionDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        }
    }