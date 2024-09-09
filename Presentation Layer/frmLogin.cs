using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private clsUser.enLogin CanLogin()
        {
            string Password = tbPassword.Text;
            string UserName = tbUserName.Text;
            bool isRemembered = chkRememberMe.Checked;
            return (clsUser.Login(UserName, Password, isRemembered) );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser.enLogin LoginResult = CanLogin();
            if (LoginResult == clsUser.enLogin.eSucceeded)
            {
                this.Visible = false;
                frmMain frmMain = new frmMain(this);
                frmMain.ShowDialog();
            }
            else if(LoginResult == clsUser.enLogin.eUserNamePasswordError)
            {
                MessageBox.Show("Invalid UserName/Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your Account Is Disactivated, Please Contact Your Admin", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ReadRememberMeFile()
        {
            string path = "D:\\Adnane\\Programing Advices\\Course19\\DVLD Project\\Business Layer\\RememberMe.txt";
            using (StreamReader reader = new StreamReader(path))
            {

                string readText = reader.ReadToEnd();

                if(readText == "\r\n")
                {
                    return;
                }

                char[] Seperator = new char[] { '/', '#', '/' };
                string[] Words = readText.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);

                tbUserName.Text = Words[0];
                tbPassword.Text = Words[1].TrimEnd();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ReadRememberMeFile();
        }
    }
}
