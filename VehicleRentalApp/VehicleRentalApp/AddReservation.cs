using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class AddReservation : Form
    {
        private List<CarInfo> filteredCategories;
        private CarInfo selectedCategory = null;
        private CategoryCard selectedCard = null;
        private bool clientFound = false;

        // Store employee and branch info
        private int currentEmployeeID;
        private int currentBranchID;

        public AddReservation(int employeeID, int branchID)
        {
            InitializeComponent();

            // Store employee and branch
            this.currentEmployeeID = employeeID;
            this.currentBranchID = branchID;

            dtpResDate.Value = DateTime.Today;
            dtpDeadline.Value = DateTime.Today.AddDays(7);
            dtpPickupDate.Value = DateTime.Today;
            dtpPaymentDate.Value = DateTime.Today;

            SetClientFieldsEnabled(false);

            // Disable auto-filled fields
            cmbStatus.Enabled = false;
            cmbStatus.BackColor = Color.FromArgb(23, 22, 54);

            this.Load += AddReservation_Load;
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0; // Default to "Pending"
            cmbPaymentMethod.SelectedIndex = 0; // Default to "Cash"

            LoadCategories();
        }

        private void LoadCategories()
        {
            // Call backend to get all categories
            Car_Category[] categoriesFromDB = VHSAUTOMOTIVE.display_all_cats()
; // Replace with your actual backend method

            var allCategories = new List<CarInfo>();

            foreach (var cat in categoriesFromDB)
            {
                allCategories.Add(new CarInfo
                {
                    CarType = cat.Car_Type,
                    Make = cat.Make,
                    Model = cat.Model,
                    ModelYear = cat.Model_Year,
                    Transmission = cat.Transmission,
                    DailyRate = cat.Daily_Rental_Rate,
                    count = cat.Count 
                });
            }

            // Filter out categories with 0 available cars
            filteredCategories = allCategories.Where(c => c.count > 0).ToList();

            RefreshCategoryCards();
        }

        // ── Client lookup ─────────────────────────────────────────────
        private void btnLookup_Click(object sender, EventArgs e)
        {
            string licence = txtLicenceNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(licence))
            {
                lblClientStatus.Text = "Please enter a licence number first.";
                lblClientStatus.ForeColor = Color.FromArgb(200, 80, 80);
                return;
            }
            Client clientData = VHSAUTOMOTIVE.find_client(int.Parse(licence));
            bool found = false;

            if (clientData != null)
            {
                found = true;
            }

            if (found)
            {

                txtFirstName.Text = clientData.First_Name;
                txtLastName.Text = clientData.Last_Name;
                txtEmail.Text = clientData.Email;
                txtPhone.Text = clientData.Phone;

                SetClientFieldsEnabled(false);
                lblClientStatus.Text = "Client found.";
                lblClientStatus.ForeColor = Color.FromArgb(82, 180, 110);
                clientFound = true;
            }
            else
            {
                ClearClientFields();
                SetClientFieldsEnabled(true);
                lblClientStatus.Text = "Client not found. Fill in details to create a new client.";
                lblClientStatus.ForeColor = Color.FromArgb(200, 160, 60);
                clientFound = false;
                
            }
        }

        private void txtLicenceNo_TextChanged(object sender, EventArgs e)
        {
            ClearClientFields();
            SetClientFieldsEnabled(false);
            lblClientStatus.Text = "Enter a licence number and click Look Up";
            lblClientStatus.ForeColor = Color.FromArgb(82, 82, 110);
            clientFound = false;
        }

        private void SetClientFieldsEnabled(bool enabled)
        {
            var bgEnabled = Color.FromArgb(10, 9, 41);
            var bgDisabled = Color.FromArgb(23, 22, 54);
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtPhone.Enabled = enabled;
            txtFirstName.BackColor = enabled ? bgEnabled : bgDisabled;
            txtLastName.BackColor = enabled ? bgEnabled : bgDisabled;
            txtEmail.BackColor = enabled ? bgEnabled : bgDisabled;
            txtPhone.BackColor = enabled ? bgEnabled : bgDisabled;
        }

        private void ClearClientFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        // ── Category cards ────────────────────────────────────────────
        private void RefreshCategoryCards()
        {
            flowCategories.Controls.Clear();
            foreach (var c in filteredCategories)
            {
                var card = new CategoryCard(c);
                card.CardSelected += Card_Selected;
                flowCategories.Controls.Add(card);
            }
        }

        private void Card_Selected(object sender, EventArgs e)
        {
            var card = (CategoryCard)sender;
            if (selectedCard != null)
                selectedCard.SetSelected(false);
            card.SetSelected(true);
            selectedCard = card;
            selectedCategory = card.Data;
        }

        // ── Category search ───────────────────────────────────────────
        private void txtCatSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtCatSearch.Text == "Search categories...")
            {
                txtCatSearch.Text = "";
                txtCatSearch.ForeColor = SystemColors.ButtonHighlight;
            }
        }

        private void txtCatSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatSearch.Text))
            {
                txtCatSearch.Text = "Search categories...";
                txtCatSearch.ForeColor = Color.FromArgb(82, 82, 110);
            }
        }

        private void txtCatSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCatSearch.Text == "Search categories...") return;
            string q = txtCatSearch.Text.ToLower();

            // Call backend again and filter
            Car_Category[] categoriesFromDB = VHSAUTOMOTIVE.display_all_cats();

            var allCategories = new List<CarInfo>();
            foreach (var cat in categoriesFromDB)
            {
                allCategories.Add(new CarInfo
                {
                    CarType = cat.Car_Type,
                    Make = cat.Make,
                    Model = cat.Model,
                    ModelYear = cat.Model_Year,
                    Transmission = cat.Transmission,
                    DailyRate = cat.Daily_Rental_Rate,
                    count = cat.Count
                });
            }

            // Filter by search query AND exclude 0-count categories
            filteredCategories = allCategories
                .Where(c =>
                {
                    bool hasAvailable = c.count > 0;
                    bool matchesSearch = c.Make.ToLower().Contains(q) ||
                                       c.Model.ToLower().Contains(q) ||
                                       c.CarType.ToLower().Contains(q);
                    return hasAvailable && matchesSearch;
                })
                .ToList();

            RefreshCategoryCards();
        }

        // ── Save ──────────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Client clientcheck = VHSAUTOMOTIVE.find_client(int.Parse(txtLicenceNo.Text));

            if (clientcheck == null) {
                clientcheck = new Client
                {
                    Driver_License_Number = int.Parse(txtLicenceNo.Text), 
                    First_Name = txtFirstName.Text,
                    Last_Name = txtLastName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text

                }; 
                VHSAUTOMOTIVE.add_client(clientcheck);

            }

            Payment payments = new Payment
            {
                Payment_Method = cmbPaymentMethod.SelectedItem.ToString(),
                Client_ID = int.Parse(txtLicenceNo.Text),
                Emp_ID= this.currentEmployeeID

            };

            Car_Category cat = new Car_Category
            {
                Car_Type = selectedCategory.CarType,
                Make = selectedCategory.Make,
                Model = selectedCategory.Model,
                Model_Year = selectedCategory.ModelYear,
                Transmission = selectedCategory.Transmission,
                Daily_Rental_Rate = selectedCategory.DailyRate
            };

            int cat_ID = VHSAUTOMOTIVE.catID_fro_desc(cat);

            int paymentID = VHSAUTOMOTIVE.add_payment(payments);


            var reservationData = new ReservationHorse
            {

                LicenseNo = int.Parse(txtLicenceNo.Text),

                Reservation_Date = dtpResDate.Value,
                Deadline = dtpDeadline.Value, 
                Pickup_Branch_ID = currentBranchID, 
                Payment_ID = paymentID,
                Category_ID = cat_ID

            };
            VHSAUTOMOTIVE.add_reservation(reservationData);

            bool createNewClient = !clientFound;

            MessageBox.Show("Reservation saved.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtLicenceNo.Text))
            {
                MessageBox.Show("Licence number is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenceNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Client details are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a car category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentMethod.Focus();
                return false;
            }
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Payment amount must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAmount.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}