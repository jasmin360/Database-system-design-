using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class ReservationCard : UserControl
    {
        int BranchIDD;
        public ReservationInfo Data { get; private set; }

        public ReservationCard(ReservationInfo data, int BranchID, bool showReservationDate = true)
        {
            InitializeComponent();
            Data = data;
            this.BranchIDD = BranchID;
            RefreshDisplay();

            lblDates.Text = showReservationDate
                ? $"Reserved: {data.ResDate.ToShortDateString()}  |  Deadline: {data.Deadline.ToShortDateString()}"
                : $"Deadline: {data.Deadline.ToShortDateString()}";

            btnDelete.Click += BtnDelete_Click;

            lblStatus.Click += LblStatus_Click;

            this.Click += OpenDetails;
            foreach (Control c in this.Controls)
            {
                if (c != btnDelete && c != lblStatus)
                    c.Click += OpenDetails;
            }
        }

        public void SetDeadlineOnlyView()
        {
            lblDates.Text = $"Deadline: {Data.Deadline.ToShortDateString()}";
        }

        private void RefreshDisplay()
        {
            lblClientName.Text = $"{Data.FirstName} {Data.LastName}";
            lblResId.Text = $"ID: #{Data.ReservationId}";
            lblLicenceNo.Text = Data.LicenceNo;
            lblCarInfo.Text = $"{Data.Make} {Data.Model} • {Data.LicensePlate}";
            lblDates.Text = $"Reserved: {Data.ResDate.ToShortDateString()}  |  Deadline: {Data.Deadline.ToShortDateString()}";
            lblRate.Text = $"${Data.DailyRate:0.##}/day";
            lblStatus.Text = Data.Status;

            switch (Data.Status)
            {
                case "Pickedup":
                    lblStatus.ForeColor = Color.FromArgb(82, 180, 110);
                    lblStatus.BackColor = Color.FromArgb(10, 40, 20);
                    break;
                case "Returned":
                    lblStatus.ForeColor = Color.FromArgb(138, 43, 226);
                    lblStatus.BackColor = Color.FromArgb(30, 10, 40);
                    break;
                case "Pending":
                    lblStatus.ForeColor = Color.FromArgb(200, 160, 60);
                    lblStatus.BackColor = Color.FromArgb(40, 30, 10);
                    break;
            }
        }

        private void LblStatus_Click(object sender, EventArgs e)
        {
            string nextStatus = GetNextStatus(Data.Status);
            SetStatus(nextStatus);
        }

        private string GetNextStatus(string currentStatus)
        {
            if (currentStatus == "Pending")
                return "Pickedup";
            else if (currentStatus == "Pickedup")
                return "Returned";
            else
                return currentStatus; // Stay at Returned
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"ARE YOU SUREEEEEEEEEE?????????",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                VHSAUTOMOTIVE.cancel_reservation(Data.ReservationId);
            }
        }

        private void OpenDetails(object sender, EventArgs e)
        {
            var details = new ReservationDetails(Data);
            if (details.ShowDialog() == DialogResult.OK)
            {
                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void SetStatus(string newStatus)
        {
            if (Data.Status == newStatus)
            {
                MessageBox.Show("Already at final status.", "No Change",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Change status from '{Data.Status}' to '{newStatus}'?",
                "Confirm Status Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (Data.Status == "Pending" && newStatus == "Pickedup")
                {
                    PickupReservation(Data.ReservationId);
                }
                else if (Data.Status == "Pickedup" && newStatus == "Returned")
                {
                    ReturnReservation(Data.ReservationId);
                }
                else
                {
                    MessageBox.Show("This status transition is not supported.", "Invalid Transition",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Data.Status = newStatus;
                RefreshDisplay();
            }
        }

        private void PickupReservation(int reservationId)
        {
            // Pending -> Pickedup
            VHSAUTOMOTIVE.pickup_car(reservationId, VHSAUTOMOTIVE.car_branch(Data.LicensePlate));
        }

        private void ReturnReservation(int reservationId)
        {
            // Pickedup -> Returned
            VHSAUTOMOTIVE.return_car(reservationId, this.BranchIDD );
        }

        private void btnEdit_Click(object sender, EventArgs e) { }
        private void btnDelete_Click(object sender, EventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void lblRate_Click(object sender, EventArgs e) { }
        private void ReservationCard_Load(object sender, EventArgs e) { }
        private void lblCarInfo_Click(object sender, EventArgs e) { }
    }

    public class ReservationInfo
    {
        public int ReservationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenceNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? PickupDate { get; set; } = null;
        public DateTime? ReturnDate { get; set; } = null;
        public DateTime ResDate { get; set; }
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
    }
}