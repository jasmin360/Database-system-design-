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
    public partial class MainnForm : Form
    {
        public MainnForm()
        {
            InitializeComponent();
            button1.Click += (sender, e) => Button1_Click(sender, e);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dashboard secondForm = new Dashboard();
            secondForm.Show(); // Or secondForm.ShowDialog();
            this.Hide();       // Optional: Hides the current form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainnForm_Load(object sender, EventArgs e)
        {

        }

        private void MainnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
