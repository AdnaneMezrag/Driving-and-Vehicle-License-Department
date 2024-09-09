using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsTestTypeDataAccess
    {
        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle,string TestTypeDescription,
            decimal TestTypeFees)
        {
            if (TestTypeTitle == "") { TestTypeTitle = null; }
            if (TestTypeDescription == "") { TestTypeDescription = null; }


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update TestTypes set TestTypeFees = @TestTypeFees, 
TestTypeTitle = @TestTypeTitle , TestTypeDescription = @TestTypeDescription
where TestTypeID = @TestTypeID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);


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

        public static DataTable GetTestTypesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from TestTypes;";

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

        public static bool FindTestTypeByID(int TestTypeID, ref string TestTypeTitle, 
            ref string TestTypeDescription, ref decimal TestTypeFees
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from TestTypes where TestTypeID = @TestTypeID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    TestTypeFees = (decimal)Reader["TestTypeFees"];
                    TestTypeTitle = (string)Reader["TestTypeTitle"];
                    TestTypeDescription = (string)Reader["TestTypeDescription"];


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
