using System;
using System.Drawing;
using System.Windows.Forms;
using VehicleRentalApp.DAL;

namespace VehicleRentalApp
{
    public partial class ReservationDetails : Form
    {
        private readonly ReservationInfo _res;

        public ReservationDetails(ReservationInfo res)
        {
            InitializeComponent();
            _res = res;
            RefreshDisplay();
            btnDelete.Click += btnDelete_Click;
        }

        private void RefreshDisplay()
        {
            this.Text = $"Reservation — {_res.FirstName} {_res.LastName}";
            lblTitle.Text = $"Reservation — {_res.FirstName} {_res.LastName}";

            lblLicenceNoV.Text = _res.LicenceNo;
            lblFirstNameV.Text = _res.FirstName;
            lblLastNameV.Text = _res.LastName;
            lblEmailV.Text = _res.Email;
            lblPhoneV.Text = _res.Phone;

            lblStatusV.Text = _res.Status;
            lblDeadlineV.Text = _res.Deadline.ToShortDateString();


            lblPickupDateV.Text = _res.PickupDate?.ToShortDateString() ?? "Not Picked Up";
            lblReturnDateV.Text = _res.ReturnDate?.ToShortDateString() ?? "Not Returned";

            lblResDateV.Text = _res.ResDate.ToShortDateString();
            switch (_res.Status)
            {
                case "Picked Up":
                    lblStatusV.ForeColor = Color.FromArgb(82, 180, 110);
                    lblStatusV.BackColor = Color.FromArgb(10, 40, 20);
                    break;
                case "Reserved":
                    lblStatusV.ForeColor = Color.FromArgb(112, 105, 181);
                    lblStatusV.BackColor = Color.FromArgb(29, 26, 73);
                    break;
                case "Pending":
                    lblStatusV.ForeColor = Color.FromArgb(200, 160, 60);
                    lblStatusV.BackColor = Color.FromArgb(40, 30, 10);
                    break;
            }

            lblPlateV.Text = _res.LicensePlate;
            lblConditionV.Text = _res.Condition;
            lblSeatsV.Text = _res.Seats.ToString();
            lblMileageV.Text = _res.Mileage.ToString("N0") + " km";
            lblColourV.Text = _res.Colour;

            lblCarTypeV.Text = _res.CarType;
            lblMakeV.Text = _res.Make;
            lblModelV.Text = _res.Model;
            lblYearV.Text = _res.ModelYear.ToString();
            lblTransV.Text = _res.Transmission;
            lblRateV.Text = $"${_res.DailyRate:0.##}/day";

            if (_res.PaymentId == 0)
                lblPayIDV.Text = "N/A";
            else
                lblPayIDV.Text = _res.PaymentId.ToString();

            lblPayMethodV.Text = _res.PaymentMethod?? "N/A";

            lblPayDateV.Text = _res.PaymentDate.ToShortDateString() ?? "N/A";
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete the reservation for {_res.FirstName} {_res.LastName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void ReservationDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"ARE YOU SUREEEEEEEEEE?????????",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                VHSAUTOMOTIVE.cancel_reservation(_res.ReservationId);
            }
        }

        private void panelPayment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}