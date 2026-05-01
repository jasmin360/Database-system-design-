
using System;
namespace VehicleRentalApp.Models
{


    public class ReservationHorse
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
}