
using System;
namespace VehicleRentalApp.Models
{

    public class Payment
    {
        public int      Payment_ID      { get; set; }
        public string   Payment_Method  { get; set; }
        public DateTime Payment_Date    { get; set; }
        public int      Emp_ID          { get; set; }
        public int      Client_ID       { get; set; }
    }
}