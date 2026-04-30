using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // TODO: insert into DB
            // Car table:
            //   txtLicensePlate.Text
            //   cmbCondition.SelectedItem.ToString()
            //   numSeats.Value
            //   numMileage.Value
            //   txtColour.Text
            //   Category_ID  → from inserted Car_Category row

            // Car_Category table:
            //   cmbCarType.SelectedItem.ToString()
            //   txtMake.Text
            //   txtModel.Text
            //   numModelYear.Value
            //   cmbTransmission.SelectedItem.ToString()
            //   numDailyRate.Value

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