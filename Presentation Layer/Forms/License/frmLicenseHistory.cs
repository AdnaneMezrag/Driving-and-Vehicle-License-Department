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
    public partial class frmLicenseHistory : Form
    {
        int _PersonID = -1;
        public frmLicenseHistory(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            this.ctrlLicenseHistory2.FillLicenseHistory(_PersonID);
        }
    }
}
