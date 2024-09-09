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

namespace Driving_and_Vehicle_License_Department_Project.Controls.Application
{
    public partial class ctrlScheduleTest : UserControl
    {

        public enum enTestType { eVisionTest = 1 , eWrittenTest = 2 , eStreetTest = 3 }
        int _LDLAppID = -1;
        int _TestAppointmentID = -1;
        enTestType TestType;

        enum enMode { eAddNew = 0 , eUpdate = 1}
        enMode Mode = enMode.eAddNew;


        public ctrlScheduleTest(enTestType TestType, int LDLAppID, int testAppointmentID)
        {
            _LDLAppID = LDLAppID;
            this.TestType = TestType;
            _TestAppointmentID = testAppointmentID;

            if (_TestAppointmentID == -1)
            {
                Mode = enMode.eAddNew;
            }
            else
            {
                Mode = enMode.eUpdate;
            }

            InitializeComponent();
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();

        }

        private void ctrlScheduleTest_Load(object sender, EventArgs e)
        {

            groupBox1.Text = (TestType == enTestType.eVisionTest) ? "Vision Test" : 
                (TestType == enTestType.eWrittenTest) ? "Written Test" : "Street Test";

            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.
                GetLocalDrivingLicenseApplicationByID(_LDLAppID);
            lblLDLAppID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = LDLApp.LicenseClass.ClassName;
            lblName.Text = LDLApp.Application.ApplicationPerson.GetFullName();
            lblFees.Text = (clsTestType.GetTestTypeByID((int)TestType)).TestTypeFees.ToString();
            lblTrial.Text = clsTestAppointment.GetTrial(LDLApp.LocalDrivingLicenseApplicationID, (int)TestType).ToString();
            

            if(lblTrial.Text == "0")
            {
                gbRetakeTest.Enabled = false;
            }
            else
            {
                gbRetakeTest.Enabled = true;
                lblRAppFees.Text = clsApplicationType.GetApplicationTypeByID(8).ApplicationFees.ToString();
            }
            
            lblTotalFees.Text = (decimal.Parse(lblFees.Text) + decimal.Parse(lblRAppFees.Text)).ToString();
           
            if (Mode == enMode.eUpdate)
            {
                lblTestAppointmentID.Text = _TestAppointmentID.ToString();
                clsTestAppointment TestAppointment = clsTestAppointment.GetTestAppointmentByID(_TestAppointmentID);
                if(TestAppointment.RetakeTestApplication != null)
                {
                    lblRTestAppID.Text = TestAppointment.RetakeTestApplication.ApplicationID.ToString();
                }
                else
                {
                    lblRTestAppID.Text = "N/A";
                }

                if (TestAppointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    lblCannotUpdateAppointment.Visible = true;
                    dtpDate.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTestAppointment TestAppointment;
            if (Mode == enMode.eUpdate)
            {
                TestAppointment = clsTestAppointment.GetTestAppointmentByID(_TestAppointmentID);
            }
            else
            {
                TestAppointment = new clsTestAppointment();
            }

            TestAppointment.TestType = clsTestType.GetTestTypeByID((int)TestType);
            TestAppointment.LDLApp = clsLocalDrivingLicenseApplication.
                GetLocalDrivingLicenseApplicationByID(_LDLAppID);
            TestAppointment.AppointmentDate = dtpDate.Value;
            TestAppointment.PaidFees = decimal.Parse(lblFees.Text);
            TestAppointment.CreatedByUser = clsGlobalSettings.CurrentUser;
            TestAppointment.IsLocked = false;


            if (TestAppointment.RetakeTest())
            {
                Mode = enMode.eUpdate;
                lblTestAppointmentID.Text = TestAppointment.TestAppointmentID.ToString();
                if(TestAppointment.RetakeTestApplication != null)
                {
                    lblRTestAppID.Text = TestAppointment.RetakeTestApplication.ApplicationID.ToString();
                }
                else
                {
                    lblRTestAppID.Text = "N/A";
                }
                MessageBox.Show("TestAppointment Saved Successfully");
                btnSave.Enabled = false;
                dtpDate.Enabled = false;
                //SendDataBack();
                //DataBack?.Invoke(this._TestAppointmentID);
            }
            else
            {
                MessageBox.Show("TestAppointment Was Not Saved");

            }
        }

    }
}
