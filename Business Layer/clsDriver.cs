using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public clsPerson Person { get; set; }
        public clsUser CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;
        public clsDriver(int DriverID, clsPerson person, clsUser CreatedByUser, DateTime CreatedDate)
        {
            Person = person;
            this.DriverID = DriverID;
            this.CreatedByUser = CreatedByUser;
            this.CreatedDate = CreatedDate;

            Mode = enMode.eUpdate;
        }

        public clsDriver()
        {
            Person = null;
            DriverID = -1;
            CreatedByUser = null;
            CreatedDate = DateTime.Now;

            Mode = enMode.eAddNew;
        }

        public static DataTable GetDriversList()
        {
            return clsDriverDataAccess.GetDriversList();
        }

        private bool _AddNewDriver()
        {

            this.DriverID = clsDriverDataAccess.AddNewDriver(this.Person.PersonID, 
                this.CreatedByUser.UserID
             , this.CreatedDate);
            return (this.DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            return clsDriverDataAccess.UpdateDriver(this.DriverID, this.Person.PersonID, 
                this.CreatedByUser.UserID, this.CreatedDate);
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewDriver())
                {
                    this.Mode = enMode.eUpdate;
                    //Save Image
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateDriver();
                //Save Image

            }
            return false;
        }

        public static clsDriver GetDriverByDriverID(int DriverID)
        {
            int PersonID = -1 , CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.FindDriverByDriverID(DriverID, ref PersonID, 
                ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, clsPerson.GetPersonByID(PersonID),
                    clsUser.GetUserByUserID( CreatedByUserID), CreatedDate);
            }
            return null;
        }

        public static clsDriver GetDriverByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.FindDriverByPersonID(ref DriverID,  PersonID,
                ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, clsPerson.GetPersonByID(PersonID),
                    clsUser.GetUserByUserID(CreatedByUserID), CreatedDate);
            }
            return null;
        }

        public static bool DeleteUserByDriverID(int DriverID)
        {
            return clsDriverDataAccess.DeleteDriverByDriverID(DriverID);
        }

    }
}
