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
    public partial class ctrlUserDetails : UserControl
    {
        public int _UserID = -1;
        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        public ctrlUserDetails(int UserID):this()
        {
            _UserID = UserID;
            this.ctrlPersonDetails1._PersonID = (clsUser.GetUserByUserID(_UserID)).Person.PersonID;
            this.ctrlUserDetails1._UserID = _UserID;
        }

        private void ctrlUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
