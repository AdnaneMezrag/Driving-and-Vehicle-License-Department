using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Layer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public clsApplication Application { get; set; }
        public clsDriver Driver { get; set; }
        public clsLicense IssuedUsingLocalLicense { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUser { get; set; }


        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            Application = null;
            IssuedUsingLocalLicense = null;
            Driver = null;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUser = null;


            Mode = enMode.eAddNew;
        }

        public clsInternationalLicense(int ID, clsApplication Application, clsDriver Driver,
            clsLicense IssuedUsingLocalLicense,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, clsUser CreatedByUser)
        {
            this.IssuedUsingLocalLicense = IssuedUsingLocalLicense;
            this.InternationalLicenseID = ID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate; ;
            this.IsActive = IsActive;
            this.CreatedByUser = CreatedByUser;
            this.Driver = Driver;
            this.Application = Application;

            Mode = enMode.eUpdate;
        }


        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewInternationalLicense(Application.ApplicationID
            , Driver.DriverID, IssuedUsingLocalLicense.LicenseID, IssueDate,
              ExpirationDate, IsActive,
              CreatedByUser.UserID);

            return (this.InternationalLicenseID != -1);

        }

        private bool _UpdateInternationalLicense()
        {

            return clsInternationalLicenseDataAccess.UpdateInternationalLicense(InternationalLicenseID, Application.ApplicationID,
              Driver.DriverID, IssuedUsingLocalLicense.LicenseID, IssueDate,
              ExpirationDate, IsActive,
              CreatedByUser.UserID);
        }

        private bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewInternationalLicense())
                {
                    this.Mode = enMode.eUpdate;
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateInternationalLicense();

            }
            return false;
        }

        public static DataTable GetInternationalLicensesList()
        {
            return clsInternationalLicenseDataAccess.GetInternationalLicensesList();
        }

        public static DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            return clsInternationalLicenseDataAccess.GetInternationalLicensesListByPersonID(PersonID);
        }

        public static clsInternationalLicense GetInternationalLicenseByID(int ID)
        {
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now;

            int ApplicationID = -1, IssuedUsingLocalLicenseID = -1, DriverID = -1,
                UserID = -1;
            if (clsInternationalLicenseDataAccess.FindInternationalLicenseByID(ID, ref ApplicationID, ref DriverID,
               ref IssuedUsingLocalLicenseID, ref IssueDate,
               ref ExpirationDate, ref IsActive, ref UserID))
            {
                return new clsInternationalLicense(ID, clsApplication.GetApplicationByID(ApplicationID),
                    clsDriver.GetDriverByDriverID(DriverID),
                    clsLicense.GetLicenseByID( IssuedUsingLocalLicenseID),
                    IssueDate, ExpirationDate
                    , IsActive, clsUser.GetUserByUserID(UserID));
            }
            return null;
        }

        public static bool DeleteInternationalLicenseByID(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.DeleteInternationalLicenseByID(InternationalLicenseID);
        }

        public static clsInternationalLicense GetLastInternationalLicenseByLicenseID(int IssuedUsingLocalLicenseID)
        {
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now;

            int ApplicationID = -1, ID = -1, DriverID = -1,
                UserID = -1;
            if (clsInternationalLicenseDataAccess.FindLastInternationalLicenseByLicenseID(ref ID, ref ApplicationID, ref DriverID,
               IssuedUsingLocalLicenseID, ref IssueDate,
               ref ExpirationDate, ref IsActive, ref UserID))
            {
                return new clsInternationalLicense(ID, clsApplication.GetApplicationByID(ApplicationID),
                    clsDriver.GetDriverByDriverID(DriverID),
                    clsLicense.GetLicenseByID(IssuedUsingLocalLicenseID),
                    IssueDate, ExpirationDate
                    , IsActive, clsUser.GetUserByUserID(UserID));
            }
            return null;
        }

        public static clsInternationalLicense IssueInternationaLicense(int LocalLicenseID)
        {
            //Save In Applications + Save In InternationalLicenses

            clsLicense License = clsLicense.GetLicenseByID(LocalLicenseID);

            if(License == null || License.LicenseClass.LicenseClassID != 3 )
            {
                return null;
            }
            if(!License.IsActive || ( License.ExpirationDate.CompareTo(DateTime.Now) < 0))
            {
                return null;
            }
            clsInternationalLicense OldInternationalLicense = GetLastInternationalLicenseByLicenseID
                (LocalLicenseID);

            if(OldInternationalLicense != null && (OldInternationalLicense.IsActive &&
                OldInternationalLicense.ExpirationDate.CompareTo(DateTime.Now) > 0))
            {
                return null;
            }

            clsApplication Application = new clsApplication();
            Application.ApplicationStatus = 2;
            Application.ApplicationDate = DateTime.Now;
            Application.LastStatusDate = DateTime.Now;
            clsApplicationType applicationType = clsApplicationType.GetApplicationTypeByID(6);
            Application.PaidFees = applicationType.ApplicationFees;
            Application.ApplicationPerson = License.Application.ApplicationPerson;
            Application.ApplicationType = applicationType;
            Application.CreatedByUser = clsGlobalSettings.CurrentUser;

            if (!Application.Save())
            {
                return null;
            }
            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            InternationalLicense.Application = Application;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicense.Driver = License.Driver;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.CreatedByUser = clsGlobalSettings.CurrentUser;
            InternationalLicense.IsActive = true;
            InternationalLicense.IssuedUsingLocalLicense = License;

            if(InternationalLicense.Save())
            {
                return InternationalLicense;
            }
            else
            {
                return null;
            }
        }

        public enum enIssueInternationalLicense {eSuccess = 0 , eActiveInternationalLicense = 1 ,
        eNotClass3 = 2 , eClass3NotActive = 3 , eClass3Expired = 4}
        public static enIssueInternationalLicense CanInternationalLicenseBeIssued(int LocalLicenseID)
        {

            clsLicense License = clsLicense.GetLicenseByID(LocalLicenseID);

            if (License == null || License.LicenseClass.LicenseClassID != 3)
            {
                return enIssueInternationalLicense.eNotClass3;
            }
            if (!License.IsActive || (License.ExpirationDate.CompareTo(DateTime.Now) < 0))
            {
                return enIssueInternationalLicense.eClass3NotActive;
            }
            if (License.ExpirationDate.CompareTo(DateTime.Now) < 0)
            {
                return enIssueInternationalLicense.eClass3Expired;
            }
            clsInternationalLicense OldInternationalLicense = GetLastInternationalLicenseByLicenseID
                (LocalLicenseID);

            if (OldInternationalLicense != null && (OldInternationalLicense.IsActive &&
                OldInternationalLicense.ExpirationDate.CompareTo(DateTime.Now) > 0))
            {

                return enIssueInternationalLicense.eActiveInternationalLicense;
            }
            return enIssueInternationalLicense.eSuccess;

        }

    }
}
