using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle , decimal ApplicationFees )
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public clsApplicationType()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = -1;
        }

        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypeDataAccess.GetApplicationsTypesList();
        }
        public bool UpdateUser()
        {

            return clsApplicationTypeDataAccess.UpdateApplicationType(this.ApplicationTypeID , this.ApplicationTypeTitle , this.ApplicationFees);
        }

        public static clsApplicationType GetApplicationTypeByID(int ApplicationTypeID)
        {
            decimal ApplicationFees = -1;
            string ApplicationTypeTitle = "";
            if (clsApplicationTypeDataAccess.FindApplicationTypeByID(ApplicationTypeID, 
                ref ApplicationTypeTitle,ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle , ApplicationFees);
            }
            return null;
        }


    }
}
