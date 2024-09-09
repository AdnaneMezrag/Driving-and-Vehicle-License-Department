using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Controls.Application;
using Driving_and_Vehicle_License_Department_Project.Forms.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License
{
    public partial class frmDetainLicense : Form
    {
        int _LicenseID = -1;
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName.ToString();

        }

        private void ctrlLicenseSearch1_onLicenseID(int obj)
        {
            lblShowLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;
            tbFineFees.Enabled = false;
            tbFineFees.Text = "";

            _LicenseID = obj;
            if(_LicenseID == -1)
            {
                return;
            }
            lblLicenseID.Text = _LicenseID.ToString();

            clsDetainedLicense.enDetainLicense CanLicenseBeDetained = clsDetainedLicense.
    CanLicenseBeDetained(_LicenseID);


            if (CanLicenseBeDetained == clsDetainedLicense.enDetainLicense
                .eLicenseDetainedAlready)
            {
                MessageBox.Show("License Is Already Detained"
    , "Detain License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
                return;
            }
            else if (CanLicenseBeDetained == clsDetainedLicense.enDetainLicense
                .eLicenseNotActive)
            {
                MessageBox.Show("License Is Not Active"
    , "Detain License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
                return;
            }
            
            tbFineFees.Enabled = true;       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal FineFees = decimal.Parse(tbFineFees.Text);
            int DetainLicenseId = clsDetainedLicense.DetainLicense(_LicenseID, FineFees);
            if(DetainLicenseId == -1)
            {
                MessageBox.Show("License Is Not Detained"
, "Detain License", MessageBoxButtons.OK
, MessageBoxIcon.Error);
            }
            else
            {
                lblShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;
                tbFineFees.Enabled = false;
                lblDetainID.Text = DetainLicenseId.ToString ();
                this.ctrlLicenseSearch1.DisableLicenseFilterControl();
                MessageBox.Show("License Is Detained Successfully With DetainLicenseID = " + DetainLicenseId
, "Detain License", MessageBoxButtons.OK
, MessageBoxIcon.Information);
            }
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Check if the key pressed is a control key (like backspace)
                if (!char.IsControl(e.KeyChar))
                {
                    // Check if the key pressed is a digit (0-9)
                    if (!char.IsDigit(e.KeyChar))
                    {
                        // If it's not a control key and not a digit, suppress the key press
                        e.Handled = true;
                    }
                }
            
        }

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {
            if(tbFineFees.Text != "")
            {
                btnRenew.Enabled = true ;
            }
            else
            {
                btnRenew.Enabled = false ;
            }
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_LicenseID);
            frm.Show();
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if (_LicenseID != -1)
            {
                PersonID = clsLicense.GetLicenseByID(_LicenseID).Application.ApplicationPerson.PersonID;
            }
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

        private void frmDetainLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke();

        }
    }
}
