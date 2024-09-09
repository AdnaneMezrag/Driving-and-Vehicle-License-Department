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

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;
        int _PersonID = -1;
        int _UserID = -1;

        public delegate void DataBackEventHandler(int UserID);
        public event DataBackEventHandler DataBack;

        public frmAddUpdateUser(enMode Mode , int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
            this.Mode = Mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.eUpdate )
            {
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (clsUser.DoesUserExistByPersonID(_PersonID))
            {
                MessageBox.Show("Selected Person Already Has A User , Choose Another One.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tabControl1.SelectedIndex = 1;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                erpAddNewUser.SetError(tbUserName, "UserName Cannot Be Blank");
            }
            else
            {
                erpAddNewUser.SetError(tbUserName, "");

            }
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                erpAddNewUser.SetError(tbConfirmPassword, "Password Not Matched");
            }
            else
            {
                erpAddNewUser.SetError(tbConfirmPassword, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //This Validation Is Not 100% Correct
            if (erpAddNewUser.GetError(tbUserName) != "" || erpAddNewUser.GetError(tbConfirmPassword) != "")
            {
                MessageBox.Show("Please Fix The Errors You Have Before You Can Save!");
                return;
            }
            clsUser User = new clsUser();
            if (Mode == enMode.eUpdate)
            {
                User.UserID = int.Parse(lblUserID.Text);
                User.Mode = clsUser.enMode.eUpdate;
            }
            clsPerson Person = new clsPerson();
            Person.PersonID = _PersonID;

            User.UserName = tbUserName.Text;
            User.Password = tbPassword.Text;
            User.isActive = chkIsActive.Checked;
            User.Person = Person;
            
            if (User.Save())
            {
                lblUserID.Text = User.UserID.ToString();
                lblAddUpdate.Text = "Update User";
                Mode = enMode.eUpdate;
                MessageBox.Show("User Saved Successfully");
                this.ctrlPersonSearch1.DisablePersonFilter();

                //SendDataBack();
                DataBack?.Invoke(this._UserID);          
            }
            else
            {
                MessageBox.Show("User Was Not Saved");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.eUpdate)
            {
                lblAddUpdate.Text = "Update User";
                clsUser User = clsUser.GetUserByUserID(_UserID);
                lblUserID.Text = User.UserID.ToString();
                tbUserName.Text = User.UserName;
                tbPassword.Text = User.Password;
                tbConfirmPassword.Text = User.Password;
                chkIsActive.Checked = User.isActive;
                _PersonID = User.Person.PersonID;
                this.ctrlPersonSearch1.DisablePersonFilter();
                this.ctrlPersonSearch1.FillPersonDetails(_PersonID);
            }
        }

        private void ctrlPersonSearch1_onPersonID(int obj)
        {
            _PersonID = obj;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
