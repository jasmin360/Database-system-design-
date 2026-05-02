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
        public EmployeeCardInfo Data { get; private set; }

        public EmployeeCard(EmployeeCardInfo employee)
        {
            InitializeComponent();
            Data = employee;

            lblEmpID.Text = $"{employee.EmployeeID}";
            lblName.Text = $"{employee.Name}";
            lblRole.Text = $"{employee.Role}";
            lblEmail.Text = $"{employee.Email}";

            AttachClickEventToAll(this);
        }
        private void AttachClickEventToAll(Control parentControl)
        {
            // Attach the click event to this specific control
            parentControl.Click += EmployeeCard_Click;

            // Recursively dig down into any panels/groups to attach the event to labels
            foreach (Control child in parentControl.Controls)
            {
                AttachClickEventToAll(child);
            }
        }

        private void EmployeeCard_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
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
