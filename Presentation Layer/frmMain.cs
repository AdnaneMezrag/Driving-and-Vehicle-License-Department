using Driving_and_Vehicle_License_Department_Project.Forms.Application;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types;
using Driving_and_Vehicle_License_Department_Project.Forms.Driver;
using System;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmMain : Form
    {
        object _LoginForm;
        bool isSingedOut = false;
        public enum enGendor { eMale = 0, eFemale = 1 }

        public frmMain(object LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPeople frm = new frmPeople();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();

            frm.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobalSettings.CurrentUser = null;
            ((frmLogin)_LoginForm).Visible = true;
            this.Close();           
            isSingedOut = true;
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsGlobalSettings.CurrentUser.UserID);
            frm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobalSettings.CurrentUser.UserID);
            frm.Show();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes();
            frmManageApplicationTypes.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.Show();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication = new frmLocalDrivingLicenseApplication();
            frmLocalDrivingLicenseApplication.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDrivers frmDrivers = new frmDrivers();
            frmDrivers.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.Show();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplications frm = new frmInternationalLicenseApplications();
            frm.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.Show();
        }

        private void replacementForLostOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementForLostOrDamagedLicense frm = new frmReplacementForLostOrDamagedLicense();
            frm.Show();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense();
            frmDetainLicense.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainLicenses frm = new frmManageDetainLicenses();
            frm.Show();

        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.Show();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication();
            frm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isSingedOut)
            {
                ((frmLogin)_LoginForm).Close();
            }
        }
    }
}
