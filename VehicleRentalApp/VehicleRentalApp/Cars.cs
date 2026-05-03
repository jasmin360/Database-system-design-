using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class Cars : UserControl
    {
        private string statusFilter = "All";
        private bool picantoChecked = false;
        private bool suvChecked = false;
        private bool coupeChecked = false;
        private bool sedanChecked = false;
        private bool hatchbackChecked = false;

        private Branch branch;

        public Cars(Branch branchitself)
        {
            this.branch = branchitself;
            InitializeComponent();
            filterPanel.Visible = false;

            plus.Click += (s, e) =>
            {
                filterPanel.Visible = false;

                if (new AddCar(this.branch.Branch_ID).ShowDialog() == DialogResult.OK)
                    LoadCars();
            };

            // Search box placeholder handling
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == "Search...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = SystemColors.ButtonHighlight;
                }
            };

            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search...";
                    txtSearch.ForeColor = Color.FromArgb(82, 82, 110);
                }
            };

            // Search functionality
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Status filter buttons
            all.Click += (s, e) => { statusFilter = "All"; LoadCars(); };
            free.Click += (s, e) => { statusFilter = "Free"; LoadCars(); };
            reserv.Click += (s, e) => { statusFilter = "Reserved"; LoadCars(); };

            // Car type filter checkboxes
            chkPicanto.CheckedChanged += (s, e) => { picantoChecked = chkPicanto.Checked; LoadCars(); };
            chkSUV.CheckedChanged += (s, e) => { suvChecked = chkSUV.Checked; LoadCars(); };
            chkCoupe.CheckedChanged += (s, e) => { coupeChecked = chkCoupe.Checked; LoadCars(); };
            chkSedan.CheckedChanged += (s, e) => { sedanChecked = chkSedan.Checked; LoadCars(); };
            chkHatchback.CheckedChanged += (s, e) => { hatchbackChecked = chkHatchback.Checked; LoadCars(); };
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCars(); // Reload with search filter applied
        }

        private void LoadCars()
        {
            int branchID = this.branch.Branch_ID;

            // Get search query
            string searchQuery = "";
            if (txtSearch.Text != "Search..." && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                searchQuery = txtSearch.Text.ToLower().Trim();
            }

            // Call backend with current filter state
            Car[] carsFromDB = VHSAUTOMOTIVE.filter_Cars_In_Branch(branchID, statusFilter, picantoChecked, suvChecked, coupeChecked, sedanChecked, hatchbackChecked);

            flowLayoutPanel1.Controls.Clear();

            int cardCount = 0;
            foreach (var carData in carsFromDB)
            {
                Car_Category carCat = VHSAUTOMOTIVE.cat_fromID(carData.Category_ID);
                var car = new CarInfo
                {
                    LicensePlate = carData.License_Plate,
                    Condition = carData.Condition,
                    Seats = carData.No_seats,
                    Mileage = carData.Mileage,
                    Colour = carData.Colour,
                    CarType = carCat.Car_Type,
                    Make = carCat.Make,
                    Model = carCat.Model,
                    ModelYear = carCat.Model_Year,
                    Transmission = carCat.Transmission,
                    DailyRate = carCat.Daily_Rental_Rate,
                    IsReserved = carData.Condition == "Reserved",
                    cat_id = carData.Category_ID
                };

                // Apply search filter
                bool matchesSearch = true;
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    matchesSearch = car.Make.ToLower().Contains(searchQuery) ||car.Model.ToLower().Contains(searchQuery) ||car.LicensePlate.ToLower().Contains(searchQuery);
                }

                // Only add card if it matches search
                if (matchesSearch)
                {
                    flowLayoutPanel1.Controls.Add(new CarCard(car));
                    cardCount++;
                }
            }

            flowLayoutPanel1.Refresh();
        }

        private void right_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}