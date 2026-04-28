using System.Configuration;
using System.Data.SqlClient;

namespace VehicleRentalApp.DAL
{
    public class DatabaseHelper
    {
        private static string connString =
            ConfigurationManager.ConnectionStrings["VehicleRentalDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}