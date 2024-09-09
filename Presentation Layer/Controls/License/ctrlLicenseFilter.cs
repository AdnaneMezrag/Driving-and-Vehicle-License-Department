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

namespace Driving_and_Vehicle_License_Department_Project.Controls.License
{
    public partial class ctrlLicenseFilter : UserControl
    {

        public event Action<int> onLicenseID;

        protected virtual void LicenseID(int LicenseID)
        {
            Action<int> handler = onLicenseID;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        public ctrlLicenseFilter()
        {
            InitializeComponent();
        }

        private void tbFilterPeople_KeyPress(object sender, KeyPressEventArgs e)
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

        public void PersonSearch(int LicenseID)
        {
            if(LicenseID != -1)
            {
                tbFilterPeople.Text = LicenseID.ToString();
            }
            if (tbFilterPeople.Text == "")
            {
                return;
            }
            if (!clsLicense.DoesLicenseExistByID(int.Parse(tbFilterPeople.Text)))
            {
                MessageBox.Show("License With Such License ID Doesen't Exist", "License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            else
            {
                //Send National No To The Person Details Control
                LicenseID = int.Parse(tbFilterPeople.Text);
            }
            if (onLicenseID != null)
            {
                onLicenseID(LicenseID);
            }
        }

        private void pbPersonSearcher_Click(object sender, EventArgs e)
        {
            PersonSearch(-1);
        }

    }
}
