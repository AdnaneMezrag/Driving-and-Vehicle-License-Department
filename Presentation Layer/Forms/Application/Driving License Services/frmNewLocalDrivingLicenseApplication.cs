using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode = enMode.eAddNew;
        public frmLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication;
        int _PersonID = -1;
        int _LDLAppID = 1;

        public frmNewLocalDrivingLicenseApplication(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            if(_LDLAppID != -1)
            {
                Mode = enMode.eUpdate;
            }
            InitializeComponent();
        }

        private void FillLicenseClassesInComboBox()
        {
            DataTable dt = clsLicenseClass.GetLicenseClass();

            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClass.Items.Add(dr["ClassName"]);
            }
            cbLicenseClass.SelectedIndex = 2;
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.eUpdate){

                this.ctrlPersonSearch1.DisablePersonFilter();
                clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(_LDLAppID);
                this.ctrlPersonSearch1.FillPersonDetails(LDLApp.Application.ApplicationPerson.PersonID);
                lblApplicationID.Text = _LDLAppID.ToString();
                lblApplicationDate.Text = LDLApp.Application.ApplicationDate.ToString();
                cbLicenseClass.SelectedIndex = LDLApp.LicenseClass.LicenseClassID - 1;
                lblApplicationFees.Text = LDLApp.Application.PaidFees.ToString();
                lblCreatedBy.Text = LDLApp.Application.CreatedByUser.UserName.ToString();
            }
        }

        private void ctrlPersonSearch1_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString().ToString();
            FillLicenseClassesInComboBox();
            clsApplicationType ApplicationType = clsApplicationType.GetApplicationTypeByID(1);
            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonSearch1_onPersonID(int obj)
        {
            _PersonID = obj;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsApplication Application = new clsApplication();
            if (Mode == enMode.eUpdate)
            {
                Application.ApplicationID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(_LDLAppID).Application.ApplicationID;
                Application.Mode = clsApplication.enMode.eUpdate;
            }
            clsPerson Person = new clsPerson();
            Person.PersonID = _PersonID;
            clsApplicationType applicationType = new clsApplicationType();
            applicationType.ApplicationTypeID = 1;


            Application.ApplicationPerson = Person;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationType = applicationType;
            Application.ApplicationStatus = 1;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = decimal.Parse(lblApplicationFees.Text);
            Application.CreatedByUser = clsGlobalSettings.CurrentUser;

            clsLicenseClass licenseClass = clsLicenseClass.GetLicenseClassByID(cbLicenseClass.SelectedIndex+1);

            if (clsPerson.GetPersonByID(_PersonID).GetAge() < licenseClass.MinimumAllowedAge)
            {
                MessageBox.Show("Minimum Allowed Age Is: " + licenseClass.MinimumAllowedAge, "Add Application",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


                clsLocalDrivingLicenseApplication localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            localDrivingLicenseApplication.Application = Application;
            localDrivingLicenseApplication.LicenseClass = licenseClass;

            if (!localDrivingLicenseApplication.CanApplicationBeAdded())
            {
                MessageBox.Show("You Can't Add This Application . . . \n" +
                    "Because This Person Already have either a completed or a new application for " +
                    "this license class","Add Application",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (Application.Save() && localDrivingLicenseApplication.Save())
            {
                lblApplicationID.Text = localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                lblAddUpdate.Text = "Update Application";
                Mode = enMode.eUpdate;
                MessageBox.Show("Application Saved Successfully", "Add Application", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //SendDataBack();
                //DataBack?.Invoke(this._ApplicationID);
            }
            else
            {
                MessageBox.Show("Application Was Not Saved", "Add Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmNewLocalDrivingLicenseApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmLocalDrivingLicenseApplication != null)
            {
                frmLocalDrivingLicenseApplication.RefrechApplicationsList();
            }
        }
    }
}
