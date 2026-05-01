using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();

            plus.Click += (s, e) =>
            {
                if (new AddReservation().ShowDialog() == DialogResult.OK)
                    LoadReservations(); // refresh after adding
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
            siwtchViews.Click += BtnSwitch_Click;
            siwtchViews.Tag = "reservation"; // default state
            siwtchViews.Text = "Deadline View"; // shows what clicking will switch TO
        } // 
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            // Toggle view mode - store current state
            bool isDeadlineView = siwtchViews.Tag?.ToString() == "deadline";

            if (isDeadlineView)
            {
                // Switch to Reservation View
                siwtchViews.Text = "Deadline View";
                siwtchViews.Tag = "reservation";
                // Reload cards with reservation dates visible
                LoadReservations(showReservationDates: true);
            }
            else
            {
                // Switch to Deadline View
                siwtchViews.Text = "Reservation View";
                siwtchViews.Tag = "deadline";
                // Reload cards with only deadline visible
                LoadReservations(showReservationDates: false);
            }
        }
        private void LoadReservations(bool showReservationDates = true)
        {
            //demo data
            var Reservations = new List<ReservationInfo>
        {
            new ReservationInfo()
        };
                resDisplay.Controls.Clear();
                foreach (var reservation in Reservations)
                {
                    var card = new ReservationCard(reservation);

                    // Apply view mode
                    if (!showReservationDates)
                    {
                        card.SetDeadlineOnlyView();
                    }

                    resDisplay.Controls.Add(card);
                }
            }

        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}