using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class EmployeeDetails : Form
    {
        static int id = 0;
        static string name = "";
        static string role = "";
        static string email = "";
        public EmployeeDetails(Employee employee)
        {
            InitializeComponent();
            EmployeeDetails.id = employee.Emp_ID;
            EmployeeDetails.name = employee.First_Name +" " +employee.Last_Name;
            EmployeeDetails.role = employee.Position;
            EmployeeDetails.email = employee.Email;
            lblEmpIDK.Text = $"Employee ID : {EmployeeDetails.id.ToString()}";
            lblNameK.Text = $"Employee Name : {EmployeeDetails.name}";
            lblRoleK.Text = $"Employee Role : {EmployeeDetails.role}";
            lblEmailK.Text = $"Employee Email : {EmployeeDetails.email}";
            //check if the employee id that was coming from the dashboard is the same as the one in the employee details form, if it is, then hide the fire button
            //    if (EmployeeDetails.id == Dashboard.BRANCHID())
            //    {
            //        btnFire.Visible = false;
            //    }
            //    else
            //    {
            //        btnFire.Visible = true;
            //}

        }


        public static int BRANCHID()
        {
            return EmployeeDetails.id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelCar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
