using System;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class CategoryCard : UserControl
    {
        public CarInfo Data { get; private set; }
        public event EventHandler CardSelected;

        private static readonly Color BgNormal = Color.FromArgb(23, 22, 54);
        private static readonly Color BgSelected = Color.FromArgb(29, 26, 73);
        private static readonly Color BorderSel = Color.FromArgb(112, 105, 181);

        public CategoryCard(CarInfo data, int availableCount)
        {
            InitializeComponent();
            Data = data;

            lblMakeModel.Text = $"{data.Make} {data.Model}";
            lblType.Text = data.CarType;
            lblYear.Text = data.ModelYear.ToString();
            lblTrans.Text = data.Transmission;
            lblRate.Text = $"${data.DailyRate:0.##}/day";
            lblAvailable.Text = $"{availableCount} available";

            // colour the count badge depending on availability
            if (availableCount == 0)
            {
                lblAvailable.ForeColor = Color.FromArgb(200, 80, 80);
                lblAvailable.BackColor = Color.FromArgb(40, 10, 10);
            }
            else if (availableCount <= 2)
            {
                lblAvailable.ForeColor = Color.FromArgb(200, 160, 60);
                lblAvailable.BackColor = Color.FromArgb(40, 30, 10);
            }
            else
            {
                lblAvailable.ForeColor = Color.FromArgb(82, 180, 110);
                lblAvailable.BackColor = Color.FromArgb(10, 40, 20);
            }

            this.Click += SelectCard;
            foreach (Control c in this.Controls)
                c.Click += SelectCard;
        }

        public void SetSelected(bool selected)
        {
            this.BackColor = selected ? BgSelected : BgNormal;
            foreach (Control c in this.Controls)
            {
                if (c == lblType || c == lblAvailable) continue;
                c.BackColor = Color.Transparent;
            }
        }

        private void SelectCard(object sender, EventArgs e)
        {
            CardSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}