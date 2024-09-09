using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Access_Layer.clsPersonDataAccess;

namespace Data_Access_Layer
{
    public class clsApplicationDataAccess
    {

        public static int AddNewApplication( int ApplicantPersonID
            , DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus,
             DateTime LastStatusDate, decimal PaidFees,
             int CreatedByUserID)
        {

            int ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Applications (ApplicantPersonID, ApplicationDate, 
ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) values (
@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID );
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    ApplicationID = ID;
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
            return ApplicationID;
        }


        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID,
             DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus,
             DateTime LastStatusDate, decimal PaidFees,
             int CreatedByUserID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update Applications set ApplicantPersonID = @ApplicantPersonID,
ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, 
ApplicationStatus = @ApplicationStatus,LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, 
CreatedByUserID = @CreatedByUserID where ApplicationID = @ApplicationID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static DataTable GetApplicationsList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Applications;";

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

        public static bool FindApplicationByID(int ID, ref int ApplicantPersonID
            , ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus,
            ref DateTime LastStatusDate, ref decimal PaidFees,
            ref int CreatedByUserID )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Applications where ApplicationID = @ID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
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

        public static bool DeleteApplicationByID(int ApplicationID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from Applications where ApplicationID = @ApplicationID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

        public static bool CancelApplication(int ApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update Applications set ApplicationStatus = 3 , LastStatusDate = GetDate()
where ApplicationID = @ApplicationID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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


    }
}
