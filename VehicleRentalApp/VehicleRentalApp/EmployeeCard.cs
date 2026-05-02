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
    public partial class EmployeeCard : UserControl
    {
        public EmployeeCard(EmployeeCardInfo employee)
        {
            InitializeComponent();

            lblEmpID.Text = $"{employee.EmployeeID}";
            lblName.Text = $"{employee.Name}";
            lblRole.Text = $"{employee.Role}";
            lblEmail.Text = $"{employee.Email}";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeCard_Load(object sender, EventArgs e)
        {

        }
    }
    public class EmployeeCardInfo
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

    }
}
