using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Business_Layer.clsLicense;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public clsApplication Application { get; set; }
        public clsDriver Driver { get; set; }
        public clsLicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enum enIssueReason { FirstTime = 1 , Renew = 2 , ReplacementForDamaged = 3 , 
        ReplacementForLost = 4}
        public enIssueReason IssueReason { get; set; }
        public clsUser CreatedByUser { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public clsLicense()
        {
            LicenseID = -1;
            Application = null;
            LicenseClass = null;
            Driver = null;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = -1;
            IsActive = false;
            IssueReason = enIssueReason.FirstTime;
            CreatedByUser = null;

            Mode = enMode.eAddNew;
        }

        public clsLicense(int ID, clsApplication Application, clsDriver Driver,
            clsLicenseClass LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees ,
            bool IsActive , enIssueReason IssueReason , clsUser CreatedByUser)
        {
            this.LicenseClass = LicenseClass;
            this.LicenseID = ID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate; ;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.Driver = Driver;
            this.Application = Application;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUser = CreatedByUser;

            Mode = enMode.eUpdate;
        }


        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(Application.ApplicationID
            , Driver.DriverID, LicenseClass.LicenseClassID, IssueDate,
              ExpirationDate, Notes,
              PaidFees , IsActive , (byte)IssueReason , CreatedByUser.UserID);

            return (this.LicenseID != -1);

        }

        private bool _UpdateLicense()
        {

            return clsLicenseDataAccess.UpdateLicense(LicenseID, Application.ApplicationID
            , Driver.DriverID, LicenseClass.LicenseClassID, IssueDate,
              ExpirationDate, Notes,
              PaidFees, IsActive, (byte)IssueReason, CreatedByUser.UserID);
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewLicense())
                {
                    this.Mode = enMode.eUpdate;
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateLicense();

            }
            return false;
        }

        public static DataTable GetLicenseList()
        {
            return clsLicenseDataAccess.GetLicensesList();
        }

        public static DataTable GetLicensesListByPersonID(int PersonID)
        {
            return clsLicenseDataAccess.GetLicensesListByPersonID(PersonID);
        }

        public static clsLicense GetLicenseByID(int ID)
        {
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            DateTime IssueDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;

            int PersonID = -1, LicenseClassID = -1, ApplicationID = -1,DriverID = -1,
            CreatedByUserID = -1 ;

            if (clsLicenseDataAccess.FindLicenseByID(ID, ref ApplicationID
            , ref DriverID, ref LicenseClassID, ref IssueDate,
            ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref 
            CreatedByUserID))
            {
                return new clsLicense( ID, clsApplication.GetApplicationByID(ApplicationID),
                    clsDriver.GetDriverByDriverID( DriverID),
            clsLicenseClass.GetLicenseClassByID( LicenseClassID),
            IssueDate, ExpirationDate, Notes, PaidFees,
            IsActive,(enIssueReason) IssueReason, clsUser.GetUserByUserID(CreatedByUserID));
            }
            return null;
        }

        public static clsLicense GetLicenseByAppID(int ApplicationID)
        {
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            DateTime IssueDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;

            int PersonID = -1, LicenseClassID = -1, ID = -1, DriverID = -1,
            CreatedByUserID = -1;

            if (clsLicenseDataAccess.FindLicenseByAppID(ref ID, ApplicationID
            , ref DriverID, ref LicenseClassID, ref IssueDate,
            ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref
            CreatedByUserID))
            {
                return new clsLicense(ID, clsApplication.GetApplicationByID(ApplicationID),
                    clsDriver.GetDriverByDriverID(DriverID),
            clsLicenseClass.GetLicenseClassByID(LicenseClassID),
            IssueDate, ExpirationDate, Notes, PaidFees,
            IsActive, (enIssueReason)IssueReason, clsUser.GetUserByUserID(CreatedByUserID));
            }
            return null;
        }

        public static byte GetActiveLicensesNumber(int DriverID)
        {
            return clsLicenseDataAccess.GetActiveLicensesNumber(DriverID);
        }

        public static int IssueLicense(int LDLAppID , string Notes)
        {
            clsLicense License = new clsLicense();
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.
                GetLocalDrivingLicenseApplicationByID(LDLAppID);
            License.Application = LDLApp.Application;
            clsDriver Driver = clsDriver.GetDriverByPersonID(LDLApp.Application.ApplicationPerson.PersonID);
            if(Driver == null)
            {
                clsDriver D = new clsDriver();
                D.Person = LDLApp.Application.ApplicationPerson;
                D.CreatedByUser = clsGlobalSettings.CurrentUser;
                D.CreatedDate = DateTime.Now;
                if (!D.Save())
                {
                    return -1;
                }
                Driver = D;
            }
            License.Driver = Driver;
            License.LicenseClass = LDLApp.LicenseClass;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(LDLApp.LicenseClass.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = LDLApp.LicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason = enIssueReason.FirstTime;
            License.CreatedByUser = clsGlobalSettings.CurrentUser;
            if (!License.Save())
            {
                return -1;
            }
            LDLApp.Application.ApplicationStatus = 2;
            LDLApp.Application.LastStatusDate = DateTime.Now;
            if (!LDLApp.Application.Save())
            {
                return -1;
            }
            return License.LicenseID;
        }

        public static bool DoesLicenseExistByID(int LicneseID)
        {
            return clsLicenseDataAccess.DoesLicenseExistByID(LicneseID);
        }

        public enum enRenewLicense { eSuccess = 0 , eNotExpiredYet = 1 , eNotActive = 2}

        public static clsLicense RenewLicense(int OldLicenseID , string Notes)
        {
            clsLicense OldLicense = GetLicenseByID(OldLicenseID);
            if(OldLicense == null)
            {
                return null;
            }
            if (CanLicenseBeRenewed(OldLicenseID) != enRenewLicense.eSuccess)
            {
                return null;
            }

            OldLicense.IsActive = false;
            if (!OldLicense.Save())
            {
                return null;
            }
            

            clsApplication Application = new clsApplication();
            Application.ApplicationPerson = OldLicense.Application.ApplicationPerson;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationType = clsApplicationType.GetApplicationTypeByID(2);
            Application.ApplicationStatus = 2;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.GetApplicationTypeByID(2).ApplicationFees;
            Application.CreatedByUser = clsGlobalSettings.CurrentUser;
            if (!Application.Save())
            {
                return null;
            }           


            clsLicense NewLicense = OldLicense;
            NewLicense.IssueReason = enIssueReason.Renew;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(NewLicense.LicenseClass.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.CreatedByUser = clsGlobalSettings.CurrentUser;
            NewLicense.Application = Application;
            OldLicense.IsActive = true;
            NewLicense.Mode = enMode.eAddNew;

            if (!NewLicense.Save())
            {
                return null;
            }

            return NewLicense;

        }

        public static enRenewLicense CanLicenseBeRenewed(int OldLicenseID)
        {
            clsLicense OldLicense = GetLicenseByID(OldLicenseID);

            if (OldLicense.ExpirationDate.CompareTo(DateTime.Now) > 0)
            {
                return enRenewLicense.eNotExpiredYet;
            }
            if(OldLicense.IsActive == false)
            {
                return enRenewLicense.eNotActive;
            }
            return enRenewLicense.eSuccess;
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            clsLicense OldLicense = GetLicenseByID(LicenseID);
            if (OldLicense == null || !OldLicense.IsActive)
            {
                return false;
            }
            return true;
        }

        public enum enReplacementFor { eDamaged = 0 , eLost = 1}

        public static clsLicense ReplaceLicense(int OldLicenseID , enReplacementFor ReplacementFor)
        {
            clsLicense OldLicense = GetLicenseByID(OldLicenseID);
            if (OldLicense == null)
            {
                return null;
            }
            if (!OldLicense.IsActive)
            {
                return null;
            }

            OldLicense.IsActive = false;
            OldLicense.Save();


            clsApplication Application = new clsApplication();
            Application.ApplicationPerson = OldLicense.Application.ApplicationPerson;
            Application.ApplicationDate = DateTime.Now;
            if(ReplacementFor == enReplacementFor.eDamaged)
            {
                Application.ApplicationType = clsApplicationType.GetApplicationTypeByID(4);
            }
            else
            {
                Application.ApplicationType = clsApplicationType.GetApplicationTypeByID(3);
            }
            Application.PaidFees = Application.ApplicationType.ApplicationFees;
            Application.ApplicationStatus = 2;
            Application.LastStatusDate = DateTime.Now;
            Application.CreatedByUser = clsGlobalSettings.CurrentUser;
            Application.Save();



            clsLicense NewLicense = OldLicense;
            if (ReplacementFor == enReplacementFor.eDamaged)
            {
                NewLicense.IssueReason = enIssueReason.ReplacementForDamaged;
            }
            else
            {
                NewLicense.IssueReason = enIssueReason.ReplacementForLost;
            }
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(NewLicense.LicenseClass.DefaultValidityLength);
            NewLicense.CreatedByUser = clsGlobalSettings.CurrentUser;
            NewLicense.Application = Application;
            NewLicense.IsActive = true;
            NewLicense.Mode = enMode.eAddNew;

            NewLicense.Save();

            return NewLicense;

        }


    }
}
