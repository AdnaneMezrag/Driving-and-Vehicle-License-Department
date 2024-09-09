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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicenseID = -1;

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            
        }

        public void FillLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;
            ctrlLicenseSearch1.FillLicenseID(LicenseID);
            ctrlLicenseSearch1.DisableLicenseFilterControl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(5).ApplicationFees.ToString();

        }

        private void FillWithDefaultValues()
        {
            lblDetainID.Text = "???";
            lblDetainDate.Text = "???";
            lblTotalFees.Text = "???";
            lblLicenseID.Text = "???";
            lblCreatedBy.Text = "???";
            lblFineFees.Text = "???";
            lblRApplicationID.Text = "???";
        }

        private void ctrlLicenseSearch1_onLicenseID(int obj)
        {
            lblShowLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;
            
            _LicenseID = obj;
            if (_LicenseID == -1)
            {
                FillWithDefaultValues();
                return;
            }
            
            if (!clsDetainedLicense.CanLicenseBeReleased(_LicenseID))
            {
                MessageBox.Show("License Is Not Detained"
, "Release License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
            }

            clsDetainedLicense detainedLicense = clsDetainedLicense.GetDetainedLicenseByLicenseID(_LicenseID);
            if (detainedLicense == null) {
                FillWithDefaultValues();
                return;
            }
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(5).ApplicationFees.ToString();
            lblDetainID.Text = detainedLicense.DetainID.ToString();
            lblCreatedBy.Text = detainedLicense.CreatedByUser.UserName;
            lblLicenseID.Text = _LicenseID.ToString();
            lblFineFees.Text = detainedLicense.FineFees.ToString();
            lblTotalFees.Text = (decimal.Parse(lblApplicationFees.Text) + decimal.Parse(lblFineFees.Text)).ToString();
            lblDetainDate.Text = detainedLicense.DetainDate.ToShortDateString();



            btnRenew.Enabled = true;

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int applicationID = clsDetainedLicense.Release(_LicenseID);
            if (applicationID != -1)
            {
                lblShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;
                lblRApplicationID.Text = applicationID.ToString();
                this.ctrlLicenseSearch1.DisableLicenseFilterControl();
                MessageBox.Show("License Was Released Successfully"
, "Release License", MessageBoxButtons.OK
, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("License Was Not Released"
, "Release License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
            }
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_LicenseID);
            frm.Show();
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if (_LicenseID != -1)
            {
                PersonID = clsLicense.GetLicenseByID(_LicenseID).Application.ApplicationPerson.PersonID;
            }
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

        private void frmReleaseDetainedLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke();

        }
    }
}
