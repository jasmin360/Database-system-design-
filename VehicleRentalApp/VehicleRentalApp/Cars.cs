using System;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Cars : UserControl
    {
        public Cars()
        {
            InitializeComponent();

            addOptions.Visible = false;
            filterPanel.Visible = false;

            plus.Click += (s, e) =>
            {
                filterPanel.Visible = false;
                addOptions.Visible = !addOptions.Visible;
            };

            addCar.Click += (s, e) =>
            {
                addOptions.Visible = false;
                new AddCar().ShowDialog();
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
        }

        private void right_Click(object sender, EventArgs e)
        {
            addOptions.Visible = false;
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void Cars_Load(object sender, EventArgs e) { }
    }
}