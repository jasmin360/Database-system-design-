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
    public partial class overview : UserControl
    {
        int BranchIDD;
        public event EventHandler NavigateRequested;

        public overview(int BranchID)
        {
            InitializeComponent();
            left.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
            right.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
            this.BranchIDD = BranchID;
            this.Load += Reservation_Load_Recent;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadRecentReservation()
        {
            ReservationHorse[] recents = VHSAUTOMOTIVE.recent_reservations();
            var reservations = new List<ReservationInfo>();

            foreach (var resresres in recents)
            {
                bool tobtob = false;
                ReservationChonk nomnom = VHSAUTOMOTIVE.Reservation_Details(resresres.Reservation_ID, ref tobtob);

                
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

            
            flowLayoutPanel1.Controls.Clear();
            foreach (var reservation in reservations)
            {
                var card = new ReservationCard(reservation, this.BranchIDD);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Reservation_Load_Recent(object sender, EventArgs e)
        {
            LoadRecentReservation();
        }



        private void profilePic_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRecentReservation();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
