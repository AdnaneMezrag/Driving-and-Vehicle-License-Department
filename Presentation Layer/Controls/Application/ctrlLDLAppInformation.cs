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

namespace Driving_and_Vehicle_License_Department_Project.Controls.Application
{
    public partial class ctrlLDLAppInformation : UserControl
    {
        public int LDLAppID = -1;
        public ctrlLDLAppInformation()
        {
            InitializeComponent();
        }

        public ctrlLDLAppInformation(int lDLAppID) : this()
        {
            LDLAppID = lDLAppID;
        }

        private static string GetStatus(int Status)
        {
            return (Status == 1 ? "New" : (Status == 2 ? "Completed" : "Canceled"));
        }

        public void FillLoader()
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(LDLAppID);
            int PassedTests = clsLocalDrivingLicenseApplication.GetPassedTestsNumber(LDLAppID);

            lblLDLAppID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = LDLApp.LicenseClass.ClassName;
            lblPassedTests.Text = PassedTests.ToString() + "/3";

            lblApplicationID.Text = LDLApp.Application.ApplicationID.ToString();
            lblStatus.Text = GetStatus(LDLApp.Application.ApplicationStatus);
            lblFees.Text = LDLApp.Application.ApplicationType.ApplicationFees.ToString();
            lblType.Text = LDLApp.Application.ApplicationType.ApplicationTypeTitle.ToString();
            lblApplicant.Text = LDLApp.Application.ApplicationPerson.GetFullName();
            lblDate.Text = LDLApp.Application.ApplicationDate.ToString();
            lblStatusDate.Text = LDLApp.Application.LastStatusDate.ToString();
            lblCreatedBy.Text = LDLApp.Application.CreatedByUser.UserName.ToString();
        }

        private void ctrlLDLAppInformation_Load(object sender, EventArgs e)
        {
            FillLoader();
        }

        private void lblSetImage_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(LDLAppID).Application.ApplicationPerson.PersonID);
            frm.Show();
        }
    }
}
