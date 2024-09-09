using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsTestType
    {
        public int TestTypeID { get; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }


        public clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeFees = TestTypeFees;
            this.TestTypeDescription = TestTypeDescription;
        }
        public static DataTable GetTestTypeList()
        {
            return clsTestTypeDataAccess.GetTestTypesList();
        }
        public bool UpdateUser()
        {

            return clsTestTypeDataAccess.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription,TestTypeFees);
        }
        public static clsTestType GetTestTypeByID(int TestTypeID)
        {
            decimal TestTypeFees = -1;
            string TestTypeTitle = "" , TestTypeDescription = "";
            if (clsTestTypeDataAccess.FindTestTypeByID(TestTypeID,
                ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription,TestTypeFees);
            }
            return null;
        }

    }
}
