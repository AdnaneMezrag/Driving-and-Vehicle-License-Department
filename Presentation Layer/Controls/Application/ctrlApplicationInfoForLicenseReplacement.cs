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
    public partial class ctrlApplicationInfoForLicenseReplacement : UserControl
    {
        int _OldLicenseID = -1;
        public enum enReplacementFor { eDamaged = 0 , eLost = 1}

        enReplacementFor ReplacementFor = enReplacementFor.eDamaged;

        public ctrlApplicationInfoForLicenseReplacement()
        {
            InitializeComponent();

        }

        public void FillApplicationInfoControl(int OldLicenseID , enReplacementFor replacementFor)
        {
            if (OldLicenseID != -1)
            {
                _OldLicenseID = OldLicenseID;
                lblOldLicenseID.Text = OldLicenseID.ToString();
            }
            ReplacementFor = replacementFor;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();

            if(ReplacementFor == enReplacementFor.eDamaged)
            {
                lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(4).ApplicationFees.ToString();
            }
            else if(ReplacementFor == enReplacementFor.eLost)
            {
                lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(3).ApplicationFees.ToString();
            }

            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName;

        }

        public void FillRenewLicenseLabels(int ApplicationID, int ReplaceLicenseID)
        {
            lblApplicationID.Text = ApplicationID.ToString();
            lblReplacedLicenseID.Text = ReplaceLicenseID.ToString();
        }

    }
}
