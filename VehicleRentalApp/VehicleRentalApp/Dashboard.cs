using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SetupLayout();
            NavigateTo(new overview());
            profilePic.Click += (sender, e) => Display_side_bar(sender, e);



        }

        private void Display_side_bar(object sender, EventArgs e) {
            sidePanel.Visible = !sidePanel.Visible;

        }

        private void SetupLayout() {
            ovBtn.Click += (s, e) => NavigateTo(new overview());
            carBtn.Click += (s, e) => NavigateTo(new Cars());
            //ResBtn.Click += (s, e) => NavigateTo(new Reservations());

        }
        private void NavigateTo(UserControl screen)
        {
            contentPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;

            if (screen is overview ov)
            {
                ov.NavigateRequested += (s, e) => NavigateTo(new recentRes());
                highlightButton(ovBtn);
            }
            else if (screen is recentRes rr)
            {
                rr.NavigateRequested += (s, e) => NavigateTo(new overview());
                highlightButton(ovBtn); // same button, both are overview screens
            }
            else if (screen is Cars)
            {
                highlightButton(carBtn);
            }

            contentPanel.Controls.Add(screen);
        }


        private void highlightButton(Button button)
        {
            ovBtn.BackColor = Color.FromArgb(23, 22, 54);
            ovBtn.ForeColor = Color.FromArgb(82, 82, 110);
            carBtn.BackColor = Color.FromArgb(23, 22, 54);
            carBtn.ForeColor = Color.FromArgb(82, 82, 110);
            ResBtn.BackColor = Color.FromArgb(23, 22, 54);
            ResBtn.ForeColor = Color.FromArgb(82, 82, 110);

            button.BackColor = Color.FromArgb(29, 26, 73);
            button.ForeColor = Color.FromArgb(112, 105, 181);
        }
        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void BranchLoc_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empNameGreet_Click(object sender, EventArgs e)
        {

        }

        private void profilePic_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            contentPanel.Top = -e.NewValue;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
