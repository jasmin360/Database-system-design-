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
        int branchidd;

        public Employees(int branchID, int supID, String City)
        {
            InitializeComponent();
            branchidd = branchID;
            this.Load += loademployeesboop;
            HireButton.Click += (s, e) =>
            {
                if (new HireEmployee(branchID, supID).ShowDialog() == DialogResult.OK)
                    LoadEmployees(branchID);
            };

            label1.Text = "Employees at branch " + City;
        }

        private void LoadEmployees(int branchID)
        {
            var employees = new List<EmployeeCardInfo>();
            Employee[] empsList = VHSAUTOMOTIVE.view_all_employees(branchID);

            foreach (var employee in empsList)
            {
                employees.Add(new EmployeeCardInfo
                {
                    EmployeeID = employee.Emp_ID,
                    Name = employee.First_Name + " " + employee.Last_Name,
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
            flowLayoutPanel1.Refresh();
            
        }
        private void loademployeesboop(object sender, EventArgs e)
        {
            LoadEmployees(this.branchidd);
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

        private void HireEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees(this.branchidd);
        }


    }
}