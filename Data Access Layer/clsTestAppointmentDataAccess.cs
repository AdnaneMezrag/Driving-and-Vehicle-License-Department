using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Data_Access_Layer
{
    public class clsTestAppointmentDataAccess
    {
        public static int AddNewTestAppointment(int TestTypeID
            , int LDLAppID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, 
            bool IsLocked,int RetakeTestApplicationID)
        {

            int TestAppointmentID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, 
AppointmentDate,PaidFees,  CreatedByUserID, IsLocked,RetakeTestApplicationID) values (
@TestTypeID,@LDLAppID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID );
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (RetakeTestApplicationID != -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }

            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    TestAppointmentID = ID;
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
            return TestAppointmentID;
        }


        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID,
             int LDLAppID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID,
             bool IsLocked,int RetakeTestApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update TestAppointments set TestTypeID = @TestTypeID,
LocalDrivingLicenseApplicationID = @LDLAppID, AppointmentDate = @AppointmentDate, 
IsLocked = @IsLocked, PaidFees = @PaidFees, 
CreatedByUserID = @CreatedByUserID , RetakeTestApplicationID = @RetakeTestApplicationID
where TestAppointmentID = @TestAppointmentID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if(RetakeTestApplicationID != -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }



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

        public static DataTable GetTestAppointmentsList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from TestAppointments;";

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

        public static bool FindTestAppointmentByID(int ID, ref int TestTypeID
            , ref int LDLAppID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID,
            ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from TestAppointments where TestAppointmentID = @ID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    TestTypeID = (int)Reader["TestTypeID"];
                    LDLAppID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    IsLocked = (bool)Reader["IsLocked"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    try { RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"]; }
                    catch { RetakeTestApplicationID = -1; };
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


        public static bool DeleteTestAppointmentByID(int TestAppointmentID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from TestAppointments where TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        public static bool GetLastTestAppointmentByLDLAppID(int LDLAppID ,ref int TestAppointmentID, 
            ref int TestTypeID
            , ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID,
            ref bool IsLocked , ref int RetakeTestApplicationID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select top 1 *from TestAppointments where 
LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID 
order by TestAppointmentID desc;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestTypeID = (int)Reader["TestTypeID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    IsLocked = (bool)Reader["IsLocked"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    try { RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"]; }
                    catch { RetakeTestApplicationID = -1; };

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

        public static int GetTrials(int LDLAppID , int TestTypeID)
        {

            int Trials = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select count(*) from testappointments where 
LocalDrivingLicenseApplicationID = @LDLAppID
and TestTypeID = @TestTypeID and IsLocked = 1;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int trials))
                {
                    Trials = trials;
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
            return Trials;
        }

        public static DataTable GetTestAppointmentsListByLDLAppIDAndTestType(int LDLAppID , int TestTypeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from TestAppointments where LocalDrivingLicenseApplicationID = " +
                "@LDLAppID and TestTypeID = @TestTypeID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
    }
}
