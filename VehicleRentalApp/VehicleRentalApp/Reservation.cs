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
        } // ✅ FIX: constructor properly closed here

        private void LoadReservations()
        {
            //demo data
            var Reservations = new List<ReservationInfo>
            {
                new ReservationInfo()
            };

            resDisplay.Controls.Clear();

            foreach (var reservation in Reservations)
                resDisplay.Controls.Add(new ReservationCard(reservation));
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