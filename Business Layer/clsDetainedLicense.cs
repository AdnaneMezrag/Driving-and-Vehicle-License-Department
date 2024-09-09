using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsDetainedLicense
    {
        public int DetainID { get; set; }
        public clsLicense License { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public clsUser CreatedByUser { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public clsUser ReleasedByUser { get; set; }
        public clsApplication ReleaseApplication { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public clsDetainedLicense()
        {
            DetainID = -1;
            License = null;
            FineFees = -1;
            DetainDate = DateTime.Now;
            CreatedByUser = null;
            IsReleased = false;
            ReleaseDate = DateTime.Now;
            ReleasedByUser = null;
            ReleaseApplication = null;

            Mode = enMode.eAddNew;
        }

        public clsDetainedLicense(int ID, clsLicense License, DateTime DetainDate,
            decimal FineFees,
            clsUser CreatedByUser, bool IsReleased, DateTime ReleaseDate, clsUser ReleasedByUser,
            clsApplication ReleaseApplication )
        {
            this.FineFees = FineFees;
            this.DetainID = ID;
            this.CreatedByUser = CreatedByUser;
            this.IsReleased = IsReleased; ;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUser = ReleasedByUser;
            this.DetainDate = DetainDate;
            this.License = License;
            this.ReleaseApplication = ReleaseApplication;

            Mode = enMode.eUpdate;
        }


        private bool _AddNewLicense()
        {
            this.DetainID = clsDetainedLicenseDataAccess.AddNewDetainedLicense(License.LicenseID
            , DetainDate, FineFees, CreatedByUser.UserID,
              IsReleased, ReleaseDate,
              ReleasedByUser.UserID, ReleaseApplication.ApplicationID);

            return (this.DetainID != -1);

        }

        private bool _UpdateLicense()
        {

            return clsDetainedLicenseDataAccess.UpdateDetainedLicense(DetainID, License.LicenseID
            , DetainDate, FineFees, CreatedByUser.UserID,
              IsReleased, ReleaseDate,
              ReleasedByUser.UserID, ReleaseApplication.ApplicationID);
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

        public static DataTable GetDetainedLicenseList()
        {
            return clsDetainedLicenseDataAccess.GetDetainedLicensesList();
        }

        public static clsDetainedLicense GetDetainedLicenseByID(int ID)
        {

            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now , DetainDate = DateTime.Now;
            decimal FineFees = -1;

            int CreatedByUserID = -1, LicenseID = -1, ReleasedByUserID = -1,
            ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.FindDetainedLicenseByID(ID, ref LicenseID
            , ref DetainDate, ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicense(ID, clsLicense.GetLicenseByID(LicenseID), DetainDate,
            FineFees,clsUser.GetUserByUserID( CreatedByUserID), IsReleased, ReleaseDate, 
            clsUser.GetUserByUserID( ReleasedByUserID),
            clsApplication.GetApplicationByID( ReleaseApplicationID));
            }
            return null;

        }

        public static bool DoesDetainLicenseExistByID(int DetainID)
        {
            return clsDetainedLicenseDataAccess.DoesDetainedLicenseExistByID(DetainID);
        }

        public enum enDetainLicense { eSuccess = 0 , eLicenseNotActive = 1 , eLicenseDetainedAlready}

        public static enDetainLicense CanLicenseBeDetained(int LicenseID)
        {
            if (!clsLicense.IsLicenseActive(LicenseID))
            {
                return enDetainLicense.eLicenseNotActive;
            }
            if (IsLicenseDetained(LicenseID))
            {
                return enDetainLicense.eLicenseDetainedAlready;
            }
            return enDetainLicense.eSuccess;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseDataAccess.IsLicenseDetained(LicenseID);
        }

        public static int DetainLicense(int LicenseID , decimal FineFees)
        {
            if(CanLicenseBeDetained(LicenseID) != enDetainLicense.eSuccess)
            {
                return -1;
            }
            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense.License = clsLicense.GetLicenseByID(LicenseID);
            detainedLicense.ReleaseApplication = new clsApplication();
            detainedLicense.CreatedByUser = clsGlobalSettings.CurrentUser;
            detainedLicense.FineFees = FineFees;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.IsReleased = false;
            detainedLicense.ReleaseDate = DateTime.MinValue;
            detainedLicense.ReleasedByUser = new clsUser();

            if (detainedLicense.Save())
            {
                return detainedLicense.DetainID;
            }
            return -1;
        }

        public static clsDetainedLicense GetDetainedLicenseByLicenseID(int LicenseID)
        {
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now, DetainDate = DateTime.Now;
            decimal FineFees = -1;

            int CreatedByUserID = -1, ID = -1, ReleasedByUserID = -1,
            ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.FindDetainedLicenseByLicenseID(ref ID, LicenseID
            , ref DetainDate, ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicense(ID, clsLicense.GetLicenseByID(LicenseID), DetainDate,
            FineFees, clsUser.GetUserByUserID(CreatedByUserID), IsReleased, ReleaseDate,
            clsUser.GetUserByUserID(ReleasedByUserID),
            clsApplication.GetApplicationByID(ReleaseApplicationID));
            }
            return null;
        }

        public static bool CanLicenseBeReleased(int LicenseID)
        {
            if (!IsLicenseDetained(LicenseID))
            {
                return false;
            }
            return true;
        }

        public static int Release(int LicenseID)
        {
            //Add Application + Release

            if (!CanLicenseBeReleased(LicenseID))
            {
                return -1;
            }

            clsApplication application = new clsApplication();
            application.ApplicationStatus = 2;
            application.ApplicationDate = DateTime.Now;
            application.PaidFees = clsApplicationType.GetApplicationTypeByID(5).ApplicationFees;
            application.ApplicationPerson = clsLicense.GetLicenseByID(LicenseID).Application.ApplicationPerson;
            application.ApplicationType = clsApplicationType.GetApplicationTypeByID(5);
            application.CreatedByUser = clsGlobalSettings.CurrentUser;
            application.LastStatusDate = DateTime.Now;

            if (!application.Save())
            {
                return -1;
            }
            clsDetainedLicense detainedLicense = GetDetainedLicenseByLicenseID(LicenseID);
            detainedLicense.ReleaseApplication = application;
            detainedLicense.ReleasedByUser = clsGlobalSettings.CurrentUser;
            detainedLicense.ReleaseDate = DateTime.Now;
            detainedLicense.IsReleased = true;

            if(detainedLicense.Save())
            {
                return application.ApplicationID;
            }
            return -1;
        }

    }
}
