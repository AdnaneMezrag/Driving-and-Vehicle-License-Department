using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class ctrlAddUpdatePerson : UserControl
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;
        public int _PersonID = -1;

        //public delegate void DataBackEventHandler(object sender);
        //public event DataBackEventHandler DataBack;

        //
        public event Action<bool , int> onSaveComplete;
        protected virtual void SaveComplete(bool save , int PersonID)
        {
            Action<bool , int> handler = onSaveComplete;
            if (handler != null)
            {
                handler(save , PersonID);
            }
        }
        //
        //
        public event Action onClose;
        protected virtual void Close()
        {
            Action handler = onClose;
            if (handler != null)
            {
                handler();
            }
        }

        public ctrlAddUpdatePerson()
        {

            InitializeComponent();

        }

        public ctrlAddUpdatePerson(enMode Mode, int personID):this()
        {
            this.Mode = Mode;
            _PersonID = personID;
        }

        private void FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetCountriesList();

            foreach (DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr["CountryName"]);
            }
        }

        private void ctrlAddUpdatePerson_Load(object sender, EventArgs e)
        {
            FillCountriesInComboBox();
            DateTime time = DateTime.Now;
            dtpDateOfBirth.MaxDate = time.AddYears(-18);
            rbMale.Checked = true;
            cbCountries.Text = "Algeria";
            pbGender.ImageLocation = "";

            if (Mode == enMode.eUpdate)
            {
                lblAddUpdate.Text = "Update Person";
                DataTable dtPerson = clsPerson.FindPersonByID(_PersonID);

                lblPersonID.Text = dtPerson.Rows[0]["PersonID"].ToString();
                tbFirstName.Text = dtPerson.Rows[0]["FirstName"].ToString();
                tbSecondName.Text += dtPerson.Rows[0]["SecondName"].ToString();
                tbThirdName.Text += dtPerson.Rows[0]["ThirdName"].ToString();
                tbLastName.Text += dtPerson.Rows[0]["LastName"].ToString();
                tbNationalNo.Text = dtPerson.Rows[0]["NationalNo"].ToString();
                if (dtPerson.Rows[0]["Gendor"].ToString() == "Male")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                tbEmail.Text = dtPerson.Rows[0]["Email"].ToString();
                txtAddress.Text = dtPerson.Rows[0]["Address"].ToString();
                dtpDateOfBirth.Text = dtPerson.Rows[0]["DateOfBirth"].ToString();
                tbPhone.Text = dtPerson.Rows[0]["Phone"].ToString();
                cbCountries.Text = dtPerson.Rows[0]["Nationality"].ToString();
                pbGender.ImageLocation = dtPerson.Rows[0]["ImagePath"].ToString();
                pbGender.Tag = pbGender.ImageLocation;

                if (pbGender.ImageLocation != "")
                {
                    lblRemove.Visible = true;

                }
                //Person.Mode = clsPerson.enMode.eUpdate;
            }
        }

        private void tbNationalNo_Leave(object sender, EventArgs e)
        {
            //Search if the nationalNo exist
            string NationalNo = null;
            if (_PersonID != -1) {
                clsPerson P = clsPerson.GetPersonByID(_PersonID);
                NationalNo = P.NationalNo.ToLower();
            }

            if (NationalNo != tbNationalNo.Text.ToLower()
                && clsPerson.DoesPersonExistByNationalNo(tbNationalNo.Text.ToString()))
            {
                erpNationalityNo.SetError(tbNationalNo, "This National No Already Exists");
            }
            else
            {
                erpNationalityNo.SetError(tbNationalNo, "");

            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbGender.Image = Resources.Male;
            lblGender.Tag = 0;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbGender.Image = Resources.Female;
            lblGender.Tag = 1;

        }

        //Check Email 
        //----------------------------------------------------------------------
        private bool CheckSpecialCharactersInUserName(char c)
        {
            if (c == '.' ||
                    c == '-' || c == '+' || c == '_')
            {
                return true;
            }
            return false;
        }

        private bool CheckEmailUserName(string UserName)
        {
            if (UserName == "")
            {
                return false;
            }
            if (!char.IsLetterOrDigit(UserName[0]) || !char.IsLetterOrDigit(UserName[UserName.Length - 1]))
            {
                return false;
            }
            UserName.Remove(0, 1);
            UserName.Remove(UserName.Length - 1, 1);
            int iNextIndex = 0;
            for (int i = 0; i < UserName.Length - 1; i++)
            {
                if (!(char.IsLetterOrDigit(UserName[i]) || (CheckSpecialCharactersInUserName(UserName[i])
                    && !CheckSpecialCharactersInUserName(UserName[i + 1]))))
                {
                    return false;
                }
            }
            if (!(char.IsLetterOrDigit(UserName[UserName.Length - 1]) ||
                CheckSpecialCharactersInUserName(UserName[UserName.Length - 1])))
            {
                return false;
            }
            return true;
        }

        private bool CheckFirstPartOfDomain(string FirstPart)
        {
            if (FirstPart == "")
            {
                return false;
            }
            if (!(char.IsLetterOrDigit(FirstPart[0]) || char.IsLetterOrDigit(FirstPart[FirstPart.Length - 1])))
            {
                return false;
            }
            FirstPart.Remove(0, 1);
            FirstPart.Remove(FirstPart.Length - 1, 1);

            for (int i = 0; i < FirstPart.Length - 1; i++)
            {
                if (!(char.IsLetterOrDigit(FirstPart[i]) || FirstPart[i] == '-'))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckLastPartOfDomain(string LastPart)
        {
            if (LastPart.Length <= 1)
            {
                return false;
            }
            for (int i = 0; i <= LastPart.Length - 1; i++)
            {
                if (!char.IsLetterOrDigit(LastPart[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckEmailDomain(string Domain)
        {
            string[] DomainParts = new string[3];
            DomainParts = Domain.Split('.');
            if (DomainParts.Length > 2)
            {
                return false;
            }
            if (!CheckFirstPartOfDomain(DomainParts[0]))
            {
                return false;
            }
            int dotIndex = Domain.IndexOf(".");
            if (dotIndex == -1)
            {
                return false;
            }
            if (!CheckLastPartOfDomain(DomainParts[1]))
            {
                return false;
            }
            return true;
        }

        private bool CheckEmail(string Email)
        {
            //Email Format : username@domain.com
            //Check UserName: 1-Extract UserName From Email
            string UserName = "";
            int atIndex = Email.IndexOf("@");
            if (atIndex == -1)
            {
                return false;
            }
            string[] EmailParts = new string[3];
            EmailParts = Email.Split('@');
            if (EmailParts.Length > 2)
            {
                return false;
            }
            UserName = EmailParts[0];
            if (!CheckEmailUserName(UserName))
            {
                return false;
            }
            string Domain = EmailParts[1];

            return CheckEmailDomain(Domain);
        }
        //----------------------------------------------------------------------

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (CheckEmail(tbEmail.Text.ToString()) || tbEmail.Text == "")
            {
                erpNationalityNo.SetError(tbEmail, "");
            }
            else
            {
                erpNationalityNo.SetError(tbEmail, "Email is Not Valid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onClose != null)
            {
                onClose();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ofdSetImage.ShowDialog();
        }

        private void ofdSetImage_FileOk(object sender, CancelEventArgs e)
        {
            ofdSetImage.Title = "Set Image";

            pbGender.ImageLocation = ofdSetImage.FileName;
            lblRemove.Visible = true;
        }

        private bool SaveImage()
        {
            if (pbGender.ImageLocation == "")
            {
                return false;
            }
            string guid = Guid.NewGuid().ToString();
            string DestinationPath = "D:\\Adnane\\Programing Advices\\Course19\\People Personal Pictures\\" + guid;
            pbGender.Tag = DestinationPath;
            if (ofdSetImage.FileName != "")
            {
                File.Copy(ofdSetImage.FileName, DestinationPath);

            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            int PersonID = -1;

            if (erpNationalityNo.GetError(tbEmail) != "" || erpNationalityNo.GetError(tbNationalNo) != "")
            {
                MessageBox.Show("Please Fix The Errors You Have Before You Can Save!");
                return;
            }
            clsPerson Person = new clsPerson();
            if (Mode == enMode.eUpdate)
            {
                Person.PersonID = int.Parse(lblPersonID.Text);
                PersonID = Person.PersonID;
                Person.Mode = clsPerson.enMode.eUpdate;
                if (pbGender.Tag.ToString() != "")
                {
                    try
                    {
                        File.Delete(pbGender.Tag.ToString());
                    }
                    catch
                    {

                    }
                }

            }
            Person.FirstName = tbFirstName.Text;
            Person.SecondName = tbSecondName.Text;
            Person.ThirdName = tbThirdName.Text;
            Person.LastName = tbLastName.Text;
            Person.NationalNo = tbNationalNo.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.Gendor = (clsPerson.enGendor)int.Parse(lblGender.Tag.ToString());
            Person.Phone = tbPhone.Text;
            Person.Email = tbEmail.Text;
            Person.NationalityCountryID = cbCountries.SelectedIndex + 1;
            Person.Address = txtAddress.Text;
            pbGender.Tag = "";
            SaveImage();
            Person.ImagePath = pbGender.Tag.ToString();
            if (Person.Save())
            {
                PersonID = Person.PersonID;
                lblPersonID.Text = Person.PersonID.ToString();
                lblAddUpdate.Text = "Update Person";
                Mode = enMode.eUpdate;
                MessageBox.Show("Person Saved Successfully");
                isSaved = true;
                //SendDataBack();
            }
            else
            {
                MessageBox.Show("Person Was Not Saved");

            }
            if (onSaveComplete != null)
            {
                onSaveComplete(isSaved, PersonID);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pbGender.ImageLocation = "";
            if (lblGender.Tag.ToString() == "0")
            {
                pbGender.Image = Resources.Male;
            }
            else
            {
                pbGender.Image = Resources.Female;

            }
            lblRemove.Visible = false;

            if (pbGender.Tag == null || pbGender.Tag.ToString() == "")
            {
                return;
            }
            //File.Delete(pbGender.Tag.ToString());
            //pbGender.Tag = "";

        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
