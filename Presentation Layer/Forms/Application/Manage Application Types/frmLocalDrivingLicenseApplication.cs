using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Controls.Application;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types;
using Driving_and_Vehicle_License_Department_Project.Forms.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application
{
    public partial class frmLocalDrivingLicenseApplication : Form
    {

        DataView dvLDLApplication = new DataView();
        ctrlScheduleTest.enTestType TestType;

        public frmLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.frmLocalDrivingLicenseApplication = this;
            frm.Show();
        }

        private static string ShowApplicationStatus(int status)
        {
            return (status == 1 ? "New" : status == 2 ? "Completed" : status == 3 ? "Canceled" : "");
        }

        private void FillDataView()
        {
            DataView dv = clsLocalDrivingLicenseApplication.
    GetLocalDrivingLicenseApplicationsList().DefaultView;

            DataTable dtLDLApplications = new DataTable();
            dtLDLApplications.Columns.Add("L.D.L.AppID");
            dtLDLApplications.Columns.Add("Driving Class");
            dtLDLApplications.Columns.Add("National No");
            dtLDLApplications.Columns.Add("Full Name");
            dtLDLApplications.Columns.Add("Application Date");
            dtLDLApplications.Columns.Add("Passed Tests");
            dtLDLApplications.Columns.Add("Status");


            foreach (DataRowView row in dv)
            {

                clsApplication application = clsApplication.GetApplicationByID(int.Parse(row[1].ToString()));
                int PassedTests = clsLocalDrivingLicenseApplication.GetPassedTestsNumber(int.Parse(row[0].ToString()));
                clsPerson Person = application.ApplicationPerson;
                dtLDLApplications.Rows.Add(row[0].ToString(),
                    clsLicenseClass.GetLicenseClassByID(int.Parse(row[2].ToString())).ClassName,
                    Person.NationalNo,
                    Person.GetFullName(),
                    application.ApplicationDate,
                    PassedTests,
                    ShowApplicationStatus(application.ApplicationStatus)

                    );

            }
            dvLDLApplication = dtLDLApplications.DefaultView;
        }

        private void ShowLDLApplication()
        {

            FillDataView();
            dgvLDLApplications.DataSource = dvLDLApplication;

        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ShowLDLApplication();
            cbFilterApplications.SelectedIndex = 0;
            lblRecords.Text = dgvLDLApplications.Rows.Count.ToString();
            cbStatus.SelectedIndex = 0;
        }

        private void tbFilterUsers_KeyUp(object sender, KeyEventArgs e)
        {

            if (tbFilterApplications.Text == "")
            {
                dvLDLApplication.RowFilter = "";
                dgvLDLApplications.DataSource = dvLDLApplication;
                return;
            }

            switch (cbFilterApplications.SelectedItem.ToString())
            {

                case "L.D.L.AppID":
                    dvLDLApplication.RowFilter = $"[L.D.L.AppID] = {tbFilterApplications.Text}";
                    dgvLDLApplications.DataSource = dvLDLApplication;

                    break;
                case "National No":
                    dvLDLApplication.RowFilter = $"[National No] = '{tbFilterApplications.Text}'";
                    dgvLDLApplications.DataSource = dvLDLApplication;

                    break;
                case "Full Name":
                    dvLDLApplication.RowFilter = $"[Full Name] = '{tbFilterApplications.Text}'";
                    dgvLDLApplications.DataSource = dvLDLApplication;
                    break;

            }
        }

        public void RefrechApplicationsList()
        {
            FillDataView();
            dgvLDLApplications.DataSource = dvLDLApplication;
            lblRecords.Text = dgvLDLApplications.Rows.Count.ToString();
        }

        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvLDLApplication.RowFilter = "";
            if (cbFilterApplications.SelectedIndex == cbFilterApplications.FindStringExact("None"))
            {
                cbStatus.Visible = false;
                tbFilterApplications.Visible = false;
                return;
            }
            if (cbFilterApplications.SelectedIndex == cbFilterApplications.FindStringExact("Status"))
            {
                cbStatus.Visible = true;
                tbFilterApplications.Visible = false;
                return;
            }

            cbStatus.Visible = false;
            tbFilterApplications.Visible = true;
            tbFilterApplications.Text = "";
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStatus.SelectedItem.ToString())
            {
                case "All":
                    dvLDLApplication.RowFilter = "";
                    dgvLDLApplications.DataSource = dvLDLApplication;
                    break;
                case "New":
                    dvLDLApplication.RowFilter = $"Status = 'New'";
                    dgvLDLApplications.DataSource = dvLDLApplication;
                    break;
                case "Completed":
                    dvLDLApplication.RowFilter = $"Status = 'Completed'";
                    dgvLDLApplications.DataSource = dvLDLApplication;
                    break;
                case "Canceled":
                    dvLDLApplication.RowFilter = $"Status = 'Canceled'";
                    dgvLDLApplications.DataSource = dvLDLApplication;
                    break;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = -1;
            LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            if(MessageBox.Show("Are You Sure You Want To Cancel This Application?", "Cancel Application"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                clsApplication app = clsLocalDrivingLicenseApplication.
                    GetLocalDrivingLicenseApplicationByID(LDLAppID).Application;

                if (app.CancelApplication()) 
                {
                    
                    MessageBox.Show("Application Canceled Successfully","Application Canceled",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    RefrechApplicationsList();
                }
                else
                {
                    MessageBox.Show("Application Was Not Canceled", "Application Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Application Was Not Canceled", "Application Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = -1;
            LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            
            frmTestAppointment frm = new frmTestAppointment(LDLAppID,ctrlScheduleTest.enTestType.eVisionTest);
            frm.DataBack += RefrechApplicationsList;
            frm.Show();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = -1;
            LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmTestAppointment frm = new frmTestAppointment(LDLAppID, ctrlScheduleTest.enTestType.eWrittenTest);
            frm.DataBack += RefrechApplicationsList;

            frm.Show();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = -1;
            LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmTestAppointment frm = new frmTestAppointment(LDLAppID, ctrlScheduleTest.enTestType.eStreetTest);
            frm.DataBack += RefrechApplicationsList;

            frm.Show();
        }

        private void cmsUser_Opening(object sender, CancelEventArgs e)
        {
            int LDLAppID = -1;
            LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            int PassedTests = clsLocalDrivingLicenseApplication.GetPassedTestsNumber(LDLAppID);
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.
                GetLocalDrivingLicenseApplicationByID(LDLAppID);
            int ApplicationStatus = LDLApp.Application.ApplicationStatus;


            ScheduleTestToolStripMenuItem.Enabled = true;
            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            IssueDrivingLicenseToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = true;
            CancelToolStripMenuItem.Enabled = true;



            if (ApplicationStatus == 2)//2 means Complete
            {
                showLicenseToolStripMenuItem.Enabled = true; 
                AddNewApplicationToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                CancelToolStripMenuItem.Enabled = false;
                ScheduleTestToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                IssueDrivingLicenseToolStripMenuItem.Enabled= false;
                return;
            }
            else if (ApplicationStatus == 3)//3 means Cancel
            {
                editToolStripMenuItem.Enabled = false;
                ScheduleTestToolStripMenuItem.Enabled = false;
                IssueDrivingLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                return;
            }

            if (PassedTests == 0)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = true;
            }
            else if (PassedTests == 1)
            {
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
            }
            else if (PassedTests == 2)
            {
                scheduleStreetTestToolStripMenuItem.Enabled = true;
            }
            else
            {
                ScheduleTestToolStripMenuItem.Enabled = false;
                IssueDrivingLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Are You Sure You Want To Delete This Application?", "Delete Application", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.DeleteLDLAppByID(LDLAppID))
                {

                    MessageBox.Show("Deleted Successfully");
                    RefrechApplicationsList();
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(LDLAppID);
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmLDLAppInformation frmLDLAppInformation = new frmLDLAppInformation(LDLAppID);
            frmLDLAppInformation.Show();
        }

        private void IssueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            
            frmIssueDrivingLicense frm = new frmIssueDrivingLicense(LDLAppID);
            frm.DataBack += RefrechApplicationsList;
            frm.Show();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            int LicenseID = clsLocalDrivingLicenseApplication.GetLicenseIDByLDLAppID(LDLAppID);

            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApplications.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            int PersonID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(LDLAppID).Application.ApplicationPerson.PersonID;

            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

    } 
}

