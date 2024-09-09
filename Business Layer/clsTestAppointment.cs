using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public clsTestType TestType { get; set; }
        public clsLocalDrivingLicenseApplication LDLApp { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public clsUser CreatedByUser { get; set; }
        public bool IsLocked { get; set; }
        public clsApplication RetakeTestApplication { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestType = null;
            AppointmentDate = DateTime.Now;
            LDLApp = null;
            IsLocked = false;
            PaidFees = -1;
            CreatedByUser = null;
            RetakeTestApplication = null;

            Mode = enMode.eAddNew;
        }

        public clsTestAppointment(int ID, clsTestType TestType, clsLocalDrivingLicenseApplication LDLApp,
            DateTime AppointmentDate
            , decimal PaidFees, clsUser CreatedByUser,bool IsLocked, clsApplication retakeTestApplication)
        {
            this.TestAppointmentID = ID;
            this.AppointmentDate = AppointmentDate;
            this.IsLocked = IsLocked;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;
            this.LDLApp = LDLApp;
            this.TestType = TestType;

            Mode = enMode.eUpdate;
            RetakeTestApplication = retakeTestApplication;
        }


        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewTestAppointment(TestType.TestTypeID
            , LDLApp.LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUser.UserID,
            IsLocked,(RetakeTestApplication != null ? RetakeTestApplication.ApplicationID : -1));

            return (this.TestAppointmentID != -1);

        }

        private bool _UpdateTestAppointment()
        {

            return clsTestAppointmentDataAccess.UpdateTestAppointment(TestAppointmentID, TestType.TestTypeID,
              LDLApp.LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUser.UserID,
              IsLocked, (RetakeTestApplication != null ? RetakeTestApplication.ApplicationID : -1));
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewTestAppointment())
                {
                    this.Mode = enMode.eUpdate;
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateTestAppointment();

            }
            return false;
        }

        public bool RetakeTest()
        {
            if(Mode == enMode.eUpdate)
            {
                return Save();
            }
            if (GetLastTestAppointmentByLDLAppID(LDLApp.LocalDrivingLicenseApplicationID, 
                TestType.TestTypeID) == null)
            {

                return Save();
            }
            clsApplication Application = new clsApplication();
            Application.ApplicationStatus = 2;
            Application.ApplicationDate = DateTime.Now;
            Application.LastStatusDate = DateTime.Now;
            Application.ApplicationPerson = this.LDLApp.Application.ApplicationPerson;
            Application.ApplicationType = clsApplicationType.GetApplicationTypeByID(8);
            Application.CreatedByUser = clsGlobalSettings.CurrentUser;
            Application.PaidFees = clsApplicationType.GetApplicationTypeByID(8).ApplicationFees;

            if (!Application.Save())
            {
                return false;
            }
            this.RetakeTestApplication = Application;
            return Save();
        }

        public static DataTable GetTestAppointmentsList()
        {
            return clsTestAppointmentDataAccess.GetTestAppointmentsList();
        }

        public static clsTestAppointment GetTestAppointmentByID(int ID)
        {
            decimal PaidFees = 0;
            bool IsLocked = false;
            DateTime AppointmentDate = DateTime.MinValue;

            int TestTypeID = -1, LDLAppID = -1 , UserID = -1 , RetakeTestAppointmentID = -1;

            if (clsTestAppointmentDataAccess.FindTestAppointmentByID(ID, ref TestTypeID, ref LDLAppID,
               ref AppointmentDate, ref PaidFees, ref UserID, ref IsLocked ,ref RetakeTestAppointmentID))
            {
                return new clsTestAppointment(ID, clsTestType.GetTestTypeByID(TestTypeID), 
                    clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(LDLAppID),
                    AppointmentDate, PaidFees, clsUser.GetUserByUserID(UserID) , IsLocked ,
                    clsApplication.GetApplicationByID(RetakeTestAppointmentID));
            }
            return null;
        }

        public static clsTestAppointment GetLastTestAppointmentByLDLAppID(int LDLAppID , int TestTypeID)
        {
            decimal PaidFees = 0;
            bool IsLocked = false;
            DateTime AppointmentDate = DateTime.MinValue;

            int TestAppointmentID = -1, UserID = -1 , RetakeTestAppointmentID = -1;

            if (clsTestAppointmentDataAccess.GetLastTestAppointmentByLDLAppID(LDLAppID,
                ref TestAppointmentID, ref TestTypeID, 
               ref AppointmentDate, ref PaidFees, ref UserID, ref IsLocked , ref RetakeTestAppointmentID))
            {
                return new clsTestAppointment(TestAppointmentID, clsTestType.GetTestTypeByID(TestTypeID),
                    clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(LDLAppID),
                    AppointmentDate, PaidFees, clsUser.GetUserByUserID(UserID), IsLocked , 
                    clsApplication.GetApplicationByID(RetakeTestAppointmentID));
            }
            return null;
        }

        public static int GetTrial(int LDLAppID , int TestTypeID) { 
        
            return clsTestAppointmentDataAccess.GetTrials(LDLAppID, TestTypeID);
        }

        public static DataTable GetTestAppointmentsListByLDLAppIDAndTestType(int LDLAppID , int TestTypeID)
        {
            return clsTestAppointmentDataAccess.GetTestAppointmentsListByLDLAppIDAndTestType(LDLAppID , TestTypeID );
        }


    }
}
