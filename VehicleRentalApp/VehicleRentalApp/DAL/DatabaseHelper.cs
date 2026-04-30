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
     public string employee_email(string email)
        {
            string result = "";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Employee_Read_Email", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters["@Email"].Value = email;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader["Email"].ToString();
                    }
                }
            }

            return result;
        }

        public string[] branch_details_from_employee(string email)
        {
            string[] result = new string[0];

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Branch_By_Employee_Email", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters["@Email"].Value = email;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new string[]
                        {
                            reader["Branch_ID"].ToString(),
                            reader["City"].ToString(),
                            reader["Street_Number"].ToString(),
                            reader["Building_Number"].ToString(),
                            reader["Contact_Number"].ToString()
                        };
                    }
                }
            }

            return result;
        }

        public string[] getreservationdetails(int reservationId)
        {
            string[] result = new string[0];

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Reservation_details", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new string[reader.FieldCount];

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                           if (reader.IsDBNull(i))
                            {
                                result[i] = "";
                            }
                            else
                            {
                                result[i] = reader[i].ToString();
                            }
                        }
                    }
                }
            }

            return result;
        }
    

    public int total_cars_in_branch(int branchId)
    {
    int result = 0;

    using (SqlConnection connection = DatabaseHelper.GetConnection())
    using (SqlCommand cmd = new SqlCommand("Get_Total_Cars_In_Branch", connection))
    {
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
        cmd.Parameters["@Branch_ID"].Value = branchId;

        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            if (reader.Read())
            {
                result = Convert.ToInt32(reader["Total_Cars"]);
            }
        }
    }

    return result;
        }
    }
}
