using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsDriverDataAccess
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Drivers ( PersonID, CreatedByUserID, CreatedDate)
values ( @PersonID,@CreatedByUserID,@CreatedDate);
select scope_identity() as ID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                Connection.Open();
                object objID = cmd.ExecuteScalar();
                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                {
                    DriverID = ID;
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
            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByDriverID, DateTime CreatedDate)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update Drivers set PersonID = @PersonID, CreatedByDriverID = @CreatedByDriverID,
CreatedDate = @CreatedDate where DriverID = @DriverID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByDriverID", CreatedByDriverID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);


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

        public static DataTable GetDriversList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Drivers;";

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

        public static bool FindDriverByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID
    , ref DateTime CreatedDate)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Drivers where DriverID = @DriverID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];

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

        public static bool DeleteDriverByDriverID(int DriverID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"delete from Drivers where DriverID = @DriverID";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

        public static bool FindDriverByPersonID(ref int DriverID, int PersonID, ref int CreatedByUserID
, ref DateTime CreatedDate)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Drivers where PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    DriverID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];

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
