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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace VehicleRentalApp
{
    public partial class recentRes : UserControl
    {

        public event EventHandler NavigateRequested;

        public recentRes()
        {
            InitializeComponent();
            left.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
            right.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
            this.Load += Reservation_Load_Today_returns;

        }

        private void LoadTodaysReturns()
        {
            ReservationHorse[] recents = VHSAUTOMOTIVE.planned_returns_today();
            var reservations = new List<ReservationInfo>();

            foreach (var resresres in recents)
            {
                bool tobtob = false;
                ReservationChonk nomnom = VHSAUTOMOTIVE.Reservation_Details(resresres.Reservation_ID, ref tobtob);

                // ADD TO LIST - you were missing this!
                reservations.Add(new ReservationInfo
                {
                    ReservationId = resresres.Reservation_ID,
                    LicenceNo = resresres.LicenseNo.ToString(),
                    FirstName = nomnom.First_Name,
                    LastName = nomnom.Last_Name,
                    Email = nomnom.Email,
                    Phone = nomnom.Phone,
                    Status = resresres.Reservation_Status,
                    Deadline = resresres.Deadline,
                    PickupDate = resresres.Pickup_Date,
                    ResDate = resresres.Reservation_Date,
                    ReturnDate = resresres.Return_Date,
                    LicensePlate = resresres.License_Plate,
                    Condition = nomnom.Condition,
                    Seats = nomnom.No_seats,
                    Mileage = nomnom.Mileage,
                    Colour = nomnom.Colour,
                    CarType = nomnom.Car_Type,
                    Make = nomnom.Make,
                    Model = nomnom.Model,
                    ModelYear = nomnom.Model_Year,
                    Transmission = nomnom.Transmission,
                    DailyRate = nomnom.Daily_Rental_Rate
                });
            }
            // MOVE THIS OUTSIDE THE LOOP
            flowLayoutPanel1.Controls.Clear();
            foreach (var reservation in reservations)
            {
                var card = new ReservationCard(reservation);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Reservation_Load_Today_returns(object sender, EventArgs e)
        {
            LoadTodaysReturns();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void profilePic_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
