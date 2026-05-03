using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class AddReservation : Form
    {
        private List<CarInfo> allCategories = new List<CarInfo>
        {
            new CarInfo { CarType="SUV",        Make="Toyota",     Model="RAV4",      ModelYear=2022, Transmission="Automatic", DailyRate=65  },
            new CarInfo { CarType="Hatchback",  Make="Honda",      Model="Civic",     ModelYear=2020, Transmission="Manual",    DailyRate=40  },
            new CarInfo { CarType="Sedan",      Make="BMW",        Model="5 Series",  ModelYear=2023, Transmission="Automatic", DailyRate=180 },
            new CarInfo { CarType="Coupe",      Make="Ford",       Model="Mustang",   ModelYear=2018, Transmission="Manual",    DailyRate=85  },
            new CarInfo { CarType="Picanto",    Make="Kia",        Model="Picanto",   ModelYear=2021, Transmission="Manual",    DailyRate=30  },
            new CarInfo { CarType="SUV",        Make="Hyundai",    Model="Tucson",    ModelYear=2022, Transmission="Automatic", DailyRate=70  },
            new CarInfo { CarType="Sedan",      Make="Mercedes",   Model="C-Class",   ModelYear=2023, Transmission="Automatic", DailyRate=200 },
            new CarInfo { CarType="Hatchback",  Make="Volkswagen", Model="Golf",      ModelYear=2021, Transmission="Manual",    DailyRate=55  },
            new CarInfo { CarType="Coupe",      Make="Audi",       Model="A5",        ModelYear=2022, Transmission="Automatic", DailyRate=150 },
            new CarInfo { CarType="SUV",        Make="Nissan",     Model="X-Trail",   ModelYear=2020, Transmission="Automatic", DailyRate=60  },
            new CarInfo { CarType="Sedan",      Make="Toyota",     Model="Camry",     ModelYear=2021, Transmission="Automatic", DailyRate=75  },
            new CarInfo { CarType="Hatchback",  Make="Peugeot",    Model="208",       ModelYear=2022, Transmission="Manual",    DailyRate=45  },
        };

        private Dictionary<string, int> availableCounts = new Dictionary<string, int>
        {
            { "Toyota RAV4",        4 },
            { "Honda Civic",        1 },
            { "BMW 5 Series",       0 },
            { "Ford Mustang",       3 },
            { "Kia Picanto",        2 },
            { "Hyundai Tucson",     5 },
            { "Mercedes C-Class",   0 },
            { "Volkswagen Golf",    2 },
            { "Audi A5",            1 },
            { "Nissan X-Trail",     3 },
            { "Toyota Camry",       4 },
            { "Peugeot 208",        6 },
        };

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
            dtpPaymentDate.Value = DateTime.Today; // ADD THIS - Initialize payment date

            SetClientFieldsEnabled(false);

            // Disable auto-filled fields
            cmbStatus.Enabled = false;
            cmbStatus.BackColor = Color.FromArgb(23, 22, 54);

            this.Load += AddReservation_Load;
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0; // Default to "Picked Up"
            cmbPaymentMethod.SelectedIndex = 0; // Default to "Cash"

            // Filter out categories with 0 available cars
            filteredCategories = allCategories.Where(c =>
            {
                string key = $"{c.Make} {c.Model}";
                int count = availableCounts.ContainsKey(key) ? availableCounts[key] : 0;
                return count > 0; // Only show categories with available cars
            }).ToList();

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

            // TODO: replace with real DB lookup
            bool found = licence.ToUpper() == "DL-12345";

            if (found)
            {
                // TODO: populate from DB result
                txtFirstName.Text = "Jane";
                txtLastName.Text = "Doe";
                txtEmail.Text = "jane.doe@email.com";
                txtPhone.Text = "+1 555 0199";

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
                string key = $"{c.Make} {c.Model}";
                int count = availableCounts.ContainsKey(key) ? availableCounts[key] : 0;

                var card = new CategoryCard(c, count);
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

            // Filter from allCategories AND exclude 0-count categories
            filteredCategories = allCategories
                .Where(c =>
                {
                    string key = $"{c.Make} {c.Model}";
                    int count = availableCounts.ContainsKey(key) ? availableCounts[key] : 0;
                    bool hasAvailable = count > 0;
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

            // Collect all data into ReservationChonk
            var reservationData = new ReservationChonk
            {
                // ✓ Client info (from form or DB lookup)
                Driver_License_Number = int.Parse(txtLicenceNo.Text),
                First_Name = txtFirstName.Text,
                Last_Name = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,

                // ✓ Reservation dates (from date pickers)
                Reservation_Date = dtpResDate.Value,
                Deadline = dtpDeadline.Value,
                Pickup_Date = dtpPickupDate.Value,

                // ✓ Auto-filled reservation info
                Reservation_Status = "Pending", // Always pending for new reservations
                Pickup_Branch_ID = currentBranchID, // Current branch
                Return_Branch_ID = null, // Not set yet
                Return_Date = null, // Not returned yet

                // ✓ Category info (from selected card)
                Category_ID = 0, // Backend will assign proper category ID
                Car_Type = selectedCategory.CarType,
                Make = selectedCategory.Make,
                Model = selectedCategory.Model,
                Model_Year = selectedCategory.ModelYear,
                Transmission = selectedCategory.Transmission,
                Daily_Rental_Rate = selectedCategory.DailyRate,

                // ✓ Car info (backend assigns from available cars)
                License_Plate = null, // Backend assigns available car
                Condition = null,     // Backend fills from assigned car
                No_seats = 0,         // Backend fills from assigned car
                Mileage = 0,          // Backend fills from assigned car
                Colour = null,        // Backend fills from assigned car
                Branch_ID = currentBranchID, // Current branch

                // ✓ Payment info (from payment fields)
                Payment_Method = cmbPaymentMethod.SelectedItem.ToString(),
                Payment_Date = dtpPaymentDate.Value, // CHANGED - Use payment date picker

                // ✓ Employee info (from logged-in employee)
                Emp_ID = currentEmployeeID,

                // Not used in this form
                Reservation_ID = 0, // Backend assigns
                Payment_ID = 0      // Backend assigns
            };

            // TODO: Call backend to save
            // bool createNewClient = !clientFound;
            // VHSAUTOMOTIVE.add_reservation(reservationData, createNewClient);

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