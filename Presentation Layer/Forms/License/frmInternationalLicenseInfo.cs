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
    public partial class frmInternationalLicenseInfo : Form
    {
        int _InternationalLicenseID = -1;
        public frmInternationalLicenseInfo(int internationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = internationalLicenseID;
            ctrlInternationalLicenseInfo1.FillLicenseInfoLoader(_InternationalLicenseID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
