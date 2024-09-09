using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsApplicationTypeDataAccess
    {
        public static bool UpdateApplicationType(int ApplicationTypeID,  string ApplicationTypeTitle , decimal ApplicationFees)
        {
            if (ApplicationTypeTitle == "") { ApplicationTypeTitle = null; }

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update ApplicationTypes set ApplicationFees = @ApplicationFees, ApplicationTypeTitle = @ApplicationTypeTitle
 where ApplicationTypeID = @ApplicationTypeID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


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

        public static DataTable GetApplicationsTypesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from ApplicationTypes;";

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

        public static bool FindApplicationTypeByID(int ApplicationTypeID, ref string ApplicationTypeTitle,
            ref decimal ApplicationFees
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ApplicationFees = (decimal)Reader["ApplicationFees"];
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];


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
