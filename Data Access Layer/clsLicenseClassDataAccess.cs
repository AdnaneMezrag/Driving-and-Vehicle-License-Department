using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class clsLicenseClassDataAccess
    {
        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
    byte MinimumAllowedAge , byte DefaultValidityLength , decimal ClassFees)
        {
            if (ClassName == "") { ClassName = null; }
            if (ClassDescription == "") { ClassDescription = null; }


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update LicenseClasses set ClassFees = @ClassFees, MinimumAllowedAge = 
@MinimumAllowedAge , DefaultValidityLength = @DefaultValidityLength , 
ClassName = @ClassName , ClassDescription = @ClassDescription
where LicenseClassID = @LicenseClassID;";


            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ClassFees", ClassFees);
            cmd.Parameters.AddWithValue("@ClassName", ClassName);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            cmd.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            cmd.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);


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

        public static DataTable GetLicenseClassesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from LicenseClasses;";

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

        public static bool FindLicenseClassByID(int LicenseClassID, ref string ClassName,
            ref string ClassDescription,ref byte MinimumAllowedAge, ref byte DefaultValidityLength , 
            ref decimal ClassFees
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from LicenseClasses where LicenseClassID = @LicenseClassID;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ClassFees = (decimal)Reader["ClassFees"];
                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
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
