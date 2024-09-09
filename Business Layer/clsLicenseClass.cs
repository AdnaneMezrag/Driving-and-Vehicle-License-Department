using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = -1;
        }

        public clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
            byte MinimumAllowedAge , byte DefaultValidityLegnth , decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLegnth;
            this.ClassFees = ClassFees;
        }
        public static DataTable GetLicenseClass()
        {
            return clsLicenseClassDataAccess.GetLicenseClassesList();
        }
        public bool UpdateUser()
        {

            return clsLicenseClassDataAccess.UpdateLicenseClass(LicenseClassID, ClassName,
                ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
        }
        public static clsLicenseClass GetLicenseClassByID(int LicenseClassID)
        {
            decimal ClassFees = -1;
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLegnth = 0;
            if (clsLicenseClassDataAccess.FindLicenseClassByID(LicenseClassID,
                ref ClassName, ref ClassDescription,ref MinimumAllowedAge,ref DefaultValidityLegnth,
                ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, 
                    MinimumAllowedAge, DefaultValidityLegnth,  ClassFees);
            }
            return null;
        }

    }
}
