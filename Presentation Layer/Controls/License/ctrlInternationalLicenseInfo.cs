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
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        int _InternationalLicenseID = -1;

        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void ctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
        private string GetGendor(clsPerson.enGendor Gendor)
        {
            return (Gendor == clsPerson.enGendor.eMale ? "Male" : "Female");
        }

        private string ReturnYesOrNo(bool Answer)
        {
            return (Answer == true ? "Yes" : "No");
        }

        private void FillWithDefaultValues()
        {
            lblName.Text = "???";
            lblIntLicenseID.Text = "???";
            lblNationalNo.Text = "???";
            lblGender.Text = "???";
            lblIssueDate.Text = "???";
            lblApplicationID.Text = "???";
            lblIsActive.Text = "???";
            lblDateOfBirth.Text = "???";
            lblDriverID.Text = "???";
            lblExpirationDate.Text = "???";
            pbPhoto.ImageLocation = "";
        }

        public void FillLicenseInfoLoader(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;

            clsInternationalLicense InternationalLicense
                = clsInternationalLicense.GetInternationalLicenseByID(_InternationalLicenseID);

            if (InternationalLicense == null)
            {
                FillWithDefaultValues();
                return;
            }

            lblName.Text = InternationalLicense.Application.ApplicationPerson.GetFullName();
            lblIntLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = InternationalLicense.IssuedUsingLocalLicense.LicenseID.ToString();
            lblNationalNo.Text = InternationalLicense.Application.ApplicationPerson.NationalNo;
            lblGender.Text = GetGendor(InternationalLicense.Application.ApplicationPerson.Gendor);
            lblIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
            lblApplicationID.Text = InternationalLicense.Application.ApplicationID.ToString();
            lblIsActive.Text = ReturnYesOrNo(InternationalLicense.IsActive);
            lblDateOfBirth.Text = InternationalLicense.Application.ApplicationPerson.DateOfBirth.ToShortDateString();
            lblDriverID.Text = InternationalLicense.Driver.DriverID.ToString();
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
            pbPhoto.ImageLocation = InternationalLicense.Application.ApplicationPerson.ImagePath;
        }

    }
}
