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
    public class clsCountryDataAccess
    {
        public static DataTable GetCountriesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Countries;";

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

        public static bool FindCountryByID(int CountryID , ref string CountryName)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Countries where CountryID = @CountryID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    CountryName = (string)Reader["CountryName"];
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
