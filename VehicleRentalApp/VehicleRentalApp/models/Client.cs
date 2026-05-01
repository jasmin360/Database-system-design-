using System;
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
}