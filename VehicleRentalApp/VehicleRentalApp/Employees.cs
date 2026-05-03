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
            try
            {
                MessageBox.Show($"Step 1: Calling backend with Branch ID: {branchID}");

                Employee[] empsList = VHSAUTOMOTIVE.view_all_employees(branchID);

                MessageBox.Show($"Step 2: Got {empsList.Length} employees from database");

                var employees = new List<EmployeeCardInfo>();

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

                MessageBox.Show($"Step 3: Created {employees.Count} EmployeeCardInfo objects");

                flowLayoutPanel1.Controls.Clear();

                foreach (var employee in employees)
                {
                    var card = new EmployeeCard(employee);
                    flowLayoutPanel1.Controls.Add(card);
                }

                MessageBox.Show($"Step 4: Added {flowLayoutPanel1.Controls.Count} cards to panel");

                // Force panel to refresh
                flowLayoutPanel1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loademployeesboop(object sender, EventArgs e)
        {
            int id = 1;
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