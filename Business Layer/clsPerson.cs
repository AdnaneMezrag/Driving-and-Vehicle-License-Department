using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enum enGendor { eMale = 0 , eFemale = 1}
        public enGendor Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;


        public string GetFullName()
        {
            return FirstName +" "+ SecondName + " " + ThirdName + " " + LastName;
        }
        private int DifferenceInYears(DateTime date1,DateTime date2)
        {
            if (date1 < date2)
            {
                return -1;
            }
            if (date1.Month > date2.Month || (date1.Month==date2.Month && date1.Day>=date2.Day))
            {
                return date1.Year - date2.Year;
            }
            return date1.Year - date2.Year - 1;
        }
        public int GetAge()
        {
            return DifferenceInYears(DateTime.Now , DateOfBirth);
        }
        public clsPerson()
        {
            PersonID = -1;
            NationalityCountryID = -1;
            NationalNo = "";
            Phone = "";
            Email = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            ImagePath = "";
            Address = "";
            Gendor = enGendor.eMale;
            DateOfBirth = DateTime.Now;

            Mode = enMode.eAddNew;
        }

        public clsPerson(string NationalNo, int ID, string FirstName
             , string SecondName, string ThirdName, string LastName,
              DateTime DateOfBirth, enGendor Gendor, string Address,
              string Phone, string Email, int NationalityCountryID,
              string ImagePath)
        {
            this.NationalNo = NationalNo;
            this.PersonID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName; ;
            this.ThirdName = ThirdName; 
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.eUpdate;
        }


        private bool _AddNewPerson()
        {
        
           this.PersonID = clsPersonDataAccess.AddNewPerson(this.NationalNo, this.FirstName
            , this.SecondName, this.ThirdName, this.LastName,
              this.DateOfBirth, (clsPersonDataAccess.enGendor)this.Gendor, this.Address,
              this.Phone, this.Email, this.NationalityCountryID,
              this.ImagePath);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {

            return  clsPersonDataAccess.UpdatePerson(this.PersonID , 
                this.NationalNo, this.FirstName
              , this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, (clsPersonDataAccess.enGendor)this.Gendor, this.Address,
                this.Phone, this.Email, this.NationalityCountryID,
                this.ImagePath);
        }

        public bool Save()
        {
            if(Mode == enMode.eAddNew)
            {
                if (_AddNewPerson())
                {
                    this.Mode = enMode.eUpdate;
                    //Save Image
                    return true;
                }
                return false;
            }
            else if(Mode == enMode.eUpdate)
            {
                return _UpdatePerson();
                //Save Image
                 
            }
            return false;
        }

        public static DataTable GetPeopleList()
        {
            return clsPersonDataAccess.GetPeopleList();
        }

        public static DataTable GetPeopleListForShow()
        {
            return clsPersonDataAccess.GetPeopleListForShow();
        }

        public static clsPerson GetPersonByID(int ID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "",
            Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            enGendor Gendor = enGendor.eMale;
            int NationalityCountryID = -1;

            clsPersonDataAccess.enGendor GendorToPass = (clsPersonDataAccess.enGendor)Gendor;
            if(clsPersonDataAccess.FindPersonByID(ID, ref NationalNo, ref FirstName,
               ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
               ref GendorToPass, ref Address, ref Phone,
               ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(NationalNo, ID, FirstName, SecondName, ThirdName, LastName
                    , DateOfBirth, (clsPerson.enGendor)GendorToPass, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            return null;
        }

        public static clsPerson GetPersonByNationalNo(string NationalNo)
        {
            int ID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
            Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            enGendor Gendor = enGendor.eMale;
            int NationalityCountryID = -1;

            clsPersonDataAccess.enGendor GendorToPass = (clsPersonDataAccess.enGendor)Gendor;
            if (clsPersonDataAccess.FindPersonByNationalNo(NationalNo , ref ID, ref FirstName,
               ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
               ref GendorToPass, ref Address, ref Phone,
               ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(NationalNo, ID, FirstName, SecondName, ThirdName, LastName
                    , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            return null;
        }

        public static DataTable FindPersonByID(int PersonID)
        {
            return  clsPersonDataAccess.FindPersonByID(PersonID);

            //if(dtPerson != null)
            //{
                
            //    //dtPerson.Rows[0]
            //}
        }

        public static DataTable FindPersonByNationalNo(string NationalNo)
        {
            return clsPersonDataAccess.FindPersonByNationalNo(NationalNo);
        }

        public static DataTable FindPersonByFirstName(string FirstName)
        {
            return clsPersonDataAccess.FindPersonByFirstName(FirstName);
        }

        public static DataTable FindPersonBySecondName(string SecondName)
        {
            return clsPersonDataAccess.FindPersonBySecondName(SecondName);
        }

        public static DataTable FindPersonByThirdName(string ThirdName)
        {
            return clsPersonDataAccess.FindPersonByThirdName(ThirdName);
        }

        public static DataTable FindPersonByLastName(string LastName)
        {
            return clsPersonDataAccess.FindPersonByLastName(LastName);
        }

        public static DataTable FindPersonByNationality(string Nationality)
        {
            return clsPersonDataAccess.FindPersonByNationality(Nationality);
        }

        public static DataTable FindPersonByGendor(enGendor Gendor)
        {
            return clsPersonDataAccess.FindPersonByGendor((clsPersonDataAccess.enGendor)Gendor);
        }

        public static DataTable FindPersonByPhone(string Phone)
        {
            return clsPersonDataAccess.FindPersonByPhone(Phone);
        }

        public static DataTable FindPersonByEmail(string Email)
        {
            return clsPersonDataAccess.FindPersonByEmail(Email);
        }

        public static bool DoesPersonExistByNationalNo(string NationalNo)
        {
            return clsPersonDataAccess.DoesPersonExistByNationalNo(NationalNo);
        }

        public static bool DoesPersonExistByPersonID(int PersonID)
        {
            return clsPersonDataAccess.DoesPersonExistByPersonID(PersonID);
        }

        public static bool DeletePersonByID(int PersonID)
        {
            return clsPersonDataAccess.DeletePersonByID(PersonID);
        }

    }
}
