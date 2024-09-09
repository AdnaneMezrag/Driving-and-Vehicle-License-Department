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
    public partial class ctrlApplicationNewLicenseInfo : UserControl
    {
        int _OldLicenseID = -1;
        public ctrlApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillApplicationInfoControl(int OldLicenseID)
        {
            DateTime IssueDate = DateTime.Now;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = IssueDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(2).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName;

            if (OldLicenseID != -1)
            {
                _OldLicenseID = OldLicenseID;
                lblOldLicenseID.Text = OldLicenseID.ToString();
                clsLicense OldLicense = clsLicense.GetLicenseByID(OldLicenseID);
                lblLicenseFees.Text = OldLicense.LicenseClass.ClassFees.ToString();
                lblExpirationDate.Text = IssueDate.AddYears(OldLicense.LicenseClass.DefaultValidityLength).ToShortDateString(); 
                lblTotalFees.Text = (decimal.Parse(lblApplicationFees.Text) + decimal.Parse(lblLicenseFees.Text)).ToString();
                return;
            }

        }

        public void FillRenewLicenseLabels(int ApplicationID, int RenewLicenseID)
        {
            lblApplicationID.Text = ApplicationID.ToString();
            lbIRLLicenseID.Text = RenewLicenseID.ToString();
        }

        public string GetNotes()
        {
            return rtbNotes.Text;
        }

    }
}
