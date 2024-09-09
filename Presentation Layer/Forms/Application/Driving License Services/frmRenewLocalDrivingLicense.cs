using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Controls.Application;
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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        int _OldLicenseID = -1;
        int _NewLicenseID = -1;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
            ctrlApplicationNewLicenseInfo1.FillApplicationInfoControl(_OldLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLicense NewLicense = clsLicense.RenewLicense(_OldLicenseID, this.ctrlApplicationNewLicenseInfo1.GetNotes());
            if (NewLicense !=  null)
            {
                _NewLicenseID = NewLicense.LicenseID;
                this.ctrlApplicationNewLicenseInfo1.FillRenewLicenseLabels(NewLicense.Application.ApplicationID
                    , NewLicense.LicenseID);
                this.ctrlLicenseSearch1.DisableLicenseFilterControl();
                MessageBox.Show("License Was Renewed Successfully With ID = " +
                    _NewLicenseID, "Renew License", MessageBoxButtons.OK
, MessageBoxIcon.Information);
                lblShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;

            }
            else
            {
                MessageBox.Show("License Was Not Renewed", "Renew License", MessageBoxButtons.OK
        , MessageBoxIcon.Error);
            }
        }

        private void ctrlLicenseSearch1_onLicenseID(int obj)
        {
            lblShowLicenseInfo.Enabled = false;
            _OldLicenseID = obj;
            ctrlApplicationNewLicenseInfo1.FillApplicationInfoControl(_OldLicenseID);
            btnRenew.Enabled = false;
            if (_OldLicenseID == -1)
            {
                return;
            }
            clsLicense.enRenewLicense RenewLicense = clsLicense.CanLicenseBeRenewed(_OldLicenseID);
            if(RenewLicense == clsLicense.enRenewLicense.eNotExpiredYet)
            {
                MessageBox.Show("License Is Not Yet Expired , It Will Expire On " +
                    clsLicense.GetLicenseByID(_OldLicenseID).ExpirationDate.ToShortDateString(), "Renew License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
                return;
            }
            if(RenewLicense == clsLicense.enRenewLicense.eNotActive)
            {
                MessageBox.Show("License Is Not Active", "Renew License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
                return;
            }
            btnRenew.Enabled = true;
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.Show();
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if (_OldLicenseID != -1)
            {
                PersonID = clsLicense.GetLicenseByID(_OldLicenseID).Application.ApplicationPerson.PersonID;
            }
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

    }
}
