using System;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace VehicleRentalApp
{
    public partial class AddCar : Form
    {
        int branchid;
        public AddCar(int BranchID)
        {
            InitializeComponent();
            this.branchid = BranchID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            Car cardata = new Car();
            Car_Category carcat = new Car_Category();

            cardata.Branch_ID = this.branchid;
            cardata.Colour = txtColour.Text;
            cardata.Mileage = (int)numMileage.Value;
            cardata.License_Plate = txtLicensePlate.Text;
            cardata.Condition = cmbCondition.SelectedItem.ToString();
            cardata.No_seats = (int)numSeats.Value;
            cardata.Category_ID = 0;

            carcat.Make = txtMake.Text;
            carcat.Model = txtModel.Text;
            carcat.Transmission = cmbTransmission.SelectedItem.ToString();
            carcat.Model_Year = (int)numModelYear.Value;
            carcat.Car_Type = cmbCarType.SelectedItem.ToString();
            carcat.Daily_Rental_Rate = numDailyRate.Value;
            carcat.Category_ID =0;

            VHSAUTOMOTIVE.add_car(cardata, carcat);



            MessageBox.Show("Car added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                MessageBox.Show("License Plate is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicensePlate.Focus();
                return false;
            }
            if (cmbCondition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Condition.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCondition.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColour.Text))
            {
                MessageBox.Show("Colour is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColour.Focus();
                return false;
            }
            if (cmbCarType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Car Type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCarType.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Make is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMake.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return false;
            }
            if (cmbTransmission.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Transmission type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTransmission.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}