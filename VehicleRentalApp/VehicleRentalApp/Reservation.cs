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
                }
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