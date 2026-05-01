using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using VehicleRentalApp.Models;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;

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
                        ReservationChonk reservation = new ReservationChonk
                        {
                            Reservation_ID = Convert.ToInt32(reader["Reservation_ID"]),
                            Payment_ID = Convert.ToInt32(reader["Payment_ID"]),
                            Reservation_Date = Convert.ToDateTime(reader["Reservation_Date"]),
                            Deadline = Convert.ToDateTime(reader["Deadline"]),
                            Reservation_Status = reader["Reservation_Status"].ToString(),
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
                            Car_Type = reader["Car_Type"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Model_Year = Convert.ToInt32(reader["Model_Year"]),
                            Transmission = reader["Transmission_Type"].ToString(),
                            Daily_Rental_Rate = Convert.ToDecimal(reader["Daily_Rental_Rate"]),
                            Payment_Method = reader["Payment_Method"].ToString(),
                            Payment_Date = Convert.ToDateTime(reader["Payment_Date"]),
                            Emp_ID = Convert.ToInt32(reader["Emp_ID"])


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

        public Reservation[] planned_returns_today(int branchID)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Todays_Planned_Returns", connection))
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

            return reservations.ToArray();
        }

        public Car[] Get_Available_Cars_In_Branch (int branchID)
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Available_Cars_In_Branch", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

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

            return cars.ToArray();
            
        }

        public Reservation[] Get_Overdue_Reservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Get_Overdue_Reservations", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

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

            return reservations.ToArray();
        }


        public Reservation[] Get_Reservations_By_Branch(int branchID)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Read_ByPickupBranchID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

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

            return reservations.ToArray();
        }

        public void return_car (int reservationID, int branchID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Status", SqlDbType.VarChar, 200));
                cmd.Parameters["@Reservation_Status"].Value = "Returned";
                cmd.Parameters.Add(new SqlParameter("Return_Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Return_Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("Return_Date", SqlDbType.DateTime));
                cmd.Parameters["@Return_Date"].Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Free";
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Branch_ID"].Value = branchID;

                cmd.ExecuteNonQuery();
                
            }
        }

        public void pickup_car (int reservationID, int branchID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;
                cmd.Parameters.Add(new SqlParameter("@Reservation_Status", SqlDbType.VarChar, 200));
                cmd.Parameters["@Reservation_Status"].Value = "Pickedup";
                cmd.Parameters.Add(new SqlParameter("Pickup_Branch_ID", SqlDbType.Int));
                cmd.Parameters["@Pickup_Branch_ID"].Value = branchID;
                cmd.Parameters.Add(new SqlParameter("Pickup_Date", SqlDbType.DateTime));
                cmd.Parameters["@Pickup_Date"].Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Reserved";

                cmd.ExecuteNonQuery();
                
            }
        }

        public void cancel_reservation (int reservationID)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Reservation_Delete", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Reservation_ID", SqlDbType.Int));
                cmd.Parameters["@Reservation_ID"].Value = reservationID;

                cmd.ExecuteNonQuery();
            }

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Car_Update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Condition", SqlDbType.VarChar, 200));
                cmd.Parameters["@Condition"].Value = "Free";

                cmd.ExecuteNonQuery();
                
            }
        }

        public void add_car(Car car, Car_Category cat)
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

                    using (SqlDataReader reader = cmd.ExecuteReader())                    {
                        if (reader.Read())
                        {
                            cat.Category_ID = Convert.ToInt32(reader["Category_ID"]);
                        }
                    }

                }
            }
            else
            {
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

        public void delete_car(string licensePlate)
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
        public void add_payment(Payment payment, int employeeID, int clientID, decimal amount)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("Payment_Create", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Payment_Method", SqlDbType.VarChar, 200));
                cmd.Parameters["@Payment_Method"].Value = payment.Payment_Method;
                cmd.Parameters.Add(new SqlParameter("@Payment_Date", SqlDbType.DateTime));
                cmd.Parameters["@Payment_Date"].Value = payment.Payment_Date;
                cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal));
                cmd.Parameters["@Amount"].Value = amount;
                cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
                cmd.Parameters["@Emp_ID"].Value = employeeID;
                cmd.Parameters.Add(new SqlParameter("@Client_ID", SqlDbType.Int));
                cmd.Parameters["@Client_ID"].Value = clientID;

                cmd.ExecuteNonQuery();
            }
        }

        public void add_reservation(Reservation reservation, int paymentID)
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


        public void hire_employee(Employee employee, int supID )
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

        public void fire_employee(int employeeID)
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

        public void display_client(int clientID, out Client client, out bool exist)
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
                            Client_ID = Convert.ToInt32(reader["Client_ID"]),
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
                        using (SqlConnection connection = DatabaseHelper.GetConnection())
                        using (SqlCommand cmd = new SqlCommand("Client_Create", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar, 200));
                            cmd.Parameters["@First_Name"].Value = client.First_Name;
                            cmd.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Last_Name"].Value = client.Last_Name;
                            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Email"].Value = client.Email;
                            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 200));
                            cmd.Parameters["@Phone"].Value = client.Phone;
                            cmd.Parameters.Add(new SqlParameter("@Driver_License_Number", SqlDbType.Int));
                            cmd.Parameters["@Driver_License_Number"].Value = client.Driver_License_Number;

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void edit_employee(int employeeID, string firstName=null, string lastName=null, string email=null, string position=null, int branchID=null, int superEmpID=null, string passkey=null)
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

        public int count_available_cars_in_branch(int branchID)
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

    }

        
}


