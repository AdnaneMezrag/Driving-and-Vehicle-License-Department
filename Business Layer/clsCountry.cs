using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business_Layer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry(int ID , string CountryName)
        {
            this.CountryID = ID;
            this.CountryName = CountryName;
            Mode = enMode.eUpdate;
        }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;

        public static DataTable GetCountriesList()
        {
            return clsCountryDataAccess.GetCountriesList();
        }

        public static clsCountry GetCountryByID(int id)
        {
            string CountryName = "";
            if(clsCountryDataAccess.FindCountryByID(id, ref  CountryName)) { 
                return new clsCountry(id, CountryName);
            }
            return null;
        }

    }
}
