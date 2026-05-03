using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using VehicleRentalApp.Models;
using System.Data;
using System.Runtime.CompilerServices;
using System;
using VehicleRentalApp.Models;

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
        public static bool verify_credentials(string email, string passkey, ref string result , ref Employee employee)
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
        public static Branch branch_details_from_employee(string email)
        {
            Branch branch = null;
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
                            Street_Number = Convert.ToInt32(reader["Street_Number"]),
                            Building_Number = Convert.ToInt32(reader["Building_Number"]),
                            Contact_Number = reader["Contact_Number"].ToString()
                        };
                    }
                }
            }

            return branch;
        }

        //will give you an array of reservations, if empty then no recent reservations
        public static ReservationHorse[] recent_reservations()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Recent_Reservations", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"] == DBNull.Value 
                                ? (DateTime?)null 
                                : Convert.ToDateTime(reader["Return_Date"]),

                            Pickup_Date = reader["Pickup_Date"] == DBNull.Value 
                                ? (DateTime?)null 
                                : Convert.ToDateTime(reader["Pickup_Date"])

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
        public static ReservationChonk Reservation_Details(int Reservation_ID, ref bool exist)
        {
            ReservationChonk reservation = null;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Reservation_details", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = Reservation_ID;



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        exist = true;
                        reservation = new ReservationChonk
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
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
                            Car_Type = reader["Car_Type"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Model_Year = Convert.ToInt32(reader["Model_Year"]),
                            Transmission = reader["Transmission"].ToString(),
                            Daily_Rental_Rate = Convert.ToDecimal(reader["Daily_Rental_Rate"]),
                            Payment_Method = reader["Payment_Method"].ToString(),
                            Payment_Date = Convert.ToDateTime(reader["Payment_Date"]),
                            Emp_ID = Convert.ToInt32(reader["Emp_ID"])


                        };

                        
                    }
                    else
                    {
                        exist= false;
                        return reservation;
                    }
                }
            }
        return reservation;
        }

        //if return is an empty array then no reservations found with this filter
        //all parameters are optional
        // week (1-53) and month (1-12) and year are integers
        public static ReservationHorse[] filter_reservation(int? day = null , int? week= null, int? month = null, int? year = null)
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
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
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                    
                }
            }
            return reservations.ToArray();
        }

        public static ReservationHorse[] filter_reservation_this_week()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_thisweekfilter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                    
                }
            }
            return reservations.ToArray();
        }

        public static ReservationHorse[] filter_reservation_today()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_todayfilter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                    
                }
            }
            return reservations.ToArray();
        }

        public static ReservationHorse[] filter_deadlines(int? day = null, int? week= null, int? month = null, int? year = null)
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Deadline_filter", connection))
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
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }
            }
            return reservations.ToArray();
            
        }

        public static ReservationHorse[] filter_deadlines_this_week()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Deadlines_thisweekfilter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }
            }
            return reservations.ToArray();
            
        }

        public static ReservationHorse[] filter_deadlines_today()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Deadlines_todayfilter", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }
            }
            return reservations.ToArray();
            
        }

        public static int total_cars_in_branch(int branchID)
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

        public static ReservationHorse[] planned_returns_today()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Todays_Planned_Returns", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                            {
                                Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                                Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                                Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                                Deadline = Convert.ToDateTime(reader["Deadline"]),
                                Reservation_Status = reader["Reservation_Status"].ToString(),
                                LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                                License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                                Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                                Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                            };

                        reservations.Add(reservation);
                    }
                    
                }

            }

            return reservations.ToArray();
        }

        public static Car[] Get_Available_Cars_In_Branch (int branchID)
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Available_Cars_In_Branch", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Car carss = new Car
                        {
                            License_Plate = reader["License_Plate"].ToString(),
                            Condition = reader["Condition"].ToString(),
                            No_seats = Convert.ToInt32(reader["No_seats"]),
                            Mileage = Convert.ToInt32(reader["Mileage"]),
                            Colour = reader["Colour"].ToString(),
                            Category_ID = Convert.ToInt32(reader["Category_ID"]),
                            Branch_ID = Convert.ToInt32(reader["Branch_ID"])

                        };

                        cars.Add(carss);
                    }
                    
                }


            }

            return cars.ToArray();
            
        }

        public static ReservationHorse[] Get_Overdue_Reservations()
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Overdue_Reservations", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }

            }

            return reservations.ToArray();
        }

        public static ReservationHorse[] Get_Reservations_By_Branch(int branchID)
        {
            List<ReservationHorse> reservations = new List<ReservationHorse>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Read_ByPickupBranchID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationHorse reservation = new ReservationHorse
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
                            LicenseNo = Convert.ToInt32(reader["LicenseNo"]),
                            License_Plate = reader["License_Plate"].ToString(),
                            Pickup_Branch_ID = reader["Pickup_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null, 
                            Return_Branch_ID = reader["Return_Branch_ID"]  != DBNull.Value ? Convert.ToInt32(reader["Pickup_Branch_ID"]) : (int?)null,
                            Return_Date = reader["Return_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Return_Date"]),
                            Pickup_Date = reader["Pickup_Date"].ToString() == "" ? (DateTime?)null : Convert.ToDateTime(reader["Pickup_Date"])

                        };

                        reservations.Add(reservation);
                    }
                }

            }

            return reservations.ToArray();
        }

        public static void return_car (int reservationID, int branchID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Status", SqlDbType.VarChar, 200));
                cmd.Parameters["@Reservation_Status"].Value = "Returned";
                cmd.Parameters.Add(new SqlParameter("@Return_Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Return_Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("@Return_Date", SqlDbType.DateTime));
                cmd.Parameters["@Return_Date"].Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }

            string licenseplate= "";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("license_plate_from_reservationID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        licenseplate= reader[0].ToString();
                    }
                }

            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Free";
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = licenseplate;

                cmd.ExecuteNonQuery();
                
            }
        }

        public static void pickup_car (int reservationID, int branchID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Status", SqlDbType.VarChar, 200));
                cmd.Parameters["@Reservation_Status"].Value = "Pickedup";
                cmd.Parameters.Add(new SqlParameter("@Pickup_Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Pickup_Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("@Pickup_Date", SqlDbType.DateTime));
                cmd.Parameters["@Pickup_Date"].Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }

            string licenseplate="";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("license_plate_from_reservationID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        licenseplate= reader[0].ToString();
                    }
                }

            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Reserved";
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = licenseplate;

                cmd.ExecuteNonQuery();
                
            }
        }

        public static void cancel_reservation (int reservationID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Delete", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;

                cmd.ExecuteNonQuery();
            }

            string licenseplate = "";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("license_plate_from_reservationID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        licenseplate= reader[0].ToString();
                    }
                }

            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Free";
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = licenseplate;

                cmd.ExecuteNonQuery();
                
            }
        }

        public static void add_car(Car car, Car_Category cat)
        {
            bool found = false;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("CarCategory_Exists", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Car_Type", SqlDbType.VarChar, 200));
                cmd.Parameters["@Car_Type"].Value = cat.Car_Type;
                cmd.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar, 200));
                cmd.Parameters["@Make"].Value = cat.Make;
                cmd.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 200));
                cmd.Parameters["@Model"].Value = cat.Model;
                cmd.Parameters.Add(new SqlParameter("@Model_Year", SqlDbType.Int));
                cmd.Parameters["@Model_Year"].Value = cat.Model_Year;
                cmd.Parameters.Add(new SqlParameter("@Transmission", SqlDbType.VarChar, 200));
                cmd.Parameters["@Transmission"].Value = cat.Transmission;
                cmd.Parameters.Add(new SqlParameter("@Daily_Rental_Rate", SqlDbType.Decimal));
                cmd.Parameters["@Daily_Rental_Rate"].Value = cat.Daily_Rental_Rate;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                }
            }

            if (!found)
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("CarCategory_Create", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Car_Type", SqlDbType.VarChar, 200));
                    cmd.Parameters["@Car_Type"].Value = cat.Car_Type;
                    cmd.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar, 200));
                    cmd.Parameters["@Make"].Value = cat.Make;
                    cmd.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 200));
                    cmd.Parameters["@Model"].Value = cat.Model;
                    cmd.Parameters.Add(new SqlParameter("@Model_Year", SqlDbType.Int));
                    cmd.Parameters["@Model_Year"].Value = cat.Model_Year;
                    cmd.Parameters.Add(new SqlParameter("@Transmission", SqlDbType.VarChar, 200));
                    cmd.Parameters["@Transmission"].Value = cat.Transmission;
                    cmd.Parameters.Add(new SqlParameter("@Daily_Rental_Rate", SqlDbType.Decimal));
                    cmd.Parameters["@Daily_Rental_Rate"].Value = cat.Daily_Rental_Rate;

                    cmd.ExecuteNonQuery();

                }

            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("CarCategory_from_catID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Car_Type", SqlDbType.VarChar, 200));
                cmd.Parameters["@Car_Type"].Value = cat.Car_Type;
                cmd.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar, 200));
                cmd.Parameters["@Make"].Value = cat.Make;
                cmd.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 200));
                cmd.Parameters["@Model"].Value = cat.Model;
                cmd.Parameters.Add(new SqlParameter("@Model_Year", SqlDbType.Int));
                cmd.Parameters["@Model_Year"].Value = cat.Model_Year;
                cmd.Parameters.Add(new SqlParameter("@Transmission", SqlDbType.VarChar, 200));
                cmd.Parameters["@Transmission"].Value = cat.Transmission;
                cmd.Parameters.Add(new SqlParameter("@Daily_Rental_Rate", SqlDbType.Decimal));
                cmd.Parameters["@Daily_Rental_Rate"].Value = cat.Daily_Rental_Rate;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cat.Category_ID = Convert.ToInt32(reader["Category_ID"]);
                    }
                }
            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Create", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = car.License_Plate;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = car.Condition;
                cmd.Parameters.Add(new SqlParameter("@No_seats", SqlDbType.Int));
                cmd.Parameters["@No_seats"].Value = car.No_seats;
                cmd.Parameters.Add(new SqlParameter("@Mileage", SqlDbType.Int));
                cmd.Parameters["@Mileage"].Value = car.Mileage;
                cmd.Parameters.Add(new SqlParameter("@Colour", SqlDbType.VarChar, 200));
                cmd.Parameters["@Colour"].Value = car.Colour;
                cmd.Parameters.Add(new SqlParameter("@Category_ID", SqlDbType.Int));
                cmd.Parameters["@Category_ID"].Value = cat.Category_ID;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = car.Branch_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public static void delete_car(string licensePlate)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Delete", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = licensePlate;

                cmd.ExecuteNonQuery();
            }
        }
        public static void add_payment(Payment payment, int employeeID, int clientID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Payment_Create", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Payment_Method", SqlDbType.VarChar, 200));
                cmd.Parameters["@Payment_Method"].Value = payment.Payment_Method;
                cmd.Parameters.Add(new SqlParameter("@Payment_Date", SqlDbType.DateTime));
                cmd.Parameters["@Payment_Date"].Value = payment.Payment_Date;
                cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
                cmd.Parameters["@Emp_ID"].Value = employeeID;
                cmd.Parameters.Add(new SqlParameter("@Client_ID", SqlDbType.Int));
                cmd.Parameters["@Client_ID"].Value = clientID;

                cmd.ExecuteNonQuery();
            }
        }

        public static void add_reservation(ReservationHorse reservation, int paymentID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Create", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Payment_ID", SqlDbType.Int));
                cmd.Parameters["@Payment_ID"].Value = paymentID;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Date", SqlDbType.DateTime));
                cmd.Parameters["@Reservation_Date"].Value = reservation.Reservation_Date;
                cmd.Parameters.Add(new SqlParameter("@Deadline", SqlDbType.DateTime));
                cmd.Parameters["@Deadline"].Value = reservation.Deadline;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Status", SqlDbType.VarChar, 200));
                cmd.Parameters["@Reservation_Status"].Value = "Pending";
                cmd.Parameters.Add(new SqlParameter("@LicenseNo", SqlDbType.Int));
                cmd.Parameters["@LicenseNo"].Value = reservation.LicenseNo;
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = reservation.License_Plate;

                cmd.ExecuteNonQuery();
            }
        }

        public static void hire_employee(Employee employee, int supID )
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Employee_Create", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar, 200));
                cmd.Parameters["@First_Name"].Value = employee.First_Name;
                cmd.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.VarChar, 200));
                cmd.Parameters["@Last_Name"].Value = employee.Last_Name;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters["@Email"].Value = employee.Email;
                cmd.Parameters.Add(new SqlParameter("@Position", SqlDbType.VarChar, 200));
                cmd.Parameters["@Position"].Value = "Employee";
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = employee.Branch_ID;
                cmd.Parameters.Add(new SqlParameter("@SuperEmpID", SqlDbType.Int));
                cmd.Parameters["@SuperEmpID"].Value = supID;
                cmd.Parameters.Add(new SqlParameter("@Passkey", SqlDbType.VarChar, 200));
                cmd.Parameters["@Passkey"].Value = employee.Passkey;


                cmd.ExecuteNonQuery();
            }
        }

        public static void fire_employee(int employeeID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Employee_Delete", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
                cmd.Parameters["@Emp_ID"].Value = employeeID;

                cmd.ExecuteNonQuery();
            }
        }

        public static void display_client(int clientID, out Client client, out bool exist,string First_Name= null, string Last_Name= null, String email= null, string phone= null)
        {
            client = null;
            exist = false;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Client_Read_Licenseno", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Driver_License_Number", SqlDbType.Int));
                cmd.Parameters["@Driver_License_Number"].Value = clientID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        exist = true;
                        client = new Client
                        {
                            Driver_License_Number = Convert.ToInt32(reader["Driver_License_Number"]),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString()

                        };

                        
                    }
                    else
                    {
                        exist= false;
                        using (SqlConnection connection2 = DatabaseHelper.GetConnection())
                        using (SqlCommand cmd2 = new SqlCommand("Client_Create", connection2))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar, 200));
                            cmd.Parameters["@First_Name"].Value = First_Name;
                            cmd.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Last_Name"].Value = Last_Name;
                            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Email"].Value = email;
                            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Phone"].Value = phone;
                            cmd.Parameters.Add(new SqlParameter("@Driver_License_Number", SqlDbType.Int));
                            cmd.Parameters["@Driver_License_Number"].Value = clientID;

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void edit_employee(int employeeID, string firstName=null, string lastName=null, string email=null, string position=null, int? branchID=null, int? superEmpID=null, string passkey=null)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Employee_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
                cmd.Parameters["@Emp_ID"].Value = employeeID;
                cmd.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar, 200));
                cmd.Parameters["@First_Name"].Value = firstName;
                cmd.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.VarChar, 200));
                cmd.Parameters["@Last_Name"].Value = lastName;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                cmd.Parameters["@Email"].Value = email;
                cmd.Parameters.Add(new SqlParameter("@Position", SqlDbType.VarChar, 200));
                cmd.Parameters["@Position"].Value = position;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("@SuperEmpID", SqlDbType.Int));
                cmd.Parameters["@SuperEmpID"].Value = superEmpID;
                cmd.Parameters.Add(new SqlParameter("@Passkey", SqlDbType.VarChar, 200));
                cmd.Parameters["@Passkey"].Value = passkey;

                cmd.ExecuteNonQuery();
            }
        }
        public static int count_available_cars_in_branch(int branchID)
        {
            int result = 0;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("count_available_cars_in_branch", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = Convert.ToInt32(reader[0]);
                    }
                }
            }

            return result;
        }

        public static void update_car(string licensePlate, string condition, int mileage)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@License_Plate", SqlDbType.VarChar, 200));
                cmd.Parameters["@License_Plate"].Value = licensePlate;
                cmd.Parameters.Add(new SqlParameter("@Colour", SqlDbType.VarChar, 200));
                cmd.Parameters["@Colour"].Value = condition;
                cmd.Parameters.Add(new SqlParameter("@Mileage", SqlDbType.Int));
                cmd.Parameters["@Mileage"].Value = mileage;

                cmd.ExecuteNonQuery();
            }
        }

        public static double branch_revenue(int branchID)
        {
            double revenue = 0;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("branch_revenue", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        revenue = Convert.ToDouble(reader[0]);
                    }
                }
            }

            return revenue;
        }
    
        public static Employee[] view_all_employees(int branchID)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("all_employees", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            Emp_ID = Convert.ToInt32(reader["Emp_ID"]),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Position = reader["Position"].ToString(),
                            Branch_ID = Convert.ToInt32(reader["Branch_ID"]),
                            SuperEmpID = reader["SuperEmpID"] != DBNull.Value ? Convert.ToInt32(reader["SuperEmpID"]) : 0,
                            Passkey = reader["Passkey"].ToString()
                        };
                        employees.Add(emp);
                    }
                }
            }

            return employees.ToArray();
        }
    
        public static Car[] filter_Cars_In_Branch (int branchID, string reserveOrFree, bool picanto, bool suv, bool coupe, bool sedan, bool hatchback){
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("car_filter_chonk", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("@freereservedall", SqlDbType.VarChar, 200));
                cmd.Parameters["@freereservedall"].Value = reserveOrFree;
                cmd.Parameters.Add(new SqlParameter("@Picanto", SqlDbType.Bit));
                cmd.Parameters["@Picanto"].Value = picanto;
                cmd.Parameters.Add(new SqlParameter("@SUV", SqlDbType.Bit));
                cmd.Parameters["@SUV"].Value = suv;
                cmd.Parameters.Add(new SqlParameter("@Coupe", SqlDbType.Bit));
                cmd.Parameters["@Coupe"].Value = coupe;
                cmd.Parameters.Add(new SqlParameter("@Sedan", SqlDbType.Bit));
                cmd.Parameters["@Sedan"].Value = sedan;
                cmd.Parameters.Add(new SqlParameter("@Hatchback", SqlDbType.Bit));
                cmd.Parameters["@Hatchback"].Value = hatchback;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            License_Plate = reader["License_Plate"].ToString(),
                            Condition = reader["Condition"].ToString(),
                            No_seats = Convert.ToInt32(reader["No_seats"]),
                            Mileage = Convert.ToInt32(reader["Mileage"]),
                            Colour = reader["Colour"].ToString(),
                            Branch_ID = Convert.ToInt32(reader["Branch_ID"]),
                            Category_ID = Convert.ToInt32(reader["Category_ID"])
                        };
                        cars.Add(car);
                    }
                }

            }
            return cars.ToArray();
        }
        
        public static Car_Category cat_fromID(int catID)
        {
            Car_Category carcat = null;
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Category_Read_CategoryID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Category_ID", SqlDbType.Int));
                cmd.Parameters["@Category_ID"].Value = catID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        carcat = new Car_Category
                        {
                            Category_ID = Convert.ToInt32(reader["Category_ID"]),
                            Car_Type = reader["Car_Type"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Model_Year = Convert.ToInt32(reader["Model_Year"]),
                            Transmission = reader["Transmission"].ToString(),
                            Daily_Rental_Rate = Convert.ToDecimal(reader["Daily_Rental_Rate"])
                        };
                    }
                }
            }
            return carcat;
        }

    }    

}