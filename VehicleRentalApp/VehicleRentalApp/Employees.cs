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
            Employee[] recents = VHSAUTOMOTIVE.view_all_employees(branchID);
            var employees = new List<EmployeeCardInfo>();

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
    }
}
