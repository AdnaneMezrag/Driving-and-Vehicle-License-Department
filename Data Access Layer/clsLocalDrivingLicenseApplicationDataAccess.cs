using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
    public class clsLocalDrivingLicenseApplicationDataAccess
    {
        public static int AddNewApplication(int ApplicationID, int LicenseClassID)
        {

            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into LocalDrivingLicenseApplications (ApplicationID, 
LicenseClassID) values (@ApplicationID,@LicenseClassID);
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    LocalDrivingLicenseApplicationID = ID;
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
            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update LocalDrivingLicenseApplications set LicenseClassID = @LicenseClassID, ApplicationID = @ApplicationID
 where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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

        public static DataTable GetLocalDrivingLicenseApplicationsList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from LocalDrivingLicenseApplications;";

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

        public static bool FindLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID,
            ref int LicenseClassID
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ApplicationID = (int)Reader["ApplicationID"];


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

        public static bool CanApplicationBeAdded(int LicenseClassID , int ApplicantPersonID)
        {
            bool canBeAdded = true;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found = 1 from LocalDrivingLicenseApplications 
where LicenseClassID = @LicenseClassID and ApplicationID in
(select Applications.ApplicationID from Applications 
where ApplicantPersonID = @ApplicantPersonID and (ApplicationStatus = 1 or ApplicationStatus = 2));";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null)
                {
                    canBeAdded = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                canBeAdded = false;
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return canBeAdded;
        }

        public static short GetPassedTestsNumber(int LDLAppID)
        {

            short PassedTests = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query =  @"select count(*)from TestAppointments inner join Tests 
                            on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                            and TestResult = 1;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && short.TryParse(objID.ToString(), out short passedtests))
                {
                    PassedTests = passedtests;
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
            return PassedTests;
        }

        public static bool DeleteLDLAppByID(int LDLAppID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from LocalDrivingLicenseApplications where 
LocalDrivingLicenseApplicationID = @LDLAppID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);
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


        //        public static bool CanAppointmentBeAdded(int LDLAppID)
        //        {
        //            bool canBeAdded = false;
        //            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //            string Query = @"select Found = 1 from(
        //select top 1 * from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = 
        //@LocalDrivingLicenseApplicationID
        //order by TestAppointmentID desc) as T where T.IsLocked = 1;";

        //            SqlCommand cmd = new SqlCommand(Query, Connection);
        //            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

        //            try
        //            {
        //                Connection.Open();
        //                object objID = cmd.ExecuteScalar();
        //                if (objID != null)
        //                {
        //                    canBeAdded = true;
        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                canBeAdded = false;
        //                //Enter it in Log Errors Later on
        //            }
        //            finally
        //            {
        //                Connection.Close();
        //            }
        //            return canBeAdded;
        //        }

        public static int GetLicenseIDByLDLAppID(int LDLAppID)
        {

            short LicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select licenses.licenseid from licenses 
where ApplicationID in (
select ApplicationID from LocalDrivingLicenseApplications 
where LocalDrivingLicenseApplicationID = @LDLAppID);";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && short.TryParse(objID.ToString(), out short licenseID))
                {
                    LicenseID = licenseID;
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
    }
}
