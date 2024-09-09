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
    public partial class frmTakeTest : Form
    {

        public enum enTestType { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 }
        int _TestAppointmentID = -1;
        enTestType TestType;
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;

        public frmTakeTest(enTestType TestType, int testAppointmentID)
        {
            this.TestType = TestType;
            _TestAppointmentID = testAppointmentID;

            InitializeComponent();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            groupBox1.Text = (TestType == enTestType.eVisionTest) ? "Vision Test" :
    (TestType == enTestType.eWrittenTest) ? "Written Test" : "Street Test";

            clsTestAppointment TestAppointment = clsTestAppointment.
                GetTestAppointmentByID(_TestAppointmentID);
            if(TestAppointment == null)
            {
                return;
            }
            lblLDLAppID.Text = TestAppointment.LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = TestAppointment.LDLApp.LicenseClass.ClassName;
            lblName.Text = TestAppointment.LDLApp.Application.ApplicationPerson.GetFullName();
            lblFees.Text = TestAppointment.PaidFees.ToString() ;
            lblTrial.Text = clsTestAppointment.GetTrial(TestAppointment.LDLApp.LocalDrivingLicenseApplicationID, (int)TestType).ToString();
            lblDate.Text = TestAppointment.AppointmentDate.ToString();

            if (TestAppointment.IsLocked)
            {
                btnSave.Enabled = false;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                rtbNotes.Enabled = false;
                clsTest Test = clsTest.GetTestByTestAppointmentID(_TestAppointmentID);
                rbFail.Checked = (!Test.TestResult);
                rtbNotes.Text = Test.Notes;
                lblTestID.Text = Test.TestID.ToString() ;
                lblTestPassedError.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaved = false;

            clsTest Test = new clsTest();


            Test.TestResult = (rbPass.Checked ? true : false);
            Test.TestAppointment = clsTestAppointment.GetTestAppointmentByID(_TestAppointmentID);
            Test.Notes = rtbNotes.Text;
            Test.CreatedByUser = clsGlobalSettings.CurrentUser; 

            if (Test.TakeTest())
            {
                lblTestID.Text = Test.TestID.ToString();
                MessageBox.Show("Test Saved Successfully");
                isSaved = true;
                btnSave.Enabled = false;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                rtbNotes.Enabled = false;
                //SendDataBack();
                //DataBack?.Invoke(this._TestAppointmentID);
            }
            else
            {
                MessageBox.Show("Test Was Not Saved");

            }
        
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke();
        }
    }
}
