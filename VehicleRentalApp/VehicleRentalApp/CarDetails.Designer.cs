namespace VehicleRentalApp
{
    partial class CarDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCarSection = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.lblPlateK = new System.Windows.Forms.Label();
            this.lblPlateV = new System.Windows.Forms.Label();
            this.lblCondK = new System.Windows.Forms.Label();
            this.lblCondV = new System.Windows.Forms.Label();
            this.lblSeatsK = new System.Windows.Forms.Label();
            this.lblSeatsV = new System.Windows.Forms.Label();
            this.lblMileK = new System.Windows.Forms.Label();
            this.lblMileV = new System.Windows.Forms.Label();
            this.lblColK = new System.Windows.Forms.Label();
            this.lblColV = new System.Windows.Forms.Label();
            this.lblCatSection = new System.Windows.Forms.Label();
            this.panelCat = new System.Windows.Forms.Panel();
            this.lblTypeK = new System.Windows.Forms.Label();
            this.lblTypeV = new System.Windows.Forms.Label();
            this.lblMakeK = new System.Windows.Forms.Label();
            this.lblMakeV = new System.Windows.Forms.Label();
            this.lblModelK = new System.Windows.Forms.Label();
            this.lblModelV = new System.Windows.Forms.Label();
            this.lblYearK = new System.Windows.Forms.Label();
            this.lblYearV = new System.Windows.Forms.Label();
            this.lblTransK = new System.Windows.Forms.Label();
            this.lblTransV = new System.Windows.Forms.Label();
            this.lblRateK = new System.Windows.Forms.Label();
            this.lblRateV = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCar.SuspendLayout();
            this.panelCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(980, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarSection
            // 
            this.lblCarSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCarSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCarSection.Location = new System.Drawing.Point(30, 65);
            this.lblCarSection.Name = "lblCarSection";
            this.lblCarSection.Size = new System.Drawing.Size(200, 30);
            this.lblCarSection.TabIndex = 1;
            this.lblCarSection.Text = "Car Details";
            // 
            // panelCar
            // 
            this.panelCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.lblPlateK);
            this.panelCar.Controls.Add(this.lblPlateV);
            this.panelCar.Controls.Add(this.lblCondK);
            this.panelCar.Controls.Add(this.lblCondV);
            this.panelCar.Controls.Add(this.lblSeatsK);
            this.panelCar.Controls.Add(this.lblSeatsV);
            this.panelCar.Controls.Add(this.lblMileK);
            this.panelCar.Controls.Add(this.lblMileV);
            this.panelCar.Controls.Add(this.lblColK);
            this.panelCar.Controls.Add(this.lblColV);
            this.panelCar.Location = new System.Drawing.Point(30, 100);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(440, 310);
            this.panelCar.TabIndex = 2;
            // 
            // lblPlateK
            // 
            this.lblPlateK.AutoSize = true;
            this.lblPlateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPlateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPlateK.Location = new System.Drawing.Point(15, 25);
            this.lblPlateK.Name = "lblPlateK";
            this.lblPlateK.Size = new System.Drawing.Size(118, 24);
            this.lblPlateK.TabIndex = 0;
            this.lblPlateK.Text = "License Plate";
            // 
            // lblPlateV
            // 
            this.lblPlateV.AutoSize = true;
            this.lblPlateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPlateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPlateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlateV.Location = new System.Drawing.Point(200, 25);
            this.lblPlateV.Name = "lblPlateV";
            this.lblPlateV.Size = new System.Drawing.Size(0, 24);
            this.lblPlateV.TabIndex = 1;
            // 
            // lblCondK
            // 
            this.lblCondK.AutoSize = true;
            this.lblCondK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCondK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCondK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCondK.Location = new System.Drawing.Point(15, 75);
            this.lblCondK.Name = "lblCondK";
            this.lblCondK.Size = new System.Drawing.Size(93, 24);
            this.lblCondK.TabIndex = 2;
            this.lblCondK.Text = "Condition";
            // 
            // lblCondV
            // 
            this.lblCondV.AutoSize = true;
            this.lblCondV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCondV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCondV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCondV.Location = new System.Drawing.Point(200, 75);
            this.lblCondV.Name = "lblCondV";
            this.lblCondV.Size = new System.Drawing.Size(0, 24);
            this.lblCondV.TabIndex = 3;
            // 
            // lblSeatsK
            // 
            this.lblSeatsK.AutoSize = true;
            this.lblSeatsK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSeatsK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeatsK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblSeatsK.Location = new System.Drawing.Point(15, 125);
            this.lblSeatsK.Name = "lblSeatsK";
            this.lblSeatsK.Size = new System.Drawing.Size(88, 24);
            this.lblSeatsK.TabIndex = 4;
            this.lblSeatsK.Text = "No. Seats";
            // 
            // lblSeatsV
            // 
            this.lblSeatsV.AutoSize = true;
            this.lblSeatsV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSeatsV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblSeatsV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeatsV.Location = new System.Drawing.Point(200, 125);
            this.lblSeatsV.Name = "lblSeatsV";
            this.lblSeatsV.Size = new System.Drawing.Size(0, 24);
            this.lblSeatsV.TabIndex = 5;
            // 
            // lblMileK
            // 
            this.lblMileK.AutoSize = true;
            this.lblMileK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMileK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMileK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMileK.Location = new System.Drawing.Point(15, 175);
            this.lblMileK.Name = "lblMileK";
            this.lblMileK.Size = new System.Drawing.Size(119, 24);
            this.lblMileK.TabIndex = 6;
            this.lblMileK.Text = "Mileage (km)";
            // 
            // lblMileV
            // 
            this.lblMileV.AutoSize = true;
            this.lblMileV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMileV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMileV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMileV.Location = new System.Drawing.Point(200, 175);
            this.lblMileV.Name = "lblMileV";
            this.lblMileV.Size = new System.Drawing.Size(0, 24);
            this.lblMileV.TabIndex = 7;
            // 
            // lblColK
            // 
            this.lblColK.AutoSize = true;
            this.lblColK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblColK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblColK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblColK.Location = new System.Drawing.Point(15, 225);
            this.lblColK.Name = "lblColK";
            this.lblColK.Size = new System.Drawing.Size(66, 24);
            this.lblColK.TabIndex = 8;
            this.lblColK.Text = "Colour";
            // 
            // lblColV
            // 
            this.lblColV.AutoSize = true;
            this.lblColV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblColV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblColV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColV.Location = new System.Drawing.Point(200, 225);
            this.lblColV.Name = "lblColV";
            this.lblColV.Size = new System.Drawing.Size(0, 24);
            this.lblColV.TabIndex = 9;
            // 
            // lblCatSection
            // 
            this.lblCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCatSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCatSection.Location = new System.Drawing.Point(510, 65);
            this.lblCatSection.Name = "lblCatSection";
            this.lblCatSection.Size = new System.Drawing.Size(200, 30);
            this.lblCatSection.TabIndex = 3;
            this.lblCatSection.Text = "Category Details";
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCat.Controls.Add(this.lblTypeK);
            this.panelCat.Controls.Add(this.lblTypeV);
            this.panelCat.Controls.Add(this.lblMakeK);
            this.panelCat.Controls.Add(this.lblMakeV);
            this.panelCat.Controls.Add(this.lblModelK);
            this.panelCat.Controls.Add(this.lblModelV);
            this.panelCat.Controls.Add(this.lblYearK);
            this.panelCat.Controls.Add(this.lblYearV);
            this.panelCat.Controls.Add(this.lblTransK);
            this.panelCat.Controls.Add(this.lblTransV);
            this.panelCat.Controls.Add(this.lblRateK);
            this.panelCat.Controls.Add(this.lblRateV);
            this.panelCat.Location = new System.Drawing.Point(510, 100);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(440, 310);
            this.panelCat.TabIndex = 4;
            // 
            // lblTypeK
            // 
            this.lblTypeK.AutoSize = true;
            this.lblTypeK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTypeK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblTypeK.Location = new System.Drawing.Point(15, 25);
            this.lblTypeK.Name = "lblTypeK";
            this.lblTypeK.Size = new System.Drawing.Size(82, 24);
            this.lblTypeK.TabIndex = 0;
            this.lblTypeK.Text = "Car Type";
            // 
            // lblTypeV
            // 
            this.lblTypeV.AutoSize = true;
            this.lblTypeV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTypeV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTypeV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTypeV.Location = new System.Drawing.Point(200, 25);
            this.lblTypeV.Name = "lblTypeV";
            this.lblTypeV.Size = new System.Drawing.Size(0, 24);
            this.lblTypeV.TabIndex = 1;
            // 
            // lblMakeK
            // 
            this.lblMakeK.AutoSize = true;
            this.lblMakeK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMakeK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMakeK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMakeK.Location = new System.Drawing.Point(15, 70);
            this.lblMakeK.Name = "lblMakeK";
            this.lblMakeK.Size = new System.Drawing.Size(56, 24);
            this.lblMakeK.TabIndex = 2;
            this.lblMakeK.Text = "Make";
            // 
            // lblMakeV
            // 
            this.lblMakeV.AutoSize = true;
            this.lblMakeV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMakeV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMakeV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeV.Location = new System.Drawing.Point(200, 70);
            this.lblMakeV.Name = "lblMakeV";
            this.lblMakeV.Size = new System.Drawing.Size(0, 24);
            this.lblMakeV.TabIndex = 3;
            // 
            // lblModelK
            // 
            this.lblModelK.AutoSize = true;
            this.lblModelK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModelK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblModelK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblModelK.Location = new System.Drawing.Point(15, 115);
            this.lblModelK.Name = "lblModelK";
            this.lblModelK.Size = new System.Drawing.Size(64, 24);
            this.lblModelK.TabIndex = 4;
            this.lblModelK.Text = "Model";
            // 
            // lblModelV
            // 
            this.lblModelV.AutoSize = true;
            this.lblModelV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModelV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblModelV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelV.Location = new System.Drawing.Point(200, 115);
            this.lblModelV.Name = "lblModelV";
            this.lblModelV.Size = new System.Drawing.Size(0, 24);
            this.lblModelV.TabIndex = 5;
            // 
            // lblYearK
            // 
            this.lblYearK.AutoSize = true;
            this.lblYearK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblYearK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblYearK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblYearK.Location = new System.Drawing.Point(15, 160);
            this.lblYearK.Name = "lblYearK";
            this.lblYearK.Size = new System.Drawing.Size(104, 24);
            this.lblYearK.TabIndex = 6;
            this.lblYearK.Text = "Model Year";
            // 
            // lblYearV
            // 
            this.lblYearV.AutoSize = true;
            this.lblYearV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblYearV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblYearV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYearV.Location = new System.Drawing.Point(200, 160);
            this.lblYearV.Name = "lblYearV";
            this.lblYearV.Size = new System.Drawing.Size(0, 24);
            this.lblYearV.TabIndex = 7;
            // 
            // lblTransK
            // 
            this.lblTransK.AutoSize = true;
            this.lblTransK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTransK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblTransK.Location = new System.Drawing.Point(15, 205);
            this.lblTransK.Name = "lblTransK";
            this.lblTransK.Size = new System.Drawing.Size(119, 24);
            this.lblTransK.TabIndex = 8;
            this.lblTransK.Text = "Transmission";
            // 
            // lblTransV
            // 
            this.lblTransV.AutoSize = true;
            this.lblTransV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTransV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTransV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransV.Location = new System.Drawing.Point(200, 205);
            this.lblTransV.Name = "lblTransV";
            this.lblTransV.Size = new System.Drawing.Size(0, 24);
            this.lblTransV.TabIndex = 9;
            // 
            // lblRateK
            // 
            this.lblRateK.AutoSize = true;
            this.lblRateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblRateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblRateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblRateK.Location = new System.Drawing.Point(15, 250);
            this.lblRateK.Name = "lblRateK";
            this.lblRateK.Size = new System.Drawing.Size(95, 24);
            this.lblRateK.TabIndex = 10;
            this.lblRateK.Text = "Daily Rate";
            // 
            // lblRateV
            // 
            this.lblRateV.AutoSize = true;
            this.lblRateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblRateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblRateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRateV.Location = new System.Drawing.Point(200, 250);
            this.lblRateV.Name = "lblRateV";
            this.lblRateV.Size = new System.Drawing.Size(0, 24);
            this.lblRateV.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnClose.Location = new System.Drawing.Point(715, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.edit.BackgroundImage = global::VehicleRentalApp.Properties.Resources.compose__1_1;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.Location = new System.Drawing.Point(921, 59);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(29, 31);
            this.edit.TabIndex = 42;
            this.edit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.button1.BackgroundImage = global::VehicleRentalApp.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(894, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 50);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(980, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCarSection);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.lblCatSection);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Details";
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle, lblCarSection, lblCatSection;
        private System.Windows.Forms.Panel panelCar, panelCat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPlateK, lblPlateV, lblCondK, lblCondV,
                                           lblSeatsK, lblSeatsV, lblMileK, lblMileV,
                                           lblColK, lblColV;
        private System.Windows.Forms.Label lblTypeK, lblTypeV, lblMakeK, lblMakeV,
                                           lblModelK, lblModelV, lblYearK, lblYearV,
                                           lblTransK, lblTransV, lblRateK, lblRateV;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button button1;
    }
}