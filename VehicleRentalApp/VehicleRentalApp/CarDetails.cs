using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class CarDetails : Form
    {
        private readonly CarInfo _car;

        public CarDetails(CarInfo data)
        {
            InitializeComponent();
            _car = data;

            RefreshDisplay();

            edit.Click += btnEdit_Click;
        }

        private void RefreshDisplay()
        {
            this.Text = $"{_car.Make} {_car.Model} — {_car.LicensePlate}";
            lblTitle.Text = $"{_car.Make} {_car.Model}";

            lblPlateV.Text = _car.LicensePlate;
            lblCondV.Text = _car.Condition;
            lblSeatsV.Text = _car.Seats.ToString();
            lblMileV.Text = _car.Mileage.ToString("N0");
            lblColV.Text = _car.Colour;

            lblTypeV.Text = _car.CarType;
            lblMakeV.Text = _car.Make;
            lblModelV.Text = _car.Model;
            lblYearV.Text = _car.ModelYear.ToString();
            lblTransV.Text = _car.Transmission;
            lblRateV.Text = $"${_car.DailyRate:0.##}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var edit = new EditCar(_car))
            {
                if (edit.ShowDialog() == DialogResult.OK)
                    RefreshDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}