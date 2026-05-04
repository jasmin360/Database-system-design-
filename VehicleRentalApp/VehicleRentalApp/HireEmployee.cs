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
    public partial class HireEmployee : Form
    {
        int branchid;
        int supid;

        public HireEmployee(int BranchID, int SupID)
        {
            this.branchid = BranchID;
            this.supid = SupID;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            Employee employeecat = new Employee();


            
            string fullname = txtName.Text.Trim();
            int spaceIndex = fullname.IndexOf(' ');
            employeecat.First_Name = fullname.Substring(0, spaceIndex);
            employeecat.Last_Name = fullname.Substring(spaceIndex + 1).Trim();

            employeecat.Email = txtEmail.Text.Trim();
            employeecat.Branch_ID = branchid;
            employeecat.Passkey = txtPassword.Text.Trim();



            VHSAUTOMOTIVE.hire_employee(employeecat, supid);



            MessageBox.Show("Employee hired successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void HireEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
