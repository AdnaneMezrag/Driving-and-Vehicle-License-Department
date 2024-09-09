using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsApplication Application { get; set; }
        public clsLicenseClass LicenseClass { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        private bool _AddNewLocalDrivingLicenseApplication()
        {

            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationDataAccess.AddNewApplication(Application.ApplicationID
                ,LicenseClass.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
            
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewLocalDrivingLicenseApplication())
                {
                    this.Mode = enMode.eUpdate;
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                //return _UpdateApplication();

            }
            return false;
        }

        public clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, clsApplication Application, clsLicenseClass LicenseClass)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.Application = Application;
            this.LicenseClass = LicenseClass;
        }

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.Application = null;
            this.LicenseClass = null;
        }

        public static DataTable GetLocalDrivingLicenseApplicationsList()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationsList();
        }

        public bool UpdateUser()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID, this.Application.ApplicationID, 
                this.LicenseClass.LicenseClassID);
        }

        public bool CanApplicationBeAdded()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.CanApplicationBeAdded(
                this.LicenseClass.LicenseClassID, this.Application.ApplicationPerson.PersonID);
        }

        public static clsLocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationByID(
            int LocalDrivingLicenseApplicationID)
        {
            int applicationID = -1;
            int LicenseClassID = -1;
            clsLicenseClass LicenseClass = null;
            clsApplication Application = null;
            if (clsLocalDrivingLicenseApplicationDataAccess.FindLocalDrivingLicenseApplicationByID
                (LocalDrivingLicenseApplicationID, ref applicationID,
                 ref LicenseClassID))
            {
                
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID,
                    clsApplication.GetApplicationByID(applicationID), 
                    clsLicenseClass.GetLicenseClassByID(LicenseClassID));
            }
            return null;
        }

        public static short GetPassedTestsNumber(int LDLAppID) { 

            return clsLocalDrivingLicenseApplicationDataAccess.GetPassedTestsNumber(LDLAppID);
        }

        public enum enAddTestAppointment { eCanAdd = 1 , eExists = 2 , ePassed}

        public static enAddTestAppointment CanAppointmentBeAdded(int LDLAppID , int TestTypeID)
        {

            clsTestAppointment Appointment = clsTestAppointment.GetLastTestAppointmentByLDLAppID(LDLAppID , TestTypeID);
            if(Appointment == null)
            {
                return enAddTestAppointment.eCanAdd;
            }
            clsTest Test = clsTest.GetTestByTestAppointmentID(Appointment.TestAppointmentID);
            if (Appointment.IsLocked == false)
            {
                return enAddTestAppointment.eExists;
            } else if (Appointment.IsLocked == true && Test.TestResult == true)
            {
                return enAddTestAppointment.ePassed;
            }
            else
            {
                return enAddTestAppointment.eCanAdd;
            }

        }

        public static bool DeleteLDLAppByID(int LDLAppID)
        {
            int ApplicationID = GetLocalDrivingLicenseApplicationByID(LDLAppID).Application.ApplicationID;

            return clsApplication.DeleteApplicationByID(ApplicationID) &&
                clsLocalDrivingLicenseApplicationDataAccess.DeleteLDLAppByID(LDLAppID);
        }

        public static int GetLicenseIDByLDLAppID(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetLicenseIDByLDLAppID(LDLAppID);
        }
    }
}
