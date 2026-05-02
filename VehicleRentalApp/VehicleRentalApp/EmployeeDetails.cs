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
    public partial class EmployeeDetails : Form
    {
        int id = 0;
        string name = "";
        string role = "";
        string email = "";
        public EmployeeDetails(Employee employee)
        {
            InitializeComponent();
            this.id = employee.Emp_ID;
            this.name = employee.First_Name +" " +employee.Last_Name;
            this.role = employee.Position;
            this.email = employee.Email;
            lblEmpIDK.Text = $"Employee ID : {this.id.ToString()}";
            lblNameK.Text = $"Employee Name : {this.name}";
            lblRoleK.Text = $"Employee Role : {this.role}";
            lblEmailK.Text = $"Employee Email : {this.email}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
