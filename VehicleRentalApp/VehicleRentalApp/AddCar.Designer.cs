namespace VehicleRentalApp
{
    partial class AddCar
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
            this.panelCarSection = new System.Windows.Forms.Panel();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.lblMileage = new System.Windows.Forms.Label();
            this.numMileage = new System.Windows.Forms.NumericUpDown();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblCatSection = new System.Windows.Forms.Label();
            this.panelCatSection = new System.Windows.Forms.Panel();
            this.lblCarType = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.numModelYear = new System.Windows.Forms.NumericUpDown();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.cmbTransmission = new System.Windows.Forms.ComboBox();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.numDailyRate = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCarSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).BeginInit();
            this.panelCatSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(42, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Car";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarSection
            // 
            this.lblCarSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCarSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCarSection.Location = new System.Drawing.Point(12, 61);
            this.lblCarSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarSection.Name = "lblCarSection";
            this.lblCarSection.Size = new System.Drawing.Size(100, 16);
            this.lblCarSection.TabIndex = 1;
            this.lblCarSection.Text = "Car Details";
            // 
            // panelCarSection
            // 
            this.panelCarSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCarSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCarSection.Controls.Add(this.lblLicensePlate);
            this.panelCarSection.Controls.Add(this.txtLicensePlate);
            this.panelCarSection.Controls.Add(this.lblCondition);
            this.panelCarSection.Controls.Add(this.cmbCondition);
            this.panelCarSection.Controls.Add(this.lblSeats);
            this.panelCarSection.Controls.Add(this.numSeats);
            this.panelCarSection.Controls.Add(this.lblMileage);
            this.panelCarSection.Controls.Add(this.numMileage);
            this.panelCarSection.Controls.Add(this.lblColour);
            this.panelCarSection.Controls.Add(this.txtColour);
            this.panelCarSection.Location = new System.Drawing.Point(15, 94);
            this.panelCarSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCarSection.Name = "panelCarSection";
            this.panelCarSection.Size = new System.Drawing.Size(253, 205);
            this.panelCarSection.TabIndex = 2;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLicensePlate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLicensePlate.Location = new System.Drawing.Point(8, 10);
            this.lblLicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(83, 17);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "License Plate";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicensePlate.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLicensePlate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicensePlate.Location = new System.Drawing.Point(100, 9);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(106, 24);
            this.txtLicensePlate.TabIndex = 1;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCondition.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCondition.Location = new System.Drawing.Point(8, 39);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(66, 17);
            this.lblCondition.TabIndex = 2;
            this.lblCondition.Text = "Condition";
            // 
            // cmbCondition
            // 
            this.cmbCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondition.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbCondition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbCondition.Items.AddRange(new object[] {
            "Reserved",
            "Free",
            });
            this.cmbCondition.Location = new System.Drawing.Point(100, 37);
            this.cmbCondition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(106, 23);
            this.cmbCondition.TabIndex = 3;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSeats.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblSeats.Location = new System.Drawing.Point(8, 68);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(64, 17);
            this.lblSeats.TabIndex = 4;
            this.lblSeats.Text = "No. Seats";
            // 
            // numSeats
            // 
            this.numSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.numSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSeats.Font = new System.Drawing.Font("Calibri", 10F);
            this.numSeats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numSeats.Location = new System.Drawing.Point(100, 66);
            this.numSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSeats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(105, 24);
            this.numSeats.TabIndex = 5;
            this.numSeats.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMileage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMileage.Location = new System.Drawing.Point(8, 96);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(83, 17);
            this.lblMileage.TabIndex = 6;
            this.lblMileage.Text = "Mileage (km)";
            // 
            // numMileage
            // 
            this.numMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.numMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMileage.Font = new System.Drawing.Font("Calibri", 10F);
            this.numMileage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numMileage.Location = new System.Drawing.Point(100, 95);
            this.numMileage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMileage.Name = "numMileage";
            this.numMileage.Size = new System.Drawing.Size(105, 24);
            this.numMileage.TabIndex = 7;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblColour.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblColour.Location = new System.Drawing.Point(8, 125);
            this.lblColour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(47, 17);
            this.lblColour.TabIndex = 8;
            this.lblColour.Text = "Colour";
            // 
            // txtColour
            // 
            this.txtColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColour.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtColour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtColour.Location = new System.Drawing.Point(100, 123);
            this.txtColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(106, 24);
            this.txtColour.TabIndex = 9;
            // 
            // lblCatSection
            // 
            this.lblCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCatSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCatSection.Location = new System.Drawing.Point(278, 61);
            this.lblCatSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatSection.Name = "lblCatSection";
            this.lblCatSection.Size = new System.Drawing.Size(152, 31);
            this.lblCatSection.TabIndex = 3;
            this.lblCatSection.Text = "Category Details";
            // 
            // panelCatSection
            // 
            this.panelCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCatSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCatSection.Controls.Add(this.lblCarType);
            this.panelCatSection.Controls.Add(this.cmbCarType);
            this.panelCatSection.Controls.Add(this.lblMake);
            this.panelCatSection.Controls.Add(this.txtMake);
            this.panelCatSection.Controls.Add(this.lblModel);
            this.panelCatSection.Controls.Add(this.txtModel);
            this.panelCatSection.Controls.Add(this.lblModelYear);
            this.panelCatSection.Controls.Add(this.numModelYear);
            this.panelCatSection.Controls.Add(this.lblTransmission);
            this.panelCatSection.Controls.Add(this.cmbTransmission);
            this.panelCatSection.Controls.Add(this.lblDailyRate);
            this.panelCatSection.Controls.Add(this.numDailyRate);
            this.panelCatSection.Location = new System.Drawing.Point(281, 94);
            this.panelCatSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCatSection.Name = "panelCatSection";
            this.panelCatSection.Size = new System.Drawing.Size(252, 205);
            this.panelCatSection.TabIndex = 4;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCarType.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCarType.Location = new System.Drawing.Point(8, 10);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(59, 17);
            this.lblCarType.TabIndex = 0;
            this.lblCarType.Text = "Car Type";
            // 
            // cmbCarType
            // 
            this.cmbCarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarType.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbCarType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbCarType.Items.AddRange(new object[] {
            "Picanto",
            "SUV",
            "Coupe",
            "Sedan",
            "Hatchback"});
            this.cmbCarType.Location = new System.Drawing.Point(135, 9);
            this.cmbCarType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(106, 23);
            this.cmbCarType.TabIndex = 1;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMake.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMake.Location = new System.Drawing.Point(8, 39);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(41, 17);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMake.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtMake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMake.Location = new System.Drawing.Point(135, 39);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(106, 24);
            this.txtMake.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblModel.Location = new System.Drawing.Point(8, 68);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtModel.Location = new System.Drawing.Point(135, 67);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(106, 24);
            this.txtModel.TabIndex = 5;
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModelYear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblModelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblModelYear.Location = new System.Drawing.Point(8, 96);
            this.lblModelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(74, 17);
            this.lblModelYear.TabIndex = 6;
            this.lblModelYear.Text = "Model Year";
            // 
            // numModelYear
            // 
            this.numModelYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.numModelYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numModelYear.Font = new System.Drawing.Font("Calibri", 10F);
            this.numModelYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numModelYear.Location = new System.Drawing.Point(135, 92);
            this.numModelYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numModelYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numModelYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numModelYear.Name = "numModelYear";
            this.numModelYear.Size = new System.Drawing.Size(105, 24);
            this.numModelYear.TabIndex = 7;
            this.numModelYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTransmission.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblTransmission.Location = new System.Drawing.Point(8, 125);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(85, 17);
            this.lblTransmission.TabIndex = 8;
            this.lblTransmission.Text = "Transmission";
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransmission.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTransmission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "DCT",
            "CVT",
            "AMT"});
            this.cmbTransmission.Location = new System.Drawing.Point(135, 121);
            this.cmbTransmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(105, 23);
            this.cmbTransmission.TabIndex = 9;
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblDailyRate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblDailyRate.Location = new System.Drawing.Point(8, 151);
            this.lblDailyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(108, 17);
            this.lblDailyRate.TabIndex = 10;
            this.lblDailyRate.Text = "Daily Rental Rate";
            // 
            // numDailyRate
            // 
            this.numDailyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.numDailyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDailyRate.DecimalPlaces = 2;
            this.numDailyRate.Font = new System.Drawing.Font("Calibri", 10F);
            this.numDailyRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numDailyRate.Location = new System.Drawing.Point(135, 147);
            this.numDailyRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDailyRate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDailyRate.Name = "numDailyRate";
            this.numDailyRate.Size = new System.Drawing.Size(105, 24);
            this.numDailyRate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnSave.Location = new System.Drawing.Point(358, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCancel.Location = new System.Drawing.Point(452, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(544, 392);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCarSection);
            this.Controls.Add(this.panelCarSection);
            this.Controls.Add(this.lblCatSection);
            this.Controls.Add(this.panelCatSection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Car";
            this.panelCarSection.ResumeLayout(false);
            this.panelCarSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMileage)).EndInit();
            this.panelCatSection.ResumeLayout(false);
            this.panelCatSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyRate)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCarSection;
        private System.Windows.Forms.Panel panelCarSection;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.NumericUpDown numMileage;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblCatSection;
        private System.Windows.Forms.Panel panelCatSection;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.NumericUpDown numModelYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.ComboBox cmbTransmission;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.NumericUpDown numDailyRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}