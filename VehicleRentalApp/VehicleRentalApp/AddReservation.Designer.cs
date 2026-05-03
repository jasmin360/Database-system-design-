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
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.panelCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(71, -3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientSection
            // 
            this.lblClientSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblClientSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblClientSection.Location = new System.Drawing.Point(19, 60);
            this.lblClientSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientSection.Name = "lblClientSection";
            this.lblClientSection.Size = new System.Drawing.Size(51, 17);
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
            this.panelClient.Location = new System.Drawing.Point(18, 89);
            this.panelClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(315, 209);
            this.panelClient.TabIndex = 2;
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblClientStatus.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblClientStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblClientStatus.Location = new System.Drawing.Point(8, 181);
            this.lblClientStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(202, 13);
            this.lblClientStatus.TabIndex = 12;
            this.lblClientStatus.Text = "Enter a licence number and click Look Up";
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLicenceNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLicenceNo.Location = new System.Drawing.Point(8, 10);
            this.lblLicenceNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(75, 17);
            this.lblLicenceNo.TabIndex = 0;
            this.lblLicenceNo.Text = "Licence No.";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtLicenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenceNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLicenceNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicenceNo.Location = new System.Drawing.Point(122, 11);
            this.txtLicenceNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(95, 24);
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
            this.btnLookup.Location = new System.Drawing.Point(221, 11);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(50, 24);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Search";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblFirstName.Location = new System.Drawing.Point(8, 49);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 17);
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
            this.txtFirstName.Location = new System.Drawing.Point(122, 48);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 24);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLastName.Location = new System.Drawing.Point(8, 78);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 17);
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
            this.txtLastName.Location = new System.Drawing.Point(122, 76);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 24);
            this.txtLastName.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblEmail.Location = new System.Drawing.Point(8, 106);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
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
            this.txtEmail.Location = new System.Drawing.Point(122, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 24);
            this.txtEmail.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPhone.Location = new System.Drawing.Point(8, 139);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 17);
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
            this.txtPhone.Location = new System.Drawing.Point(122, 132);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 24);
            this.txtPhone.TabIndex = 11;
            // 
            // lblResSection
            // 
            this.lblResSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblResSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblResSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblResSection.Location = new System.Drawing.Point(333, 60);
            this.lblResSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResSection.Name = "lblResSection";
            this.lblResSection.Size = new System.Drawing.Size(142, 16);
            this.lblResSection.TabIndex = 3;
            this.lblResSection.Text = "Reservation Details";
            // 
            // panelRes
            // 
            this.panelRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRes.Controls.Add(this.lblPaymentDate);
            this.panelRes.Controls.Add(this.dtpPaymentDate);
            this.panelRes.Controls.Add(this.lblPaymentMethod);
            this.panelRes.Controls.Add(this.cmbPaymentMethod);
            this.panelRes.Controls.Add(this.lblAmount);
            this.panelRes.Controls.Add(this.numAmount);
            this.panelRes.Controls.Add(this.lblStatus);
            this.panelRes.Controls.Add(this.cmbStatus);
            this.panelRes.Controls.Add(this.lblDeadline);
            this.panelRes.Controls.Add(this.dtpDeadline);
            this.panelRes.Controls.Add(this.lblPickupDate);
            this.panelRes.Controls.Add(this.dtpPickupDate);
            this.panelRes.Controls.Add(this.lblResDate);
            this.panelRes.Controls.Add(this.dtpResDate);
            this.panelRes.Location = new System.Drawing.Point(337, 89);
            this.panelRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(313, 209);
            this.panelRes.TabIndex = 4;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPaymentDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPaymentDate.Location = new System.Drawing.Point(8, 181);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(88, 17);
            this.lblPaymentDate.TabIndex = 12;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpPaymentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.dtpPaymentDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.dtpPaymentDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(139, 179);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(117, 24);
            this.dtpPaymentDate.TabIndex = 13;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPaymentMethod.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPaymentMethod.Location = new System.Drawing.Point(8, 125);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(110, 17);
            this.lblPaymentMethod.TabIndex = 8;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(139, 122);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(117, 23);
            this.cmbPaymentMethod.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblAmount.Location = new System.Drawing.Point(8, 153);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 17);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // numAmount
            // 
            this.numAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.numAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numAmount.Font = new System.Drawing.Font("Calibri", 10F);
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Location = new System.Drawing.Point(139, 151);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(117, 24);
            this.numAmount.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblStatus.Location = new System.Drawing.Point(8, 10);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
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
            "Pending",
            "Picked Up",
            "Reserved"});
            this.cmbStatus.Location = new System.Drawing.Point(139, 7);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(117, 23);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblDeadline.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblDeadline.Location = new System.Drawing.Point(8, 39);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(60, 17);
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
            this.dtpDeadline.Location = new System.Drawing.Point(139, 35);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(117, 24);
            this.dtpDeadline.TabIndex = 3;
            // 
            // lblPickupDate
            // 
            this.lblPickupDate.AutoSize = true;
            this.lblPickupDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPickupDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPickupDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPickupDate.Location = new System.Drawing.Point(8, 68);
            this.lblPickupDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickupDate.Name = "lblPickupDate";
            this.lblPickupDate.Size = new System.Drawing.Size(78, 17);
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
            this.dtpPickupDate.Location = new System.Drawing.Point(139, 64);
            this.dtpPickupDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPickupDate.Name = "dtpPickupDate";
            this.dtpPickupDate.Size = new System.Drawing.Size(117, 24);
            this.dtpPickupDate.TabIndex = 5;
            // 
            // lblResDate
            // 
            this.lblResDate.AutoSize = true;
            this.lblResDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblResDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblResDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblResDate.Location = new System.Drawing.Point(8, 96);
            this.lblResDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(110, 17);
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
            this.dtpResDate.Location = new System.Drawing.Point(139, 93);
            this.dtpResDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(117, 24);
            this.dtpResDate.TabIndex = 7;
            // 
            // lblCatSection
            // 
            this.lblCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCatSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCatSection.Location = new System.Drawing.Point(14, 309);
            this.lblCatSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatSection.Name = "lblCatSection";
            this.lblCatSection.Size = new System.Drawing.Size(150, 16);
            this.lblCatSection.TabIndex = 5;
            this.lblCatSection.Text = "Select Car Category";
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCat.Controls.Add(this.txtCatSearch);
            this.panelCat.Controls.Add(this.flowCategories);
            this.panelCat.Location = new System.Drawing.Point(14, 334);
            this.panelCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(636, 225);
            this.panelCat.TabIndex = 6;
            // 
            // txtCatSearch
            // 
            this.txtCatSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.txtCatSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCatSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtCatSearch.Location = new System.Drawing.Point(5, 5);
            this.txtCatSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCatSearch.Name = "txtCatSearch";
            this.txtCatSearch.Size = new System.Drawing.Size(624, 24);
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
            this.flowCategories.Location = new System.Drawing.Point(5, 33);
            this.flowCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Size = new System.Drawing.Size(624, 185);
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
            this.btnSave.Location = new System.Drawing.Point(481, 563);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
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
            this.btnCancel.Location = new System.Drawing.Point(571, 563);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(665, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientSection);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.lblResSection);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.lblCatSection);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Reservation";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelRes.ResumeLayout(false);
            this.panelRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
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
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
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