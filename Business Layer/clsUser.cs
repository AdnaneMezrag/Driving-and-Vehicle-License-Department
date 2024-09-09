using Data_Access_Layer;
using Driving_and_Vehicle_License_Department_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public clsPerson Person { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode Mode;
        public enum enLogin { eSucceeded = 0, eUserNamePasswordError = 1, eIsActiveError };
        public clsUser(int userID, clsPerson person, string userName, string password, bool isActive)
        {
            Person = person;
            UserID = userID;
            UserName = userName;
            Password = password;
            this.isActive = isActive;
            Mode = enMode.eUpdate;
        }

        public clsUser()
        {
            Person = null;
            UserID = -1;
            UserName = "";
            Password = "";
            this.isActive = false;
            Mode = enMode.eAddNew;
        }

        public static DataTable GetUsersList()
        {
            return clsUserDataAccess.GetUsersList();
        }

        public static DataTable GetUsersListForShow()
        {
            return clsUserDataAccess.GetUsersListForShow();
        }

        private bool _AddNewUser()
        {

            this.UserID = clsUserDataAccess.AddNewUser(this.Person.PersonID, this.UserName
             , this.Password, this.isActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {

            return clsUserDataAccess.UpdateUser(this.UserID, this.Person.PersonID, this.UserName
              , this.Password, this.isActive);
        }

        public bool Save()
        {
            if (Mode == enMode.eAddNew)
            {
                if (_AddNewUser())
                {
                    this.Mode = enMode.eUpdate;
                    //Save Image
                    return true;
                }
                return false;
            }
            else if (Mode == enMode.eUpdate)
            {
                return _UpdateUser();
                //Save Image

            }
            return false;
        }

        public static clsUser GetUserByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;
            if (clsUserDataAccess.FindUserByUserID(UserID, ref PersonID, ref UserName, ref Password,
                ref IsActive))
            {
                return new clsUser(UserID, clsPerson.GetPersonByID(PersonID), UserName, Password, IsActive);
            }
            return null;
        }

        public static clsUser GetUserByUserName(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            bool IsActive = false;
            if (clsUserDataAccess.FindUserByUserName(ref UserID, ref PersonID,  UserName, ref Password,
                ref IsActive))
            {
                return new clsUser(UserID, clsPerson.GetPersonByID(PersonID), UserName, Password, IsActive);
            }
            return null;
        }

        public static bool DoesUserExistByPersonID(int PersonID)
        {
            return clsUserDataAccess.DoesUserExistByPersonID(PersonID);
        }

        public static bool DeleteUserByUserID(int UserID)
        {
            return clsUserDataAccess.DeleteUserByUserID(UserID);
        }

        public static void SaveUserLoginInfoInRememberMeFile(string UserName , string Password)
        {

            string path = "D:\\Adnane\\Programing Advices\\Course19\\DVLD Project\\Business Layer\\RememberMe.txt";
            string text = $"{UserName}/#/{Password}";


            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(text);
            }
        }

        public static void RemoveUserLoginInfoFromRemeberMeFile()
        {

            string path = "D:\\Adnane\\Programing Advices\\Course19\\DVLD Project\\Business Layer\\RememberMe.txt";
            string text = $"";


            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(text);
            }
        }

        public void SaveUserInGlobalClass()
        {
            clsGlobalSettings.CurrentUser = this;   
        }

        public static enLogin Login(string UserName, string Password, bool RememberMe)
        {
            clsUser User = GetUserByUserName(UserName);
            if (User != null)
            {
                
                if (User.Password != Password)
                {
                    return enLogin.eUserNamePasswordError;
                }
                if (!User.isActive)
                {
                    return enLogin.eIsActiveError;
                }

                if (RememberMe)
                {
                    SaveUserLoginInfoInRememberMeFile(UserName, Password);
                }
                else
                {
                    RemoveUserLoginInfoFromRemeberMeFile();
                }
                User.SaveUserInGlobalClass();
                return enLogin.eSucceeded;
            }
            else
            {
                return enLogin.eUserNamePasswordError;

            }
        }

    }
}

