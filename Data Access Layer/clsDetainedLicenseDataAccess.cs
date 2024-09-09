using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsDetainedLicenseDataAccess
    {

        public static int AddNewDetainedLicense(int LicenseID
    , DateTime DetainDate, decimal FineFees, int CreatedByUserID,
     bool IsReleased, DateTime ReleaseDate,
     int ReleasedByUserID, int ReleaseApplicationID)
        {

            int DetainID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into DetainedLicenses (LicenseID, DetainDate, 
FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID , ReleaseApplicationID) values (
@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,
@ReleaseApplicationID);
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate == DateTime.MinValue)
            {
                cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            }
            if(ReleasedByUserID == -1)
            {
                cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            if (ReleasedByUserID == -1)
            {
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    DetainID = ID;
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
            return DetainID;
        }


        public static bool UpdateDetainedLicense(int DetainID, int LicenseID,
             DateTime DetainDate, decimal FineFees, int CreatedByUserID,
             bool IsReleased, DateTime ReleaseDate,
             int ReleasedByUserID, int ReleaseApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update DetainedLicenses set LicenseID = @LicenseID,
DetainDate = @DetainDate, FineFees = @FineFees, 
CreatedByUserID = @CreatedByUserID,IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, 
ReleasedByUserID = @ReleasedByUserID , ReleaseApplicationID = @ReleaseApplicationID 
where DetainID = @DetainID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);



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

        public static DataTable GetDetainedLicensesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from DetainedLicenses;";

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

        public static bool FindDetainedLicenseByID(int ID, ref int LicenseID
            , ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime ReleaseDate,
            ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from DetainedLicenses where DetainID = @ID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    try { ReleaseDate = (DateTime)Reader["ReleaseDate"]; } catch { ReleaseDate = DateTime.MinValue; };
                    try { ReleasedByUserID = (int)Reader["ReleasedByUserID"]; } catch { ReleasedByUserID = -1; };
                    try { ReleaseApplicationID = (int)Reader["ReleaseApplicationID"]; } catch { ReleaseApplicationID = -1; };

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

        public static bool DoesDetainedLicenseExistByID(int DetainID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Found = 1 from DetainedLicenses where DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select IsDetained = 1 from DetainedLicenses where LicenseID = @LicenseID
and IsReleased = 0";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();

                object objID = cmd.ExecuteScalar();
                if (objID != null)
                {
                    isDetained = true;
                }

            }
            catch (Exception ex)
            {
                isDetained = false;
                Console.WriteLine(ex.Message);
                //Enter it in Log Errors Later on
            }
            finally
            {
                Connection.Close();
            }
            return isDetained;
        }


        public static bool FindDetainedLicenseByLicenseID(ref int ID, int LicenseID
    , ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
    ref bool IsReleased, ref DateTime ReleaseDate,
    ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from DetainedLicenses where LicenseID = @LicenseID " +
                "and IsReleased = 0;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    try { ReleaseDate = (DateTime)Reader["ReleaseDate"]; } catch { ReleaseDate = DateTime.MinValue; };
                    try { ReleasedByUserID = (int)Reader["ReleasedByUserID"]; } catch { ReleasedByUserID = -1; } ;
                    try { ReleaseApplicationID = (int)Reader["ReleaseApplicationID"]; } catch { ReleaseApplicationID = -1; } ;

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
