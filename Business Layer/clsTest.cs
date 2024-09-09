using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public clsTestAppointment TestAppointment { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public clsUser CreatedByUser { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;
        public clsTest(int TestID, clsTestAppointment TestAppointment, bool TestResult, string Notes, clsUser CreatedByUser)
        {
            this.TestAppointment = TestAppointment;
            this.TestID = TestID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUser = CreatedByUser;

            Mode = enMode.eUpdate;
        }

        public clsTest()
        {
            TestAppointment = null;
            TestID = -1;
            TestResult = false;
            Notes = "";
            this.CreatedByUser = null;

            Mode = enMode.eAddNew;
        }

        public static DataTable GetUsersList()
        {
            return clsTestDataAccess.GetTestsList();
        }

        private bool _AddNewTest()
        {

            this.TestID = clsTestDataAccess.AddNewTest(this.TestAppointment.TestAppointmentID, this.TestResult
             , this.Notes, CreatedByUser.UserID);
            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {

            return clsTestDataAccess.UpdateTest(this.TestID, this.TestAppointment.TestAppointmentID, this.TestResult
              , this.Notes, this.CreatedByUser.UserID);
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewTest())
                {
                    this.Mode = enMode.eUpdate;
                    //Save Image
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateTest();
                //Save Image

            }
            return false;
        }

        public bool TakeTest()
        {
            TestAppointment.IsLocked = true;
            return Save() && TestAppointment.Save();
            
        }

        public static clsTest GetTestByID(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;
            if (clsTestDataAccess.FindTestByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes,
                ref CreatedByUserID))
            {
                return new clsTest(TestID, clsTestAppointment.GetTestAppointmentByID(TestAppointmentID),
                    TestResult, Notes, clsUser.GetUserByUserID(CreatedByUserID));
            }
            return null;
        }

        public static clsTest GetTestByTestAppointmentID(int TestAppointmentID)
        {
            int TestID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;
            if (clsTestDataAccess.FindTestByTestAppointmentID(ref TestID, TestAppointmentID, 
                ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, clsTestAppointment.GetTestAppointmentByID(TestAppointmentID),
                    TestResult, Notes, clsUser.GetUserByUserID(CreatedByUserID));
            }
            return null;
        }

    }
}
