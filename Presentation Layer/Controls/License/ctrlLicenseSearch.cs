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
    public partial class ctrlLicenseSearch : UserControl
    {
        int _LicenseID = -1;
        public event Action<int> onLicenseID;
        protected virtual void LicenseID(int LicenseID)
        {
            Action<int> handler = onLicenseID;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }
        public ctrlLicenseSearch()
        {
            InitializeComponent();
        }

        public void DisableLicenseFilterControl()
        {
            this.ctrlLicenseFilter1.Enabled = false;
        }
        public void EnableLicenseFilterControl()
        {
            this.ctrlLicenseFilter1.Enabled = true;
        }

        public void FillLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;
            ctrlLicenseFilter1.PersonSearch(LicenseID);
        }

        private void ctrlLicenseFilter1_onLicenseID(int obj)
        {
            _LicenseID = obj;
            ctrlLicenseInfo1.FillLicenseInfoLoader(_LicenseID);
            if (onLicenseID != null)
            {
                onLicenseID(_LicenseID);
            }
        }

    }
}
