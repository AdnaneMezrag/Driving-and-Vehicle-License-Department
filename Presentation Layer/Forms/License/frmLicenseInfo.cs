using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.License
{
    public partial class frmLicenseInfo : Form
    {
        int _LicenseID = -1;
        public frmLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
            this.ctrlLicenseInfo1.FillLicenseInfoLoader(_LicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
