using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public clsPerson ApplicationPerson { get; set; }
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType ApplicationType { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public clsUser CreatedByUser { get; set; }


        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicationPerson = null;
            ApplicationType = null;
            ApplicationDate = DateTime.Now;
            ApplicationStatus = -1;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUser = null;


            Mode = enMode.eAddNew;
        }

        public clsApplication(int ID, clsPerson ApplicationPerson, DateTime ApplicationDate, 
            clsApplicationType ApplicationType,
            int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, clsUser CreatedByUser)
        {
            this.ApplicationType = ApplicationType;
            this.ApplicationID = ID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate; ;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationPerson = ApplicationPerson;

            Mode = enMode.eUpdate;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication( ApplicationPerson.PersonID
            ,  ApplicationDate,  ApplicationType.ApplicationTypeID,  ApplicationStatus,
              LastStatusDate,  PaidFees,
              CreatedByUser.UserID);

            return (this.ApplicationID != -1);

        }

        private bool _UpdateApplication()
        {

            return clsApplicationDataAccess.UpdateApplication( ApplicationID,  ApplicationPerson.PersonID,
              ApplicationDate,  ApplicationType.ApplicationTypeID,  ApplicationStatus,
              LastStatusDate,  PaidFees,
              CreatedByUser.UserID);
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewApplication())
                {
                    this.Mode = enMode.eUpdate;
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateApplication();

            }
            return false;
        }

        public static DataTable GetApplicationList()
        {
            return clsApplicationDataAccess.GetApplicationsList();
        }

        public static clsApplication GetApplicationByID(int ID)
        {
            DateTime ApplicationDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int ApplicationStatus = -1;

            int PersonID = -1, ApplicationTypeID = -1,
                UserID = -1;
            if (clsApplicationDataAccess.FindApplicationByID(ID, ref PersonID, ref ApplicationDate,
               ref ApplicationTypeID, ref ApplicationStatus,
               ref LastStatusDate, ref PaidFees, ref UserID))
            {
                return new clsApplication(ID, clsPerson.GetPersonByID(PersonID), ApplicationDate,
                    clsApplicationType.GetApplicationTypeByID(ApplicationTypeID), 
                    ApplicationStatus, LastStatusDate
                    , PaidFees, clsUser.GetUserByUserID(UserID));
            }
            return null;
        }

        public bool CancelApplication()
        {
            return clsApplicationDataAccess.CancelApplication(this.ApplicationID);
        }

        public static bool DeleteApplicationByID(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplicationByID(ApplicationID);
        }
    }
}
