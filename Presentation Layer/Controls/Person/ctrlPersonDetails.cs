using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class ctrlPersonDetails : UserControl
    {

        public int _PersonID = -1;

        public ctrlPersonDetails()
        {
            InitializeComponent();
        }

        public ctrlPersonDetails(int PersonID):this()
        {
            _PersonID = PersonID;
        }

        private void ctrlPersonDetails_Load(object sender, System.EventArgs e)
        {
            FillPersonDetails(_PersonID);
        }

        private void lblSetImage_Click(object sender, System.EventArgs e)
        {
            if(!int.TryParse(lblPersonID.Text , out int PersonID))
            {
                return;
            }

            frmAddUpdatePerson frm = new frmAddUpdatePerson(ctrlAddUpdatePerson.enMode.eUpdate, PersonID);
            frm.DataBack += FillPersonDetails;
            //Send PersonID To frmPersonDetails

            frm.Show();
        }

        private void FillWithDefaultValues()
        {
            lblPersonID.Text = "???";
            lblName.Text = "???";
            lblNationalNo.Text = "???";
            lblGender.Text = "???";
            lblEmail.Text = "???";
            lblAddress.Text = "???";
            lblDateOfBirth.Text = "???";
            lblPhone.Text = "???";
            lblCountry.Text = "???";
            pbPhoto.ImageLocation = "";
        }

        public void FillPersonDetails(int PersonID)
        {
            clsPerson Person = clsPerson.GetPersonByID(PersonID);
            if (Person != null)
            {
                _PersonID = PersonID;
                lblPersonID.Text = Person.PersonID.ToString() + " ";
                lblName.Text = Person.FirstName.ToString() + " ";
                lblName.Text += Person.SecondName.ToString() + " ";
                lblName.Text += Person.ThirdName.ToString() + " ";
                lblName.Text += Person.LastName.ToString();
                lblNationalNo.Text = Person.NationalNo.ToString();
                lblGender.Text = (Person.Gendor == clsPerson.enGendor.eMale) ? "Male" : "Female";
                lblEmail.Text = Person.Email.ToString();
                lblAddress.Text = Person.Address.ToString();
                lblDateOfBirth.Text = Person.DateOfBirth.ToString();
                lblPhone.Text = Person.Phone.ToString();
                lblCountry.Text = (clsCountry.GetCountryByID(Person.NationalityCountryID)).CountryName;
                pbPhoto.ImageLocation = Person.ImagePath.ToString();
            }
            else
            {
                FillWithDefaultValues();
            }
            if (lblGender.Text == "Female")
            {
                pbPhoto.Image = Resources.Female;
            }
            else
            {
                pbPhoto.Image = Resources.Male;

            }
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
