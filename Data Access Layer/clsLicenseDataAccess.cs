using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsLicenseDataAccess
    {
        public static int AddNewLicense(int ApplicationID
            , int DriverID, int LicenseClassID, DateTime IssueDate,
             DateTime ExpirationDate, string Notes,
             decimal PaidFees , bool IsActive , byte IssueReason , int CreatedByUserID)
        {

            int LicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Licenses (ApplicationID, DriverID, 
LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees , IsActive ,IssueReason , 
CreatedByUserID) values (
@ApplicationID,@DriverID,@LicenseClassID,@IssueDate,@ExpirationDate,@Notes,@PaidFees,
@IsActive,@IssueReason,@CreatedByUserID);
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if(Notes == "")
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", Notes);

            }
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    LicenseID = ID;
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
            return LicenseID;
        }


        public static bool UpdateLicense(int LicenseID, int ApplicationID,
             int DriverID, int LicenseClassID, DateTime IssueDate,
             DateTime ExpirationDate, string Notes,
             decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update Licenses set ApplicationID = @ApplicationID,
DriverID = @DriverID, LicenseClassID = @LicenseClassID, 
IssueDate = @IssueDate,ExpirationDate = @ExpirationDate, Notes = @Notes, 
PaidFees = @PaidFees , IsActive = @IsActive , IssueReason = @IssueReason
,CreatedByUserID = @CreatedByUserID where LicenseID = @LicenseID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                Connection.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
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
            return true;
        }

        public static DataTable GetLicensesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Licenses;";

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

        public static DataTable GetLicensesListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Licenses.* from Licenses inner join Applications 
on applications.ApplicationID = Licenses.ApplicationID
where ApplicantPersonID = @PersonID;
";

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


        //    public static DataTable GetLicensesListForShow()
        //    {
        //        SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //        string Query = @"select LicenseID , LicenseID , ApplicationID ,  
        //            DriverID , LicenseClassID , IssueDate , 
        //case 
        //	when  = 0 then 'Male'
        //	when  = 1 then 'Female'
        //	end as  , ExpirationDate ,  
        //            Countries.CountryName as Nationality , PaidFees ,  from Licenses 
        //             inner join Countries on Licenses. = Countries.
        //            CountryID;";

        //        SqlCommand cmd = new SqlCommand(Query, Connection);
        //        DataTable dataTable = new DataTable();
        //        try
        //        {
        //            Connection.Open();
        //            SqlDataReader Reader = cmd.ExecuteReader();
        //            if (Reader != null)
        //            {
        //                dataTable.Load(Reader);
        //            }
        //            Reader.Close();

        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            //Enter it in Log Errors Later on
        //        }
        //        finally
        //        {
        //            Connection.Close();
        //        }
        //        return dataTable;
        //    }

        public static bool FindLicenseByID(int ID, ref int ApplicationID
            , ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref string Notes,
            ref decimal PaidFees , ref bool IsActive , ref byte IssueReason , ref int 
            CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Licenses where LicenseID = @ID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

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

        public static bool FindLicenseByAppID(ref int ID, int ApplicationID
    , ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate,
    ref DateTime ExpirationDate, ref string Notes,
    ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int
    CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Licenses where ApplicationID = @ApplicationID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = (int)Reader["LicenseID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

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


        //public static bool FindPersonByLicenseID(int LicenseID, ref int ID, ref int ApplicationID
        //    , ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate,
        //    ref DateTime ExpirationDate,  ref string Notes,ref decimal PaidFees)
        //{
        //    bool isFound = false;
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string Query = "select * from Licenses where LicenseID = @LicenseID;";

        //    SqlCommand cmd = new SqlCommand(Query, Connection);
        //    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = cmd.ExecuteReader();

        //        if (Reader.Read())
        //        {
        //            isFound = true;

        //            ID = (int)Reader["LicenseID"];
        //            ApplicationID = (string)Reader["ApplicationID"];
        //            DriverID = (string)Reader["DriverID"];
        //            LicenseClassID = Reader["LicenseClassID"].ToString();
        //            IssueDate = (string)Reader["IssueDate"];
        //            ExpirationDate = (DateTime)Reader["ExpirationDate"];
        //            byte Int = (byte)Reader[""];
        //             = (en)Int;
        //            Notes = (string)Reader["Notes"];
        //            PaidFees = (string)Reader["PaidFees"];
        //             = Reader[""].ToString();
        //             = (int)Reader[""];
        //             = Reader[""].ToString();
        //        }
        //        Reader.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        isFound = false;
        //        //Enter it in Log Errors Later on
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return isFound;
        //}

        public static byte GetActiveLicensesNumber(int DriverID)
        {
            byte ActiveLicenses = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select count(*) from Licenses where DriverID = @DriverID" +
                " and isActive = 1;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                Connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(),out byte activeLicenses))
                {
                    ActiveLicenses = activeLicenses;
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
            return ActiveLicenses;
        }

        public static bool DoesLicenseExistByID(int LicenseID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found = 1 from Licenses where LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

    }
}
