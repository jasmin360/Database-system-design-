using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using VehicleRentalApp.Models;
using System.IO.Pipelines;

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

        //first 2 parameters contain the email and passkey actually used to sign in and the third parameter is an array passed by refrence 
        //i will output the employee details in it 
        //the function itself returns a boolena you can use to check directly if this human is signing in correctly
        //a string passed by raference that will contain the ouput message
        public bool verify_credentials(string email, string passkey, ref string result , ref Employee employee)
        {
            bool checker=false;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Employee_Read_Email", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters["@Email"].Value = email;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        string storedPasskey = reader["Passkey"].ToString();

                        if (storedPasskey == passkey)
                        {
                            employee = new Employee
                            {
                                Emp_ID = Convert.ToInt32(reader["Emp_ID"]),
                                Passkey = storedPasskey,
                                Email = reader["Email"].ToString(),
                                Position = reader["Position"].ToString(),
                                First_Name = reader["First_Name"].ToString(),
                                Last_Name = reader["Last_Name"].ToString(),
                                Branch_ID = Convert.ToInt32(reader["Branch_ID"]),
                                SuperEmpID = reader.IsDBNull(reader.GetOrdinal("SuperEmpID")) ? (int?)null : Convert.ToInt32(reader["SuperEmpID"])
                            };
                            checker= true;
                            result = "Login successful.";
                        }
                        else
                        {
                            result = "Invalid passkey.";
                        }
                    }
                    else
                    {
                        result = "Email not found.";
                    }
                }
            }

            return checker;
        }

        // parameter is employee email output is object of type branch containing branch details
        public Branch branch_details_from_employee(string email)
        {
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
                        branch = new Branch
                        {
                            Branch_ID = Convert.ToInt32(reader["Branch_ID"]),
                            City = reader["City"].ToString(),
                            Street_Number = reader["Street_Number"].ToString(),
                            Building_Number = reader["Building_Number"].ToString(),
                            Contact_Number = reader["Contact_Number"].ToString()
                        };
                    }
                }
            }

            return branch;
        }

        //will give you an array of reservations, if empty then no recent reservations
        public Reservation[] recent_reservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Recent_Reservations", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch"].ToString(),
                            Return_Branch_ID = reader["Return_Branch"].ToString(),
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }
            }
            return reservations.ToArray();
        }

        //will give you a chonky reservation with its detailsu
        // takes reservatioin id as parameter
        // also takes a boolean by ref and that boolean is true if reservation is found otherwise it is false
        public ReservationChonk Reservation_Details(int Reservation_ID, ref bool exist)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Reservation_details", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                ReservationChonk reservation = new ReservationChonk();

                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        exist = true;
                        //lasfd jk hfajkdf halkjhds fkj das screams sobs cries
                        ReservationChonk reservation = new ReservationChonk
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch"].ToString(),
                            Return_Branch_ID = reader["Return_Branch"].ToString(),
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"]),
                            Driver_License_Number = Convert.ToInt32(reader["Driver_License_Number"]),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            License_Plate = reader["License_Plate"].ToString(),
                            Condition = reader["Condition"].ToString(),
                            No_seats = Convert.ToInt32(reader["No_seats"]),
                            Mileage = Convert.ToInt32(reader["Mileage"]),
                            Colour = reader["Colour"].ToString(),
                            Category_ID = Convert.ToInt32(reader["Category_ID"]),
                            Branch_ID = Convert.ToInt32(reader["Branch_ID"]),


                        };

                        
                    }
                    else
                    {
                        exist= false;
                        return;
                    }
                }
            }
        return reservation;
        }

        //if return is an empty array then no reservations found with this filter
        //all parameters are optional
        // week (1-53) and month (1-12) and year are integers
        public Reservation[] filter_reservation(DateTime day= null, int week= null, int month = null, int year = null)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_filter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.VarChar, 200));
                cmd.Parameters["@Day"].Value = day;
                cmd.Parameters.Add(new SqlParameter("@Week", SqlDbType.Int));
                cmd.Parameters["@Week"].Value = week.HasValue ? (object)week.Value : DBNull.Value;
                cmd.Parameters.Add(new SqlParameter("@Month", SqlDbType.Int));
                cmd.Parameters["@Month"].Value = month.HasValue ? (object)month.Value : DBNull.Value;
                cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
                cmd.Parameters["@Year"].Value = year.HasValue ? (object)year.Value : DBNull.Value;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch"].ToString(),
                            Return_Branch_ID = reader["Return_Branch"].ToString(),
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                    
                }
            }
            return reservations.ToArray();
        }

        public Reservation[] filter_deadlines(DateTime day= null, int week= null, int month = null, int year = null)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_filter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.VarChar, 200));
                cmd.Parameters["@Day"].Value = day;
                cmd.Parameters.Add(new SqlParameter("@Week", SqlDbType.Int));
                cmd.Parameters["@Week"].Value = week.HasValue ? (object)week.Value : DBNull.Value;
                cmd.Parameters.Add(new SqlParameter("@Month", SqlDbType.Int));
                cmd.Parameters["@Month"].Value = month.HasValue ? (object)month.Value : DBNull.Value;
                cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int));
                cmd.Parameters["@Year"].Value = year.HasValue ? (object)year.Value : DBNull.Value;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   while (reader.Read())
                    {
                        Reservation reservation = new Reservation
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch"].ToString(),
                            Return_Branch_ID = reader["Return_Branch"].ToString(),
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }
            }
            return reservations.ToArray();
            
        }

        public int total_cars_in_branch(int branchID)
        {
            int result=0;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Total_Cars_In_Branch", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                using (SqlDataReader reader = cmd.ExecuteReader()){
                    if (reader.Read())
                    {
                        result = Convert.ToInt32(reader[0]);
            
                    }
                }
            }

            return result;
    
        }
    }
        
}


