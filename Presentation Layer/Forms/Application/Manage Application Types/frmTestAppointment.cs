using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Controls.Application;
using Driving_and_Vehicle_License_Department_Project.Properties;
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
    public partial class frmTestAppointment : Form
    {
        int _LDLAppID = -1;
        DataView dvTestAppointment = new DataView();
        ctrlScheduleTest.enTestType TestType;
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;

        public frmTestAppointment(int lDLAppID , ctrlScheduleTest.enTestType TestType)
        {
            _LDLAppID = lDLAppID;
            this.TestType = TestType;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(clsLocalDrivingLicenseApplication.CanAppointmentBeAdded(_LDLAppID , (int)TestType) == 
                clsLocalDrivingLicenseApplication.enAddTestAppointment.ePassed)
            {
                MessageBox.Show("You Cannot Add An Appointment of a passed test", 
                    "Appointment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(clsLocalDrivingLicenseApplication.CanAppointmentBeAdded(_LDLAppID, (int)TestType) ==
                clsLocalDrivingLicenseApplication.enAddTestAppointment.eExists)
            {
                MessageBox.Show("Person Already Have An Active Appointment For This Test\n" +
                    "You Cannot Add New Appointment","Appointment Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //TestType = ctrlScheduleTest.enTestType.eVisionTest;              
                frmScheduleTest frmScheduleTest = new frmScheduleTest(TestType, _LDLAppID,-1);
                frmScheduleTest.DataBack += RefrechTestAppointmentsList;
                frmScheduleTest.Show();
            }
        }

        private void FillDataView()
        {
            DataView dv = clsTestAppointment.
    GetTestAppointmentsListByLDLAppIDAndTestType(_LDLAppID,(int)TestType).DefaultView;

            DataTable dtTestAppointments = new DataTable();
            dtTestAppointments.Columns.Add("Test AppointmentID");
            dtTestAppointments.Columns.Add("Appointment Date");
            dtTestAppointments.Columns.Add("Paid Fees");
            dtTestAppointments.Columns.Add("Is Locked");

            foreach (DataRowView row in dv)
            {
                clsTestAppointment testAppointment = clsTestAppointment.GetTestAppointmentByID(int.Parse(row["TestAppointmentID"].ToString()));
                clsLocalDrivingLicenseApplication LDLApp = testAppointment.LDLApp;
                dtTestAppointments.Rows.Add(row[0].ToString(),
                    testAppointment.AppointmentDate,testAppointment.PaidFees , testAppointment.IsLocked);

            }
            dvTestAppointment = dtTestAppointments.DefaultView;
        }

        private void ShowTestAppointment()
        {

            FillDataView();
            dgvTestAppointments.DataSource = dvTestAppointment;

        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            if(TestType == ctrlScheduleTest.enTestType.eWrittenTest)
            {
                pbTestAppointment.BackgroundImage = Resources.Written_Test;
                lblTestAppointment.Text = "Written Test Appointment";
            }else if(TestType == ctrlScheduleTest.enTestType.eStreetTest)
            {
                pbTestAppointment.BackgroundImage = Resources.Street_Test;
                lblTestAppointment.Text = "Street Test Appointment";
            }
            ShowTestAppointment();
            lblRecords.Text = dgvTestAppointments.Rows.Count.ToString();
        }

        public void RefrechTestAppointmentsList()
        {
            FillDataView();
            dgvTestAppointments.DataSource = dvTestAppointment;
            lblRecords.Text = dgvTestAppointments.Rows.Count.ToString();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {  
                int TestAppointmentID = -1;
                TestAppointmentID = int.Parse(dgvTestAppointments.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                frmScheduleTest frmScheduleTest = new frmScheduleTest(TestType, _LDLAppID, TestAppointmentID);
                frmScheduleTest.DataBack += RefrechTestAppointmentsList;
                frmScheduleTest.Show();
            
        }

        private void takeExamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            int TestAppointmentID = -1;
            TestAppointmentID = int.Parse(dgvTestAppointments.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmTakeTest frmTakeTest = new frmTakeTest((frmTakeTest.enTestType)TestType, TestAppointmentID);
            frmTakeTest.DataBack += this.ctrlLDLAppInformation2.FillLoader ;
            frmTakeTest.DataBack += RefrechTestAppointmentsList;
            frmTakeTest.Show();
            
        }

        private void frmTestAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke();
        }
    }
}
