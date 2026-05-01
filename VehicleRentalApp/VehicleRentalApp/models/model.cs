namespace VehicleRentalApp.Models
{
    public class Client
    {
        public int    Driver_License_Number { get; set; }
        public string First_Name            { get; set; }
        public string Last_Name             { get; set; }
        public string Email                 { get; set; }
        public string Phone                 { get; set; }
    }

    public class Branch
    {
        public int     Branch_ID        { get; set; }
        public string? City             { get; set; }
        public int?    Street_Number    { get; set; }
        public int?    Building_Number  { get; set; }
        public string? Contact_Number   { get; set; }
    }

    public class Car_Category
    {
        public int     Category_ID      { get; set; }
        public string  Car_Type         { get; set; }
        public string  Make             { get; set; }
        public string  Model            { get; set; }
        public int     Model_Year       { get; set; }
        public string  Transmission     { get; set; }
        public decimal Daily_Rental_Rate { get; set; }
    }

    public class Car
    {
        public string License_Plate { get; set; }
        public string Condition     { get; set; }
        public int    No_seats      { get; set; }
        public int    Mileage       { get; set; }
        public string Colour        { get; set; }
        public int    Category_ID   { get; set; }
        public int    Branch_ID     { get; set; }
    }

    public class Employee
    {
        public int     Emp_ID      { get; set; }
        public string  Passkey     { get; set; }
        public string  Email       { get; set; }
        public string  Position    { get; set; }
        public string  First_Name  { get; set; }
        public string  Last_Name   { get; set; }
        public int     Branch_ID   { get; set; }
        public int?    SuperEmpID  { get; set; }
    }

    public class Payment
    {
        public int      Payment_ID      { get; set; }
        public string   Payment_Method  { get; set; }
        public DateTime Payment_Date    { get; set; }
        public int      Emp_ID          { get; set; }
        public int      Client_ID       { get; set; }
    }

    public class Reservation
    {
        public int       Reservation_ID     { get; set; }
        public int       Payment_ID         { get; set; }
        public DateTime  Reservation_Date   { get; set; }
        public DateTime  Deadline           { get; set; }
        public string    Reservation_Status { get; set; }
        public int       LicenseNo          { get; set; }
        public string    License_Plate      { get; set; }
        public int       Pickup_Branch_ID   { get; set; }
        public int?      Return_Branch_ID   { get; set; }
        public DateTime? Return_Date        { get; set; }
        public DateTime? Pickup_Date        { get; set; }
    }

        public class ReservationChonk
    {
        public int       Reservation_ID     { get; set; }
        public int       Payment_ID         { get; set; }
        public DateTime  Reservation_Date   { get; set; }
        public DateTime  Deadline           { get; set; }
        public string    Reservation_Status { get; set; }
        public int       Pickup_Branch_ID   { get; set; }
        public int?      Return_Branch_ID   { get; set; }
        public DateTime? Return_Date        { get; set; }
        public DateTime? Pickup_Date        { get; set; }
        public int    Driver_License_Number { get; set; }
        public string First_Name            { get; set; }
        public string Last_Name             { get; set; }
        public string Email                 { get; set; }
        public string Phone                 { get; set; }
        public string License_Plate { get; set; }
        public string Condition     { get; set; }
        public int    No_seats      { get; set; }
        public int    Mileage       { get; set; }
        public string Colour        { get; set; }
        public int    Branch_ID     { get; set; }
        public int     Category_ID      { get; set; }
        public string  Car_Type         { get; set; }
        public string  Make             { get; set; }
        public string  Model            { get; set; }
        public int     Model_Year       { get; set; }
        public string  Transmission     { get; set; }
        public decimal Daily_Rental_Rate { get; set; }
        public string   Payment_Method  { get; set; }
        public DateTime Payment_Date    { get; set; }
        public int      Emp_ID          { get; set; }
    }
}