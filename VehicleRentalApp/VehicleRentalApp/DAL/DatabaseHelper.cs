using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;

namespace VehicleRentalApp.DAL
{
    public class DatabaseHelper
    {
        private static readonly string connString =
            ConfigurationManager.ConnectionStrings["VehicleRentalDB"]?.ConnectionString
            ?? throw new InvalidOperationException("Connection string 'VehicleRentalDB' is missing from App.config.");

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            return connection;
        }
    }
    public class VHSAUTOMOTIVE
    {
        public DATATYPE FUNCTIONANME(PARAMETERS)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("PROCEDURENAMEFROMSQL", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@PARAMETERNAME",  SqlDbType.PARAMETERDATATYPE));
                cmd.Parameters["@PARAMETER"].Value  = VALUE;

                cmd.EXECUTEWHATEVER()

            }
        }
        
    }
}