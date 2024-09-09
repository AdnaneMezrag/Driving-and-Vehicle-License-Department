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
    public partial class ctrlUserLoginInformation : UserControl
    {

        public int _UserID = -1;
        public ctrlUserLoginInformation()
        {
            InitializeComponent();
        }
        public ctrlUserLoginInformation(int UserID):this()
        {
            _UserID = UserID;
        }

        public void FillUserDetails(int UserID)
        {
            clsUser User = clsUser.GetUserByUserID(UserID);
            if(User!=null)
            {
                _UserID = UserID;
                lblUserID.Text = UserID.ToString();
                lblUserName.Text = User.UserName;
                lblIsActive.Text = (User.isActive == true ? "Yes" : "No");
            }

        }

        private void ctrlUserDetails_Load(object sender, EventArgs e)
        {
            FillUserDetails(_UserID);
        }
    }
}
