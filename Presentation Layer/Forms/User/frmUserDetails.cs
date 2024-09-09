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
    public partial class frmUserDetails : Form
    {
        public int _UserID = -1;
        public frmUserDetails(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlUserDetails2_Load(object sender, EventArgs e)
        {

        }
    }
}
