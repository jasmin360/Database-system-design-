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
        // Filter states
        private string timeType = "reservation"; // "reservation" or "deadline"
        private string periodFilter = "today"; // "today", "thisweek", "month", "day"
        private DateTime? selectedDate = null;
        private int? selectedMonth = null;
        private int? selectedYear = null;
        private int? selectedDay = null;
        private int _empID;
        private int _branchID;

        public Reservation(int empID, int branchid)
        {
            InitializeComponent();
            resDisplay.AutoScroll = true;
            _empID = empID;
            _branchID = branchid;

            plus.Click += (s, e) =>
            {
                if (new AddReservation(_empID, _branchID).ShowDialog() == DialogResult.OK)
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

            todaybtn.Click += (s, e) => { periodFilter = "today"; LoadReservations(); };
            thisWeekbtn.Click += (s, e) => { periodFilter = "thisweek"; LoadReservations(); };
            monthBtn.Click += (s, e) => { periodFilter = "month"; LoadReservations(); };
            dayBtn.Click += (s, e) => { periodFilter = "day"; LoadReservations(); };
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            bool isDeadlineView = siwtchViews.Tag?.ToString() == "deadline";

            if (isDeadlineView)
            {
                siwtchViews.Text = "Deadline View";
                siwtchViews.Tag = "reservation";
                timeType = "reservation";
                _showReservationDates = true;
            }
            else
            {
                siwtchViews.Text = "Reservation View";
                siwtchViews.Tag = "deadline";
                timeType = "deadline";
                _showReservationDates = false;
            }

            LoadReservations();
        }

        private void LoadReservations()
        {

            // Call backend based on current filters
            ReservationHorse[] reservationsFromDB;

            if (periodFilter == "today")
            {
                if (timeType == "reservation")
                    reservationsFromDB = VHSAUTOMOTIVE.filter_reservation_today();
                else
                    reservationsFromDB = VHSAUTOMOTIVE.filter_deadlines_today();
            }
            else if (periodFilter == "thisweek")
            {
                if (timeType == "reservation")
                    reservationsFromDB = VHSAUTOMOTIVE.filter_reservation_this_week();
                else
                    reservationsFromDB = VHSAUTOMOTIVE.filter_deadlines_this_week();
            }
            else if (periodFilter == "month" && selectedMonth.HasValue && selectedYear.HasValue)
            {
                if (timeType == "reservation")
                    reservationsFromDB = VHSAUTOMOTIVE.filter_reservation(null,null, selectedMonth, selectedYear);
                else
                    reservationsFromDB = VHSAUTOMOTIVE.filter_deadlines(null, null, selectedMonth, selectedYear); ;
            }
            else if (periodFilter == "day" && selectedMonth.HasValue && selectedYear.HasValue && selectedDay.HasValue)
            {
                if (timeType == "reservation")
                    reservationsFromDB = VHSAUTOMOTIVE.filter_reservation(selectedDay, null, selectedMonth, selectedYear);
                else
                    reservationsFromDB = VHSAUTOMOTIVE.filter_deadlines(selectedDay, null, selectedMonth, selectedYear);
            }
            else
                reservationsFromDB = VHSAUTOMOTIVE.filter_reservation_today();

            var reservations = new List<ReservationInfo>();

            foreach (var resData in reservationsFromDB)
            {
                bool success = false;
                ReservationChonk details = VHSAUTOMOTIVE.Reservation_Details(resData.Reservation_ID, ref success);

                reservations.Add(new ReservationInfo
                {
                    ReservationId = resData.Reservation_ID,
                    LicenceNo = resData.LicenseNo.ToString(),
                    FirstName = details.First_Name,
                    LastName = details.Last_Name,
                    Email = details.Email,
                    Phone = details.Phone,
                    Status = resData.Reservation_Status,
                    Deadline = resData.Deadline,
                    PickupDate = resData.Pickup_Date,
                    ResDate = resData.Reservation_Date,
                    ReturnDate = resData.Return_Date,
                    LicensePlate = resData.License_Plate,
                    Condition = details.Condition,
                    Seats = details.No_seats,
                    Mileage = details.Mileage,
                    Colour = details.Colour,
                    CarType = details.Car_Type,
                    Make = details.Make,
                    Model = details.Model,
                    ModelYear = details.Model_Year,
                    Transmission = details.Transmission,
                    DailyRate = details.Daily_Rental_Rate
                });
            }
            // ADD THESE LINES - Display the cards!
            resDisplay.Controls.Clear();
            foreach (var res in reservations)
                resDisplay.Controls.Add(new ReservationCard(res, _branchID, _showReservationDates));

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
                    selectedMonth = _monthYearPicker.Value.Month;
                    selectedYear = _monthYearPicker.Value.Year;
                    periodFilter = "month";  // Add this
                    LoadReservations();      // Add this
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
                    selectedMonth = _datePicker.Value.Month;
                    selectedYear = _datePicker.Value.Year;
                    selectedDay = _datePicker.Value.Day;
                    periodFilter = "day";    // Add this
                    LoadReservations();      // Add this
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }
    }
}