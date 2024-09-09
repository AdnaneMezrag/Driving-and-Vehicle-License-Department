using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsInternationalLicenseDataAccess
    {

        public static int AddNewInternationalLicense(int ApplicationID
            , int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
             DateTime ExpirationDate, bool IsActive,
             int CreatedByUserID)
        {

            int InternationalLicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update InternationalLicenses 
                               set IsActive=0
                               where DriverID=@DriverID;
insert into InternationalLicenses (ApplicationID, DriverID, 
IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) values (
@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID );
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    InternationalLicenseID = ID;
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
            return InternationalLicenseID;
        }


        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID,
             int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
             DateTime ExpirationDate, bool IsActive,
             int CreatedByUserID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update InternationalLicenses set ApplicationID = @ApplicationID,
DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, 
IssueDate = @IssueDate,ExpirationDate = @ExpirationDate, IsActive = @IsActive, 
CreatedByUserID = @CreatedByUserID where InternationalLicenseID = @InternationalLicenseID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static DataTable GetInternationalLicensesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from InternationalLicenses;";

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

        public static DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select InternationalLicenses.* from InternationalLicenses 
inner join Applications 
on applications.ApplicationID = InternationalLicenses.ApplicationID
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


        public static bool FindInternationalLicenseByID(int ID, ref int ApplicationID
            , ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref bool IsActive,
            ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from InternationalLicenses where InternationalLicenseID = @ID;";

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
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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


        public static bool DeleteInternationalLicenseByID(int InternationalLicenseID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
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

        public static bool FindLastInternationalLicenseByLicenseID(ref int ID, ref int ApplicationID
            , ref int DriverID, int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref bool IsActive,
            ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select top 1 * from InternationalLicenses where IssuedUsingLocalLicenseID 
= @IssuedUsingLocalLicenseID order by InternationalLicenseID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    ID = (int)Reader["InternationalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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


    }
}
