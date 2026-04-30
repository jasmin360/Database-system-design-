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
    public partial class overview : UserControl
    {
        public event EventHandler NavigateRequested;

        public overview()
        {
            InitializeComponent();
            left.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
            right.Click += (s, e) => NavigateRequested?.Invoke(this, EventArgs.Empty);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void profilePic_Click(object sender, EventArgs e)
        {

        }
    }
}
