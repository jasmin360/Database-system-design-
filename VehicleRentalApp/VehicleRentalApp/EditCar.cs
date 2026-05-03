using System;
using System.Drawing;
using System.Windows.Forms;
using VehicleRentalApp.DAL;

namespace VehicleRentalApp
{
    public partial class EditCar : Form
    {
        int catid;
        private readonly CarInfo _car;

        public EditCar(CarInfo car)
        {
            InitializeComponent();
            _car = car;

            // pre-fill all fields with existing data
            txtLicensePlate.Text = car.LicensePlate;
            cmbCondition.SelectedItem = car.Condition;
            numSeats.Value = car.Seats;
            numMileage.Value = car.Mileage;
            txtColour.Text = car.Colour;

            cmbCarType.SelectedItem = car.CarType;
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            numModelYear.Value = car.ModelYear;
            cmbTransmission.SelectedItem = car.Transmission;
            numDailyRate.Value = car.DailyRate;
            catid = car.cat_id;

            // license plate is the primary key — don't allow editing
            txtLicensePlate.ReadOnly = true;
            txtLicensePlate.BackColor = System.Drawing.Color.FromArgb(23, 22, 54);

            numSeats.ReadOnly = true;
            numSeats.BackColor = Color.FromArgb(23, 22, 54);

            cmbCondition.Enabled = false;
            cmbCondition.BackColor = Color.FromArgb(23, 22, 54);

            cmbCarType.Enabled = false;
            cmbCarType.BackColor = Color.FromArgb(23, 22, 54);

            cmbTransmission.Enabled = false;
            cmbTransmission.BackColor = Color.FromArgb(23, 22, 54);

            txtMake.ReadOnly = true;
            txtMake.BackColor = System.Drawing.Color.FromArgb(23, 22, 54);

            txtModel.ReadOnly = true;
            txtModel.BackColor = System.Drawing.Color.FromArgb(23, 22, 54);

            numModelYear.ReadOnly = true;
            numModelYear.BackColor = Color.FromArgb(23, 22, 54);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // write back to the CarInfo object
            _car.LicensePlate = txtLicensePlate.Text.Trim();
            _car.Condition = cmbCondition.SelectedItem.ToString();
            _car.Seats = (int)numSeats.Value;
            _car.Mileage = (int)numMileage.Value;
            _car.Colour = txtColour.Text.Trim();
            _car.CarType = cmbCarType.SelectedItem.ToString();
            _car.Make = txtMake.Text.Trim();
            _car.Model = txtModel.Text.Trim();
            _car.ModelYear = (int)numModelYear.Value;
            _car.Transmission = cmbTransmission.SelectedItem.ToString();
            _car.DailyRate = numDailyRate.Value;
            _car.cat_id = catid;

            VHSAUTOMOTIVE.update_car(_car.LicensePlate, _car.Condition, _car.Mileage, (double)_car.DailyRate, catid);

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Changes saved.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (cmbCondition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Condition.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numSeats.Value <= 0)
            {
                MessageBox.Show("Seats must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColour.Text))
            {
                MessageBox.Show("Colour is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCarType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Car Type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Make is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbTransmission.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Transmission type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}