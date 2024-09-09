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
    public partial class ctrlApplicationInfo : UserControl
    {
        int _LicenseID = -1;

        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public void FillApplicationInfoControl(int LicenseID)
        {
            if(LicenseID != -1)
            {
                _LicenseID = LicenseID;
                lblLocalLicenseID.Text = LicenseID.ToString();
                return;
            }
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            DateTime IssueDate = DateTime.Now;
            lblIssueDate.Text = IssueDate.ToShortDateString();
            lblFees.Text = clsApplicationType.GetApplicationTypeByID(6).ApplicationFees.ToString();
            lblExpirationDate.Text = IssueDate.AddYears(1).ToShortDateString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName;
        }

        public void FillInternationalLicenseLabels(int ApplicationID , int InternationalLicenseID)
        {
            lblApplicationID.Text = ApplicationID.ToString();
            lblILLicenseID.Text = InternationalLicenseID.ToString();
        }

    }
}
