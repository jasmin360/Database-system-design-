using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class Reservation : UserControl
    {
        private MonthYearPicker _monthYearPicker;
        private bool _showReservationDates = true;

        public Reservation()
        {
            InitializeComponent();

            plus.Click += (s, e) =>
            {
                if (new AddReservation().ShowDialog() == DialogResult.OK)
                    LoadReservations();
            };

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

            siwtchViews.Tag = "reservation";
            siwtchViews.Text = "Deadline View";
            siwtchViews.Click += BtnSwitch_Click;
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            bool isDeadlineView = siwtchViews.Tag?.ToString() == "deadline";

            if (isDeadlineView)
            {
                siwtchViews.Text = "Deadline View";
                siwtchViews.Tag = "reservation";
                _showReservationDates = true;
            }
            else
            {
                siwtchViews.Text = "Reservation View";
                siwtchViews.Tag = "deadline";
                _showReservationDates = false;
            }

            LoadReservations();
        }

        private void LoadReservations()
        {
            var reservations = new List<ReservationInfo>
            {
                new ReservationInfo
                {
                    ReservationId = 1001,
                    LicenceNo     = "DL-12345",
                    FirstName     = "Jane",
                    LastName      = "Doe",
                    Email         = "jane.doe@email.com",
                    Phone         = "+1 555 0199",
                    Status        = "Picked Up",
                    Deadline      = DateTime.Today.AddDays(5),
                    PickupDate    = DateTime.Today,
                    ResDate       = DateTime.Today,
                    ReturnDate    = "Not Returned",
                    LicensePlate  = "ABC-1234",
                    Condition     = "Excellent",
                    Seats         = 5,
                    Mileage       = 15000,
                    Colour        = "White",
                    CarType       = "SUV",
                    Make          = "Toyota",
                    Model         = "RAV4",
                    ModelYear     = 2022,
                    Transmission  = "Automatic",
                    DailyRate     = 65
                },
                new ReservationInfo
                {
                    ReservationId = 1002,
                    LicenceNo     = "DL-67890",
                    FirstName     = "John",
                    LastName      = "Smith",
                    Email         = "john.smith@email.com",
                    Phone         = "+1 555 0234",
                    Status        = "Reserved",
                    Deadline      = DateTime.Today.AddDays(10),
                    PickupDate    = DateTime.Today.AddDays(2),
                    ResDate       = DateTime.Today.AddDays(-1),
                    ReturnDate    = "Not Returned",
                    LicensePlate  = "XYZ-9876",
                    Condition     = "Good",
                    Seats         = 4,
                    Mileage       = 42000,
                    Colour        = "Black",
                    CarType       = "Hatchback",
                    Make          = "Honda",
                    Model         = "Civic",
                    ModelYear     = 2020,
                    Transmission  = "Manual",
                    DailyRate     = 40
                },
                new ReservationInfo
                {
                    ReservationId = 1003,
                    LicenceNo     = "DL-11223",
                    FirstName     = "Sara",
                    LastName      = "Ahmed",
                    Email         = "sara.ahmed@email.com",
                    Phone         = "+20 100 1234567",
                    Status        = "Pending",
                    Deadline      = DateTime.Today.AddDays(3),
                    PickupDate    = DateTime.Today.AddDays(1),
                    ResDate       = DateTime.Today,
                    ReturnDate    = "Not Returned",
                    LicensePlate  = "LUX-0001",
                    Condition     = "Excellent",
                    Seats         = 4,
                    Mileage       = 8000,
                    Colour        = "Silver",
                    CarType       = "Sedan",
                    Make          = "BMW",
                    Model         = "5 Series",
                    ModelYear     = 2023,
                    Transmission  = "Automatic",
                    DailyRate     = 180
                },
                new ReservationInfo
                {
                    ReservationId = 1004,
                    LicenceNo     = "DL-44556",
                    FirstName     = "Omar",
                    LastName      = "Hassan",
                    Email         = "omar.hassan@email.com",
                    Phone         = "+20 111 9876543",
                    Status        = "Picked Up",
                    Deadline      = DateTime.Today.AddDays(7),
                    PickupDate    = DateTime.Today.AddDays(-1),
                    ResDate       = DateTime.Today.AddDays(-2),
                    ReturnDate    = "Not Returned",
                    LicensePlate  = "VAN-4421",
                    Condition     = "Fair",
                    Seats         = 8,
                    Mileage       = 98000,
                    Colour        = "Grey",
                    CarType       = "Coupe",
                    Make          = "Ford",
                    Model         = "Mustang",
                    ModelYear     = 2018,
                    Transmission  = "Manual",
                    DailyRate     = 85
                },
                new ReservationInfo
                {
                    ReservationId = 1005,
                    LicenceNo     = "DL-99887",
                    FirstName     = "Lena",
                    LastName      = "MÃ¼ller",
                    Email         = "lena.muller@email.com",
                    Phone         = "+49 151 12345678",
                    Status        = "Reserved",
                    Deadline      = DateTime.Today.AddDays(14),
                    PickupDate    = DateTime.Today.AddDays(4),
                    ResDate       = DateTime.Today,
                    ReturnDate    = "Not Returned",
                    LicensePlate  = "PIC-2210",
                    Condition     = "Good",
                    Seats         = 4,
                    Mileage       = 27000,
                    Colour        = "Red",
                    CarType       = "Picanto",
                    Make          = "Kia",
                    Model         = "Picanto",
                    ModelYear     = 2021,
                    Transmission  = "Manual",
                    DailyRate     = 30
                },
            };

            resDisplay.Controls.Clear();
            foreach (var res in reservations)
                resDisplay.Controls.Add(new ReservationCard(res, _showReservationDates));
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void monthBtn_Click(object sender, EventArgs e)
        {
            if (_monthYearPicker == null)
            {
                _monthYearPicker = new MonthYearPicker();
                _monthYearPicker.Location = new System.Drawing.Point(
                    monthBtn.Left,
                    monthBtn.Bottom + 4
                );
                _monthYearPicker.Size = new System.Drawing.Size(200, 28);
                _monthYearPicker.Font = new System.Drawing.Font("Calibri", 10F);
                _monthYearPicker.BackColor = System.Drawing.Color.FromArgb(23, 22, 54);
                _monthYearPicker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                this.Controls.Add(_monthYearPicker);
                _monthYearPicker.BringToFront();

                _monthYearPicker.ValueChanged += (s, ev) =>
                {
                    monthBtn.Text = _monthYearPicker.Value.ToString("MMMM");
                    // TODO: filter reservations by month/year
                };
            }

            _monthYearPicker.Visible = !_monthYearPicker.Visible;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void resDisplay_Paint(object sender, PaintEventArgs e) { }

        private DateTimePicker _datePicker;

        private void dayBtn_Click(object sender, EventArgs e)
        {
            if (_datePicker == null)
            {
                _datePicker = new DateTimePicker();
                _datePicker.Location = new System.Drawing.Point(
                    dayBtn.Left,
                    dayBtn.Bottom + 4
                );
                _datePicker.Size = new System.Drawing.Size(200, 28);
                _datePicker.Font = new System.Drawing.Font("Calibri", 10F);
                _datePicker.Format = DateTimePickerFormat.Short;
                _datePicker.Value = DateTime.Today;
                this.Controls.Add(_datePicker);
                _datePicker.BringToFront();

                _datePicker.ValueChanged += (s, ev) =>
                {
                    dayBtn.Text = _datePicker.Value.ToShortDateString();
                    // TODO: filter reservations by _datePicker.Value here
                };

                _datePicker.Leave += (s, ev) =>
                {
                    _datePicker.Visible = false;
                };
            }

            _datePicker.Visible = !_datePicker.Visible;
            if (_datePicker.Visible)
                _datePicker.Focus();
        }
    }
}