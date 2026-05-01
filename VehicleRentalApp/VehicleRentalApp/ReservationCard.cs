using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class ReservationCard : UserControl
    {
        public ReservationInfo Data { get; private set; }

        public ReservationCard(ReservationInfo data)
        {
            InitializeComponent();
            Data = data;
            RefreshDisplay();

            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            // make every child clickable as the card itself, except the edit and delete buttons
            this.Click += OpenDetails;
            foreach (Control c in this.Controls)
            {
                if (c != btnEdit && c != btnDelete)
                    c.Click += OpenDetails;
            }
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
                case "Picked Up":
                    lblStatus.ForeColor = Color.FromArgb(82, 180, 110);
                    lblStatus.BackColor = Color.FromArgb(10, 40, 20);
                    break;
                case "Reserved":
                    lblStatus.ForeColor = Color.FromArgb(112, 105, 181);
                    lblStatus.BackColor = Color.FromArgb(29, 26, 73);
                    break;
                case "Pending":
                    lblStatus.ForeColor = Color.FromArgb(200, 160, 60);
                    lblStatus.BackColor = Color.FromArgb(40, 30, 10);
                    break;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit reservation coming soon.", "Edit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"Delete reservation for {Data.FirstName} {Data.LastName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // TODO: delete from DB
                this.Parent?.Controls.Remove(this);
                this.Dispose();
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

        private void btnEdit_Click(object sender, EventArgs e) { }
        private void btnDelete_Click(object sender, EventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
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
        public DateTime PickupDate { get; set; }
        public string ReturnDate { get; set; }
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