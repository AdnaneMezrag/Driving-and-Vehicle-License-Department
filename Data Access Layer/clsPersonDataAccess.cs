using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Access_Layer
{
    public class clsPersonDataAccess
    {
        public enum enGendor { eMale = 0, eFemale = 1 }

        public static int AddNewPerson(string NationalNo, string FirstName
            ,  string SecondName,  string ThirdName,  string LastName,
             DateTime DateOfBirth,  enGendor Gendor,  string Address,
             string Phone,  string Email,  int NationalityCountryID,
             string ImagePath)
        {
            if (NationalNo == "") { NationalNo = null; }
            if (FirstName == "") { FirstName = null; }
            if (SecondName == "") { SecondName = null; }
            if (LastName == "") { LastName = null; }
            if (Address == "") { Address = null; }
            if (Phone == "") { Phone = null; }

            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into People ( NationalNo, FirstName, SecondName, 
ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID
, ImagePath ) values ( @NationalNo,@FirstName,@SecondName,@ThirdName,@LastName
,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath );
select scope_identity() as ID;";

            
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if(ThirdName != "")
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);//Allows NULL
            }
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            if(Email != "")
            {
                cmd.Parameters.AddWithValue("@Email", Email);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);//Allows NULL
            }
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);//Allows NULL

            }


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    PersonID = ID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return PersonID;
        }


        public static bool UpdatePerson(int PersonID , string NationalNo, string FirstName
            , string SecondName, string ThirdName, string LastName,
             DateTime DateOfBirth, enGendor Gendor, string Address,
             string Phone, string Email, int NationalityCountryID,
             string ImagePath)
        {
            if (NationalNo == "") { NationalNo = null; }
            if (FirstName == "") { FirstName = null; }
            if (SecondName == "") { SecondName = null; }
            if (LastName == "") { LastName = null; }
            if (Address == "") { Address = null; }
            if (Phone == "") { Phone = null; }

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update People set NationalNo = @NationalNo, 
FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName,
 DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone, 
Email = @Email, NationalityCountryID = @NationalityCountryID
, ImagePath = @ImagePath where PersonID = @PersonID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);//Allows NULL
            }
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            if (Email != "")
            {
                cmd.Parameters.AddWithValue("@Email", Email);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);//Allows NULL
            }
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);//Allows NULL
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);//Allows NULL

            }


            try
            {
                Connection.Open();
                int RowsAffected= cmd.ExecuteNonQuery();
                if (RowsAffected>0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return true ;
        }

        public static DataTable GetPeopleList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from People;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader!=null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable GetPeopleListForShow()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static bool FindPersonByID(int ID, ref string NationalNo, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref enGendor Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID,
            ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People where PersonID = @ID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    NationalNo = (Reader["NationalNo"]).ToString();
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    byte GendorInt = (byte)Reader["Gendor"];
                    Gendor = (enGendor)GendorInt;
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = Reader["Email"].ToString();
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = Reader["ImagePath"].ToString();
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool FindPersonByNationalNo(string NationalNo, ref int ID, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref enGendor Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID,
            ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People where NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    byte GendorInt = (byte)Reader["Gendor"];
                    Gendor = (enGendor)GendorInt;
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = Reader["Email"].ToString();
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = Reader["ImagePath"].ToString();
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static DataTable FindPersonByID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email , Address , 
                ImagePath from People 
                inner join Countries on People.NationalityCountryID = Countries.
                CountryID where PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByNationalNo(string NationalNo)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                inner join Countries on People.NationalityCountryID = Countries.
                CountryID where NationalNo = @NationalNo;";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByFirstName(string FirstName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID where FirstName = @FirstName;";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonBySecondName(string SecondName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID where SecondName = @SecondName;";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByThirdName(string ThirdName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID where ThirdName = @ThirdName;";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByLastName(string LastName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID where LastName = @LastName;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByNationality(string Nationality)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                inner join Countries on People.NationalityCountryID = Countries.
                CountryID where Countries.CountryName = @Nationality;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@Nationality", Nationality);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByGendor(enGendor Gendor)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                inner join Countries on People.NationalityCountryID = Countries.
                CountryID  where Gendor = @Gendor;";
            byte GendorInt = (byte)Gendor;
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@Gendor", GendorInt);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByPhone(string Phone)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID  where Phone = @Phone;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static DataTable FindPersonByEmail(string Email)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select PersonID , NationalNo , FirstName ,  
                SecondName , ThirdName , LastName , 
				case 
					when Gendor = 0 then 'Male'
					when Gendor = 1 then 'Female'
					end as Gendor , DateOfBirth ,  
                Countries.CountryName as Nationality , Phone , Email from People 
                 inner join Countries on People.NationalityCountryID = Countries.
                CountryID  where Email = @Email;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@Email", Email);
            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader != null)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return dataTable;
        }

        public static bool DoesPersonExistByNationalNo(string NationalNo)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found = 1 from People where NationalNo = @NationalNo";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();

                object objID = cmd.ExecuteScalar();
                if (objID != null )
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool DoesPersonExistByPersonID(int PersonID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found = 1 from People where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                object objID = cmd.ExecuteScalar();
                if (objID != null)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool DeletePersonByID(int PersonID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from people where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows >= 0)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

    }
}
