using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Cars : UserControl
    {
        public Cars()
        {
            InitializeComponent();
            filterPanel.Visible = false;

            plus.Click += (s, e) =>
            {
                filterPanel.Visible = false;
                if (new AddCar().ShowDialog() == DialogResult.OK)
                    LoadCars(); // refresh after adding
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

        private void LoadCars()
        {
            // demo data — replace with DB query later
            var cars = new List<CarInfo>
            {
                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false },
                                new CarInfo { LicensePlate="ABC-1234", Condition="Reserved", Seats=5, Mileage=15000,
                              Colour="White",  CarType="SUV",       Make="Toyota",  Model="RAV4",
                              ModelYear=2022, Transmission="Automatic", DailyRate=65,  IsReserved=false },
                new CarInfo { LicensePlate="XYZ-9876", Condition="Free",      Seats=4, Mileage=42000,
                              Colour="Black",  CarType="Hatchback", Make="Honda",   Model="Civic",
                              ModelYear=2020, Transmission="Manual",    DailyRate=40,  IsReserved=true  },
                new CarInfo { LicensePlate="LUX-0001", Condition="Excellent", Seats=4, Mileage=8000,
                              Colour="Silver", CarType="Sedan",     Make="BMW",     Model="5 Series",
                              ModelYear=2023, Transmission="Automatic", DailyRate=180, IsReserved=false },
                new CarInfo { LicensePlate="VAN-4421", Condition="Fair",      Seats=8, Mileage=98000,
                              Colour="Grey",   CarType="Coupe",     Make="Ford",    Model="Mustang",
                              ModelYear=2018, Transmission="Manual",    DailyRate=85,  IsReserved=false },
                new CarInfo { LicensePlate="PIC-2210", Condition="Good",      Seats=4, Mileage=27000,
                              Colour="Red",    CarType="Picanto",   Make="Kia",     Model="Picanto",
                              ModelYear=2021, Transmission="Manual",    DailyRate=30,  IsReserved=false }

            };

            flowLayoutPanel1.Controls.Clear();
            foreach (var car in cars)
                flowLayoutPanel1.Controls.Add(new CarCard(car));
        }

        private void right_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}