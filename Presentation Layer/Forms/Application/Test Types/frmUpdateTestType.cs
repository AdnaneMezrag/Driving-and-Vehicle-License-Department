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
    public partial class frmUpdateTestType : Form
    {
        int _TestTypeID = -1;
        public delegate void DataBackEventHandler(int TestTypeID);
        public event DataBackEventHandler DataBack;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            clsTestType TestType = clsTestType.GetTestTypeByID(_TestTypeID);
            if (TestType != null)
            {
                TestType.TestTypeTitle = tbTitle.Text;
                TestType.TestTypeFees = decimal.Parse(tbFees.Text.ToString());
                TestType.TestTypeDescription = rtbDescription.Text;
                if (TestType.UpdateUser())
                {
                    DataBack?.Invoke(this._TestTypeID);
                    MessageBox.Show("Test Type Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Test Type Was Not Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Test Type Was Not Found", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmUpdateTestType_Load_1(object sender, EventArgs e)
        {
            clsTestType TestType = clsTestType.GetTestTypeByID(_TestTypeID);

            lblID.Text = _TestTypeID.ToString();
            tbTitle.Text = TestType.TestTypeTitle.ToString();
            tbFees.Text = TestType.TestTypeFees.ToString();
            rtbDescription.Text = TestType.TestTypeDescription.ToString();
        }
    }
}
