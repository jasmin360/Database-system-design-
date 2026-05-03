using System;
namespace VehicleRentalApp.Models
{
    public class Car_Category
    {
        public int     Category_ID      { get; set; }
        public string  Car_Type         { get; set; }
        public string  Make             { get; set; }
        public string  Model            { get; set; }
        public int     Model_Year       { get; set; }
        public string  Transmission     { get; set; }
        public decimal Daily_Rental_Rate { get; set; }
        public int count { get; set; }
    }
}