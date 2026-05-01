
using System;
namespace VehicleRentalApp.Models
{

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
}