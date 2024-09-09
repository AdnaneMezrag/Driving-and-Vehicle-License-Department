using Driving_and_Vehicle_License_Department_Project.Controls.Application;
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
    public partial class frmScheduleTest : Form
    {

        ctrlScheduleTest.enTestType TestType;

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;
        int _LDLAppID = -1;
        int _TestAppointmentID = -1;

        public frmScheduleTest(ctrlScheduleTest.enTestType TestType , int LDLAppID, int testAppointmentID)
        {
            _LDLAppID = LDLAppID;
            this.TestType = TestType;
            _TestAppointmentID = testAppointmentID;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_FormClosed(object sender, FormClosedEventArgs e)
        {
                DataBack?.Invoke();          
        }
    }
}
