using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class Dashboard : Form
    {
        Employee employee = null;
        Branch branchitself = null;
        String branchname = "";
        int totalcarsperbranch = 0;
        Car[] availablecars= null;
        int availablecarsno = 0;
        Double revenue = 0.0;

        public Dashboard(Employee employee)
        {
            InitializeComponent();
            SetupLayout();
            NavigateTo(new overview());
            this.employee = employee;
            this.branchitself = VHSAUTOMOTIVE.branch_details_from_employee(employee.Email);
            this.branchname = this.branchitself.City;
            branch.Text = this.branchname;
            this.totalcarsperbranch= VHSAUTOMOTIVE.total_cars_in_branch(this.employee.Branch_ID);
            this.availablecars = VHSAUTOMOTIVE.Get_Available_Cars_In_Branch(this.employee.Branch_ID);
            this.availablecarsno = this.availablecars.Length;
            label3.Text = this.totalcarsperbranch.ToString();
            label4.Text = this.availablecarsno.ToString();
            this.revenue = VHSAUTOMOTIVE.branch_revenue(this.employee.Branch_ID);
            label1.Text = this.revenue.ToString() + " $";
            label7.Text = this.employee.First_Name + " " + this.employee.Last_Name;
            label8.Text = this.employee.Email;
            if (!(employee.Position == "Supervisor"))
            {
                button2.Visible = false;
            }

            //profilePic.Click += (sender, e) => Display_side_bar(sender, e);



        }

        //private void Display_side_bar(object sender, EventArgs e) {
        //    side_Panel.Visible = !side_Panel.Visible;

        //}

        private void SetupLayout() {
            ovBtn.Click += (s, e) => NavigateTo(new overview());
            carBtn.Click += (s, e) => NavigateTo(new Cars(this.branchitself));
            ResBtn.Click += (s, e) => NavigateTo(new Reservation(this.employee.Emp_ID, this.branchitself.Branch_ID));

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
            else if(screen is Reservation)
            {
                highlightButton(ResBtn);

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
            side_panel.Visible = false;
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
            side_panel.Visible = true;

            side_panel.BringToFront();
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

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BranchDetails branchDetails = new BranchDetails(this.branchitself);

            branchDetails.ShowDialog();
        }

        private void branch_Click(object sender, EventArgs e)
        {
            BranchDetails branchDetails = new BranchDetails(this.branchitself);

            branchDetails.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            MainnForm mainForm = new MainnForm();

            mainForm.ShowDialog();

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails(employee, employee.Emp_ID);

            employeeDetails.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Employees employees = new Employees(this.branchitself.Branch_ID, this.employee.Emp_ID, this.branchitself.City);

            employees.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
