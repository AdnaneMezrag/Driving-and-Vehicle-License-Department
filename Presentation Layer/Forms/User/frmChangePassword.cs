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
    public partial class frmChangePassword : Form
    {
        int _UserID = -1;
        public frmChangePassword(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void tbCurrentPassword_Leave(object sender, EventArgs e)
        {
            string OldPassword = clsUser.GetUserByUserID(_UserID).Password;
            if (tbCurrentPassword.Text != OldPassword)
            {
                erpChangePassword.SetError(tbCurrentPassword, "Current Password Is Wrong");
            }
            else
            {
                erpChangePassword.SetError(tbCurrentPassword, "");

            }

            }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                erpChangePassword.SetError(tbConfirmPassword, "Password Not Matched");
            }
            else
            {
                erpChangePassword.SetError(tbConfirmPassword, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (erpChangePassword.GetError(tbCurrentPassword) != "" || erpChangePassword.GetError(tbConfirmPassword) != "")
            {
                MessageBox.Show("Please Fix The Errors You Have Before You Can Save!");
                return;
            }

            clsUser User = clsUser.GetUserByUserID(_UserID);
            User.Password = tbPassword.Text;
            if (User.Save())
            {
                MessageBox.Show("User Password Updated Successfully");
            }
            else
            {
                MessageBox.Show("User Password Was Not Updated");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

