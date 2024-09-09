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
    public partial class frmReplacementForLostOrDamagedLicense : Form
    {
        int _OldLicenseID = -1;
        int _NewLicenseID = -1;
        public enum enReplacementFor { eDamaged = 0, eLost = 1 }

        enReplacementFor ReplacementFor = enReplacementFor.eDamaged;
        public frmReplacementForLostOrDamagedLicense()
        {
            InitializeComponent();
            if(rbLostLicense.Checked )
            {
                ReplacementFor = enReplacementFor.eLost;
            }
            ctrlApplicationInfoForLicenseReplacement1.FillApplicationInfoControl(_OldLicenseID,
                (ctrlApplicationInfoForLicenseReplacement.enReplacementFor)ReplacementFor);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLicenseSearch1_onLicenseID(int obj)
        {
            lblShowLicenseInfo.Enabled = false;
            _OldLicenseID = obj;
            ctrlApplicationInfoForLicenseReplacement1.FillApplicationInfoControl(_OldLicenseID,(ctrlApplicationInfoForLicenseReplacement.enReplacementFor)ReplacementFor);
            btnRenew.Enabled = false;
            if (_OldLicenseID == -1)
            {
                return;
            }
            if (!clsLicense.IsLicenseActive(_OldLicenseID))
            {
                MessageBox.Show("License Is Not Active", "License Replacement", MessageBoxButtons.OK
, MessageBoxIcon.Error);
                return;
            }
            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLicense NewLicense = clsLicense.ReplaceLicense(_OldLicenseID,(clsLicense.enReplacementFor)ReplacementFor);
            if (NewLicense != null)
            {
                _NewLicenseID = NewLicense.LicenseID;
                this.ctrlApplicationInfoForLicenseReplacement1.FillRenewLicenseLabels(NewLicense.Application.ApplicationID
                    , NewLicense.LicenseID);
                this.ctrlLicenseSearch1.DisableLicenseFilterControl();
                MessageBox.Show("License Was Replaced Successfully With ID = " +
                    _NewLicenseID, "License Replacement", MessageBoxButtons.OK
, MessageBoxIcon.Information);
                lblShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;
                gbReplacementFor.Enabled = false;
            }
            else
            {
                MessageBox.Show("License Was Not Replaced", "License Replacement", MessageBoxButtons.OK
        , MessageBoxIcon.Error);
            }
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

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            ReplacementFor = enReplacementFor.eDamaged;
            lblReplacementFor.Text = "Replacement For Damaged License";
            ctrlApplicationInfoForLicenseReplacement1.FillApplicationInfoControl(_OldLicenseID, 
                (ctrlApplicationInfoForLicenseReplacement.enReplacementFor)ReplacementFor);
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            ReplacementFor = enReplacementFor.eLost;
            lblReplacementFor.Text = "Replacement For Lost License";
            ctrlApplicationInfoForLicenseReplacement1.FillApplicationInfoControl(_OldLicenseID,
    (ctrlApplicationInfoForLicenseReplacement.enReplacementFor)ReplacementFor);
        }

    }
}
