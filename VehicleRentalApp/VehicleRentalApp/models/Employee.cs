
using System;
using System.ComponentModel.Design;
namespace VehicleRentalApp.Models
{
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
        public int Active  { get; set; }
    }
}