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
            // txtLicensePlate.Text
            // cmbCondition.SelectedItem.ToString()
            // numSeats.Value
            // numMileage.Value
            // txtColour.Text
            // cmbCategory.SelectedItem.ToString()

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
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void numSeats_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}