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
    public partial class ctrlLicenseHistory : UserControl
    {
        int _PersonID = -1;

        public ctrlLicenseHistory()
        {
            InitializeComponent();

        }

        public void FillLicenseHistory(int PersonID)
        {
            _PersonID = PersonID;
            this.ctrlPersonSearch1.DisablePersonFilter();
            this.ctrlDriverLicenses1.FillDriverLicenses(_PersonID);
            this.ctrlPersonSearch1.FillPersonDetails(_PersonID);
        }
    }
}
