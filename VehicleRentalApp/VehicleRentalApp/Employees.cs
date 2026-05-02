using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            this.Load += loademployeesboop;
        }

        private void LoadEmployees(int branchID)
        {
            // 1. Commented out the database call
            // Employee[] recents = VHSAUTOMOTIVE.view_all_employees(branchID);
            
            // 2. Hardcoded dummy values for testing
            var employees = new List<EmployeeCardInfo>
            {
                new EmployeeCardInfo { EmployeeID = 1, Name = "Clark Kent", Role = "Manager", Email = "clark.k@example.com" },
                new EmployeeCardInfo { EmployeeID = 2, Name = "Bruce Wayne", Role = "Sales Associate", Email = "bruce.w@example.com" },
                new EmployeeCardInfo { EmployeeID = 3, Name = "Diana Prince", Role = "Mechanic", Email = "diana.p@example.com" },
                new EmployeeCardInfo { EmployeeID = 4, Name = "Barry Allen", Role = "Customer Service", Email = "barry.a@example.com" }
            };

            /* Original mapping loop - commented out for now
            foreach (var employee in recents)
            {
                employees.Add(new EmployeeCardInfo
                {
                    EmployeeID= employee.Emp_ID,
                    Name= employee.First_Name + " "+ employee.Last_Name,
                    Role = employee.Position,
                    Email = employee.Email
                });
            }
            */

            flowLayoutPanel1.Controls.Clear();
            foreach (var employee in employees)
            {
                var card = new EmployeeCard(employee);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void loademployeesboop(object sender, EventArgs e)
        {
            int id = EmployeeDetails.BRANCHID();
            LoadEmployees(id);
        }

        private void lblFilterTitle_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}