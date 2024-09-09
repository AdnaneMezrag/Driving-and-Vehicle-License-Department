using Business_Layer;
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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        int _LicenseID = -1;
        int _InternationalLicenseID = -1;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            this.ctrlApplicationInfo1.FillApplicationInfoControl(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsInternationalLicense internationalLicense = clsInternationalLicense.IssueInternationaLicense(_LicenseID);
            if (internationalLicense != null)
            {
                this.ctrlApplicationInfo1.FillInternationalLicenseLabels(internationalLicense.Application
                    .ApplicationID,internationalLicense.InternationalLicenseID);
                this.ctrlLicenseSearch1.DisableLicenseFilterControl();
                _InternationalLicenseID = internationalLicense.InternationalLicenseID;
                MessageBox.Show("International License Saved Successfully");
                lblShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
            }
            else
            {
                MessageBox.Show("International License Was Not Saved");

            }
        }

        private void ctrlLicenseSearch1_onLicenseID(int obj)
        {
            lblShowLicenseInfo.Enabled = false;
            _LicenseID = obj;
            ctrlApplicationInfo1.FillApplicationInfoControl(_LicenseID);
            btnIssue.Enabled = false;
            if (_LicenseID == -1) {
                return;
            }

            clsInternationalLicense.enIssueInternationalLicense InternationalLicenseIssue =
                clsInternationalLicense.CanInternationalLicenseBeIssued(_LicenseID);

            if(InternationalLicenseIssue == clsInternationalLicense.enIssueInternationalLicense
                .eActiveInternationalLicense)
            {
                MessageBox.Show("Person Already Have An Active International License With ID = "
                    + clsInternationalLicense.GetLastInternationalLicenseByLicenseID(
                        _LicenseID).InternationalLicenseID , "Issue International License",MessageBoxButtons.OK
                        ,MessageBoxIcon.Error);
                _InternationalLicenseID = clsInternationalLicense.GetLastInternationalLicenseByLicenseID
                    (_LicenseID).InternationalLicenseID;

                lblShowLicenseInfo.Enabled = true;
                return;
            }
            if (InternationalLicenseIssue == clsInternationalLicense.enIssueInternationalLicense
    .eNotClass3)
            {
                MessageBox.Show("License Class Type Must Be: Class 3 - Ordinary driving license"
                    , "Issue International License", MessageBoxButtons.OK
                        , MessageBoxIcon.Error) ;
                return;

            }
            if (InternationalLicenseIssue == clsInternationalLicense.enIssueInternationalLicense
.eClass3Expired)
            {
                MessageBox.Show("License Has Expired , You have To Renew It So You Can Have An International" +
                    "License"
                    , "Issue International License", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                return;

            }
            if (InternationalLicenseIssue == clsInternationalLicense.enIssueInternationalLicense
.eClass3NotActive)
            {
                MessageBox.Show("License Is Disactivated"             
                    , "Issue International License", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                return;

            }
            btnIssue.Enabled = true;

        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frmInternationalLicenseInfo = new frmInternationalLicenseInfo(_InternationalLicenseID);
            frmInternationalLicenseInfo.Show();
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if(_LicenseID != -1)
            {
                PersonID = clsLicense.GetLicenseByID(_LicenseID).Driver.Person.PersonID;
            }
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(PersonID) ;
            frmLicenseHistory.Show();
        }
    }
}
