namespace VehicleRentalApp
{
    partial class AddReservation
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
            this.lblClientSection = new System.Windows.Forms.Label();
            this.panelClient = new System.Windows.Forms.Panel();
            this.lblClientStatus = new System.Windows.Forms.Label();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.txtLicenceNo = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblResSection = new System.Windows.Forms.Label();
            this.panelRes = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblPickupDate = new System.Windows.Forms.Label();
            this.dtpPickupDate = new System.Windows.Forms.DateTimePicker();
            this.lblResDate = new System.Windows.Forms.Label();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.lblCatSection = new System.Windows.Forms.Label();
            this.panelCat = new System.Windows.Forms.Panel();
            this.txtCatSearch = new System.Windows.Forms.TextBox();
            this.flowCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelClient.SuspendLayout();
            this.panelRes.SuspendLayout();
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
            this.lblTitle.Text = "New Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientSection
            // 
            this.lblClientSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblClientSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblClientSection.Location = new System.Drawing.Point(20, 65);
            this.lblClientSection.Name = "lblClientSection";
            this.lblClientSection.Size = new System.Drawing.Size(200, 30);
            this.lblClientSection.TabIndex = 1;
            this.lblClientSection.Text = "Client";
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClient.Controls.Add(this.lblClientStatus);
            this.panelClient.Controls.Add(this.lblLicenceNo);
            this.panelClient.Controls.Add(this.txtLicenceNo);
            this.panelClient.Controls.Add(this.btnLookup);
            this.panelClient.Controls.Add(this.lblFirstName);
            this.panelClient.Controls.Add(this.txtFirstName);
            this.panelClient.Controls.Add(this.lblLastName);
            this.panelClient.Controls.Add(this.txtLastName);
            this.panelClient.Controls.Add(this.lblEmail);
            this.panelClient.Controls.Add(this.txtEmail);
            this.panelClient.Controls.Add(this.lblPhone);
            this.panelClient.Controls.Add(this.txtPhone);
            this.panelClient.Location = new System.Drawing.Point(20, 100);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(440, 310);
            this.panelClient.TabIndex = 2;
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblClientStatus.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblClientStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblClientStatus.Location = new System.Drawing.Point(15, 270);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(405, 25);
            this.lblClientStatus.TabIndex = 12;
            this.lblClientStatus.Text = "Enter a licence number and click Look Up";
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLicenceNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLicenceNo.Location = new System.Drawing.Point(15, 20);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(104, 24);
            this.lblLicenceNo.TabIndex = 0;
            this.lblLicenceNo.Text = "Licence No.";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtLicenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenceNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLicenceNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicenceNo.Location = new System.Drawing.Point(155, 17);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(165, 32);
            this.txtLicenceNo.TabIndex = 1;
            this.txtLicenceNo.TextChanged += new System.EventHandler(this.txtLicenceNo_TextChanged);
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookup.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnLookup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnLookup.Location = new System.Drawing.Point(330, 17);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(90, 28);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Look Up";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblFirstName.Location = new System.Drawing.Point(15, 95);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 24);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFirstName.Location = new System.Drawing.Point(155, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(265, 32);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLastName.Location = new System.Drawing.Point(15, 140);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 24);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastName.Location = new System.Drawing.Point(155, 137);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 32);
            this.txtLastName.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblEmail.Location = new System.Drawing.Point(15, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 24);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(155, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 32);
            this.txtEmail.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPhone.Location = new System.Drawing.Point(15, 230);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(64, 24);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhone.Location = new System.Drawing.Point(155, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 32);
            this.txtPhone.TabIndex = 11;
            // 
            // lblResSection
            // 
            this.lblResSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblResSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblResSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblResSection.Location = new System.Drawing.Point(480, 65);
            this.lblResSection.Name = "lblResSection";
            this.lblResSection.Size = new System.Drawing.Size(220, 30);
            this.lblResSection.TabIndex = 3;
            this.lblResSection.Text = "Reservation Details";
            // 
            // panelRes
            // 
            this.panelRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRes.Controls.Add(this.lblStatus);
            this.panelRes.Controls.Add(this.cmbStatus);
            this.panelRes.Controls.Add(this.lblDeadline);
            this.panelRes.Controls.Add(this.dtpDeadline);
            this.panelRes.Controls.Add(this.lblPickupDate);
            this.panelRes.Controls.Add(this.dtpPickupDate);
            this.panelRes.Controls.Add(this.lblResDate);
            this.panelRes.Controls.Add(this.dtpResDate);
            this.panelRes.Location = new System.Drawing.Point(480, 100);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(480, 310);
            this.panelRes.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblStatus.Location = new System.Drawing.Point(15, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 24);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbStatus.Items.AddRange(new object[] {
            "Picked Up",
            "Pending",
            "Reserved"});
            this.cmbStatus.Location = new System.Drawing.Point(220, 17);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(230, 32);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblDeadline.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblDeadline.Location = new System.Drawing.Point(15, 75);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(85, 24);
            this.lblDeadline.TabIndex = 2;
            this.lblDeadline.Text = "Deadline";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDeadline.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.dtpDeadline.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.dtpDeadline.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(220, 72);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(230, 32);
            this.dtpDeadline.TabIndex = 3;
            // 
            // lblPickupDate
            // 
            this.lblPickupDate.AutoSize = true;
            this.lblPickupDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPickupDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPickupDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPickupDate.Location = new System.Drawing.Point(15, 130);
            this.lblPickupDate.Name = "lblPickupDate";
            this.lblPickupDate.Size = new System.Drawing.Size(111, 24);
            this.lblPickupDate.TabIndex = 4;
            this.lblPickupDate.Text = "Pickup Date";
            // 
            // dtpPickupDate
            // 
            this.dtpPickupDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpPickupDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.dtpPickupDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.dtpPickupDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpPickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickupDate.Location = new System.Drawing.Point(220, 127);
            this.dtpPickupDate.Name = "dtpPickupDate";
            this.dtpPickupDate.Size = new System.Drawing.Size(230, 32);
            this.dtpPickupDate.TabIndex = 5;
            // 
            // lblResDate
            // 
            this.lblResDate.AutoSize = true;
            this.lblResDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblResDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblResDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblResDate.Location = new System.Drawing.Point(15, 185);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(154, 24);
            this.lblResDate.TabIndex = 6;
            this.lblResDate.Text = "Reservation Date";
            // 
            // dtpResDate
            // 
            this.dtpResDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpResDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.dtpResDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.dtpResDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResDate.Location = new System.Drawing.Point(220, 182);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(230, 32);
            this.dtpResDate.TabIndex = 7;
            // 
            // lblCatSection
            // 
            this.lblCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCatSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCatSection.Location = new System.Drawing.Point(20, 430);
            this.lblCatSection.Name = "lblCatSection";
            this.lblCatSection.Size = new System.Drawing.Size(300, 30);
            this.lblCatSection.TabIndex = 5;
            this.lblCatSection.Text = "Select Car Category";
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCat.Controls.Add(this.txtCatSearch);
            this.panelCat.Controls.Add(this.flowCategories);
            this.panelCat.Location = new System.Drawing.Point(20, 465);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(940, 260);
            this.panelCat.TabIndex = 6;
            // 
            // txtCatSearch
            // 
            this.txtCatSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtCatSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCatSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtCatSearch.Location = new System.Drawing.Point(10, 10);
            this.txtCatSearch.Name = "txtCatSearch";
            this.txtCatSearch.Size = new System.Drawing.Size(918, 32);
            this.txtCatSearch.TabIndex = 0;
            this.txtCatSearch.Text = "Search categories...";
            this.txtCatSearch.TextChanged += new System.EventHandler(this.txtCatSearch_TextChanged);
            this.txtCatSearch.GotFocus += new System.EventHandler(this.txtCatSearch_GotFocus);
            this.txtCatSearch.LostFocus += new System.EventHandler(this.txtCatSearch_LostFocus);
            // 
            // flowCategories
            // 
            this.flowCategories.AutoScroll = true;
            this.flowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.flowCategories.Location = new System.Drawing.Point(10, 48);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Size = new System.Drawing.Size(918, 200);
            this.flowCategories.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnSave.Location = new System.Drawing.Point(600, 745);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 50);
            this.btnSave.TabIndex = 7;
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
            this.btnCancel.Location = new System.Drawing.Point(780, 745);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 50);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(980, 820);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientSection);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.lblResSection);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.lblCatSection);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Reservation";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelRes.ResumeLayout(false);
            this.panelRes.PerformLayout();
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientSection;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.TextBox txtLicenceNo;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblResSection;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblPickupDate;
        private System.Windows.Forms.DateTimePicker dtpPickupDate;
        private System.Windows.Forms.Label lblResDate;
        private System.Windows.Forms.DateTimePicker dtpResDate;
        private System.Windows.Forms.Label lblCatSection;
        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.TextBox txtCatSearch;
        private System.Windows.Forms.FlowLayoutPanel flowCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}