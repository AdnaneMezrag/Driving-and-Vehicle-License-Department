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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    public partial class frmIssueDrivingLicense : Form
    {
        int _LDLAppID = -1;
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;

        public frmIssueDrivingLicense(int LDLAppID)
        {          
            InitializeComponent();
            _LDLAppID = LDLAppID;
            this.ctrlLDLAppInformation1.LDLAppID = _LDLAppID;
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLicense.IssueLicense(_LDLAppID, rtbNotes.Text);
            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully With LicenseID = " + LicenseID, "License Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("License Was Not Issued", "License Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIssueDrivingLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke();

        }
    }
}
