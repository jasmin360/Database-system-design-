using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class CarCard : UserControl
    {
        public CarInfo Data { get; private set; }

        public CarCard(CarInfo data)
        {
            InitializeComponent();
            Data = data;

            RefreshDisplay();

            edit.Click += BtnEdit_Click;

            // make every child clickable as the card itself, except the edit button
            this.Click += OpenDetails;
            foreach (Control c in this.Controls)
            {
                if (c != edit)
                    c.Click += OpenDetails;
            }
        }

        private void RefreshDisplay()
        {
            lblMakeModel.Text = $"{Data.Make} {Data.Model}";
            lblPlate.Text = Data.LicensePlate;
            lblType.Text = $"{Data.CarType} • {Data.ModelYear}";
            lblRate.Text = $"${Data.DailyRate:0.##}/day";
            lblStatus.Text = Data.IsReserved ? "Reserved" : "Free";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (var edit = new EditCar(Data))
            {
                if (edit.ShowDialog() == DialogResult.OK)
                    RefreshDisplay();
            }
        }

        private void OpenDetails(object sender, EventArgs e)
        {
            new CarDetails(Data).ShowDialog();
            RefreshDisplay();
        }

        private void right_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class CarInfo
    {
        public string LicensePlate { get; set; }
        public string Condition { get; set; }
        public int Seats { get; set; }
        public int Mileage { get; set; }
        public string Colour { get; set; }
        public string CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Transmission { get; set; }
        public decimal DailyRate { get; set; }
        public bool IsReserved { get; set; }
    }
}