

using System;
namespace VehicleRentalApp.Models
{

    public class Branch
    {
        public int     Branch_ID        { get; set; }
        public string City             { get; set; }
        public int?    Street_Number    { get; set; }
        public int?    Building_Number  { get; set; }
        public string Contact_Number   { get; set; }
    }
}