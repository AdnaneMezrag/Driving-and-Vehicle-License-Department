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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application
{
    public partial class frmUpdateApplicationType : Form
    {
        int _ApplicationTypeID = -1;
        public delegate void DataBackEventHandler(int ApplicationTypeID);
        public event DataBackEventHandler DataBack;

        public frmUpdateApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = applicationTypeID; 
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationTypeByID(_ApplicationTypeID);

            lblID.Text = _ApplicationTypeID.ToString();
            tbTitle.Text = applicationType.ApplicationTypeTitle.ToString();
            tbFees.Text = applicationType.ApplicationFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationTypeByID(_ApplicationTypeID);
            if(applicationType != null)
            {
                applicationType.ApplicationTypeTitle = tbTitle.Text;
                applicationType.ApplicationFees = decimal.Parse(tbFees.Text.ToString());
                if (applicationType.UpdateUser())
                {
                    DataBack?.Invoke(this._ApplicationTypeID);
                    MessageBox.Show("Application Type Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Application Type Was Not Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Application Type Was Not Found", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
