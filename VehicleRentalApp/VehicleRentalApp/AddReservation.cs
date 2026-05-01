using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class AddReservation : Form
    {
        private List<CarInfo> _allCategories = new List<CarInfo>
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

        private Dictionary<string, int> _availableCounts = new Dictionary<string, int>
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

        private List<CarInfo> _filteredCategories;
        private CarInfo _selectedCategory = null;
        private CategoryCard _selectedCard = null;
        private bool _clientFound = false;

        public AddReservation()
        {
            InitializeComponent();

            dtpResDate.Value = DateTime.Today;
            dtpDeadline.Value = DateTime.Today.AddDays(7);
            dtpPickupDate.Value = DateTime.Today;

            SetClientFieldsEnabled(false);

            this.Load += AddReservation_Load;
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            _filteredCategories = new List<CarInfo>(_allCategories);
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
                _clientFound = true;
            }
            else
            {
                ClearClientFields();
                SetClientFieldsEnabled(true);
                lblClientStatus.Text = "Client not found. Fill in details to create a new client.";
                lblClientStatus.ForeColor = Color.FromArgb(200, 160, 60);
                _clientFound = false;
            }
        }

        private void txtLicenceNo_TextChanged(object sender, EventArgs e)
        {
            ClearClientFields();
            SetClientFieldsEnabled(false);
            lblClientStatus.Text = "Enter a licence number and click Look Up";
            lblClientStatus.ForeColor = Color.FromArgb(82, 82, 110);
            _clientFound = false;
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
            foreach (var c in _filteredCategories)
            {
                string key = $"{c.Make} {c.Model}";
                int count = _availableCounts.ContainsKey(key) ? _availableCounts[key] : 0;

                var card = new CategoryCard(c, count);
                card.CardSelected += Card_Selected;
                flowCategories.Controls.Add(card);
            }
        }

        private void Card_Selected(object sender, EventArgs e)
        {
            var card = (CategoryCard)sender;
            if (_selectedCard != null)
                _selectedCard.SetSelected(false);
            card.SetSelected(true);
            _selectedCard = card;
            _selectedCategory = card.Data;
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
            _filteredCategories = _allCategories
                .Where(c => c.Make.ToLower().Contains(q)
                         || c.Model.ToLower().Contains(q)
                         || c.CarType.ToLower().Contains(q))
                .ToList();
            RefreshCategoryCards();
        }

        // ── Save ──────────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // TODO: insert into DB
            // Reservation fields:
            //   LicenceNo          = txtLicenceNo.Text
            //   Reservation_Status = cmbStatus.SelectedItem
            //   Deadline           = dtpDeadline.Value
            //   Pickup_Date        = dtpPickupDate.Value
            //   Reservation_Date   = dtpResDate.Value
            //   Return_Date        = "Not Returned"
            //   Category_ID        = from _selectedCategory
            //   License_Plate      = assigned from available car in category
            // If !_clientFound: insert new Client first using txtFirstName etc.

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
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Client details are required. Look up or fill in a new client.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_selectedCategory == null)
            {
                MessageBox.Show("Please select a car category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}