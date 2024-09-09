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

namespace Driving_and_Vehicle_License_Department_Project.Controls.License
{
    public partial class ctrlLicenseInfo : UserControl
    {
        int _LicenseID;
        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        private string GetGendor(clsPerson.enGendor Gendor)
        {
            return (Gendor == clsPerson.enGendor.eMale ? "Male" : "Female");
        }

        private string GetIssueReason(clsLicense.enIssueReason IssueReason)
        {
            switch(IssueReason)
            {
                case clsLicense.enIssueReason.ReplacementForDamaged:
                    return "Replacement For Damaged";
                case clsLicense.enIssueReason.FirstTime:
                    return "First Time";
                case clsLicense.enIssueReason.Renew:
                    return "Renew";
                case clsLicense.enIssueReason.ReplacementForLost:
                    return "Replacement For Lost";
                default:
                    return "";
            }
        }

        private string ReturnYesOrNo(bool Answer)
        {
            return (Answer == true ? "Yes" : "No");
        }

        private void FillWithDefaultValues()
        {
            lblClass.Text = "???";
            lblName.Text = "???";
            lblNationalNo.Text = "???";
            lblGender.Text = "???";
            lblIssueDate.Text = "???";
            lblIssueReason.Text = "???";
            lblDateOfBirth.Text = "???";
            lblNotes.Text = "???";
            lblIsActive.Text = "???";
            lblDriverID.Text = "???";
            lblExpirationDate.Text = "???";
            lblIsDetained.Text = "???";
            pbPhoto.ImageLocation = "";
        }

        public void FillLicenseInfoLoader(int LicenseID)
        {
            _LicenseID = LicenseID;

            clsLicense License = clsLicense.GetLicenseByID(_LicenseID);

            if(License == null)
            {
                FillWithDefaultValues();
                return;
            }

            lblClass.Text = License.LicenseClass.ClassName;
            lblName.Text = License.Application.ApplicationPerson.GetFullName();
            lblLicenseID.Text = License.LicenseID.ToString();
            lblNationalNo.Text = License.Application.ApplicationPerson.NationalNo;
            lblGender.Text = GetGendor(License.Application.ApplicationPerson.Gendor);
            lblIssueDate.Text = License.IssueDate.ToString();
            lblIssueReason.Text = GetIssueReason(License.IssueReason);
            lblNotes.Text = License.Notes.ToString();
            lblIsActive.Text = ReturnYesOrNo(License.IsActive);
            lblDateOfBirth.Text = License.Application.ApplicationPerson.DateOfBirth.ToString();
            lblDriverID.Text = License.Driver.DriverID.ToString();
            lblExpirationDate.Text = License.ExpirationDate.ToString();
            lblIsDetained.Text = ReturnYesOrNo( clsDetainedLicense.IsLicenseDetained(LicenseID));
            pbPhoto.ImageLocation = License.Application.ApplicationPerson.ImagePath;
        }

    }
}
