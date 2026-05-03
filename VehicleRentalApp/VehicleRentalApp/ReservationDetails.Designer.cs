namespace VehicleRentalApp
{
    partial class ReservationDetails
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
            this.lblLicenceNoK = new System.Windows.Forms.Label();
            this.lblLicenceNoV = new System.Windows.Forms.Label();
            this.lblFirstNameK = new System.Windows.Forms.Label();
            this.lblFirstNameV = new System.Windows.Forms.Label();
            this.lblLastNameK = new System.Windows.Forms.Label();
            this.lblLastNameV = new System.Windows.Forms.Label();
            this.lblEmailK = new System.Windows.Forms.Label();
            this.lblEmailV = new System.Windows.Forms.Label();
            this.lblPhoneK = new System.Windows.Forms.Label();
            this.lblPhoneV = new System.Windows.Forms.Label();
            this.lblResSection = new System.Windows.Forms.Label();
            this.panelRes = new System.Windows.Forms.Panel();
            this.lblStatusK = new System.Windows.Forms.Label();
            this.lblStatusV = new System.Windows.Forms.Label();
            this.lblDeadlineK = new System.Windows.Forms.Label();
            this.lblDeadlineV = new System.Windows.Forms.Label();
            this.lblPickupDateK = new System.Windows.Forms.Label();
            this.lblPickupDateV = new System.Windows.Forms.Label();
            this.lblReturnDateK = new System.Windows.Forms.Label();
            this.lblReturnDateV = new System.Windows.Forms.Label();
            this.lblResDateK = new System.Windows.Forms.Label();
            this.lblResDateV = new System.Windows.Forms.Label();
            this.lblCarSection = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.lblPlateK = new System.Windows.Forms.Label();
            this.lblPlateV = new System.Windows.Forms.Label();
            this.lblConditionK = new System.Windows.Forms.Label();
            this.lblConditionV = new System.Windows.Forms.Label();
            this.lblSeatsK = new System.Windows.Forms.Label();
            this.lblSeatsV = new System.Windows.Forms.Label();
            this.lblMileageK = new System.Windows.Forms.Label();
            this.lblMileageV = new System.Windows.Forms.Label();
            this.lblColourK = new System.Windows.Forms.Label();
            this.lblColourV = new System.Windows.Forms.Label();
            this.lblCatSection = new System.Windows.Forms.Label();
            this.panelCat = new System.Windows.Forms.Panel();
            this.lblCarTypeK = new System.Windows.Forms.Label();
            this.lblCarTypeV = new System.Windows.Forms.Label();
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lblPayID = new System.Windows.Forms.Label();
            this.lblPayIDV = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.lblPayMethodV = new System.Windows.Forms.Label();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.lblPayDateV = new System.Windows.Forms.Label();
            this.lblPaymentDetails = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.panelRes.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.panelCat.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(202, -6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(980, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservation Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientSection
            // 
            this.lblClientSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblClientSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblClientSection.Location = new System.Drawing.Point(82, 100);
            this.lblClientSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientSection.Name = "lblClientSection";
            this.lblClientSection.Size = new System.Drawing.Size(200, 54);
            this.lblClientSection.TabIndex = 1;
            this.lblClientSection.Text = "Client";
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClient.Controls.Add(this.lblLicenceNoK);
            this.panelClient.Controls.Add(this.lblLicenceNoV);
            this.panelClient.Controls.Add(this.lblFirstNameK);
            this.panelClient.Controls.Add(this.lblFirstNameV);
            this.panelClient.Controls.Add(this.lblLastNameK);
            this.panelClient.Controls.Add(this.lblLastNameV);
            this.panelClient.Controls.Add(this.lblEmailK);
            this.panelClient.Controls.Add(this.lblEmailV);
            this.panelClient.Controls.Add(this.lblPhoneK);
            this.panelClient.Controls.Add(this.lblPhoneV);
            this.panelClient.Location = new System.Drawing.Point(82, 158);
            this.panelClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(636, 248);
            this.panelClient.TabIndex = 2;
            // 
            // lblLicenceNoK
            // 
            this.lblLicenceNoK.AutoSize = true;
            this.lblLicenceNoK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLicenceNoK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenceNoK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLicenceNoK.Location = new System.Drawing.Point(16, 19);
            this.lblLicenceNoK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenceNoK.Name = "lblLicenceNoK";
            this.lblLicenceNoK.Size = new System.Drawing.Size(143, 33);
            this.lblLicenceNoK.TabIndex = 0;
            this.lblLicenceNoK.Text = "Licence No.";
            // 
            // lblLicenceNoV
            // 
            this.lblLicenceNoV.AutoSize = true;
            this.lblLicenceNoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLicenceNoV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblLicenceNoV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLicenceNoV.Location = new System.Drawing.Point(200, 19);
            this.lblLicenceNoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenceNoV.Name = "lblLicenceNoV";
            this.lblLicenceNoV.Size = new System.Drawing.Size(0, 33);
            this.lblLicenceNoV.TabIndex = 1;
            // 
            // lblFirstNameK
            // 
            this.lblFirstNameK.AutoSize = true;
            this.lblFirstNameK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblFirstNameK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblFirstNameK.Location = new System.Drawing.Point(16, 60);
            this.lblFirstNameK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameK.Name = "lblFirstNameK";
            this.lblFirstNameK.Size = new System.Drawing.Size(137, 33);
            this.lblFirstNameK.TabIndex = 2;
            this.lblFirstNameK.Text = "First Name";
            // 
            // lblFirstNameV
            // 
            this.lblFirstNameV.AutoSize = true;
            this.lblFirstNameV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblFirstNameV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblFirstNameV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstNameV.Location = new System.Drawing.Point(200, 60);
            this.lblFirstNameV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameV.Name = "lblFirstNameV";
            this.lblFirstNameV.Size = new System.Drawing.Size(0, 33);
            this.lblFirstNameV.TabIndex = 3;
            // 
            // lblLastNameK
            // 
            this.lblLastNameK.AutoSize = true;
            this.lblLastNameK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLastNameK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastNameK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblLastNameK.Location = new System.Drawing.Point(18, 110);
            this.lblLastNameK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNameK.Name = "lblLastNameK";
            this.lblLastNameK.Size = new System.Drawing.Size(132, 33);
            this.lblLastNameK.TabIndex = 4;
            this.lblLastNameK.Text = "Last Name";
            // 
            // lblLastNameV
            // 
            this.lblLastNameV.AutoSize = true;
            this.lblLastNameV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblLastNameV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblLastNameV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastNameV.Location = new System.Drawing.Point(200, 112);
            this.lblLastNameV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNameV.Name = "lblLastNameV";
            this.lblLastNameV.Size = new System.Drawing.Size(0, 33);
            this.lblLastNameV.TabIndex = 5;
            // 
            // lblEmailK
            // 
            this.lblEmailK.AutoSize = true;
            this.lblEmailK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblEmailK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblEmailK.Location = new System.Drawing.Point(18, 154);
            this.lblEmailK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailK.Name = "lblEmailK";
            this.lblEmailK.Size = new System.Drawing.Size(21, 33);
            this.lblEmailK.TabIndex = 6;
            this.lblEmailK.Text = " ";
            // 
            // lblEmailV
            // 
            this.lblEmailV.AutoSize = true;
            this.lblEmailV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblEmailV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEmailV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailV.Location = new System.Drawing.Point(200, 154);
            this.lblEmailV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailV.Name = "lblEmailV";
            this.lblEmailV.Size = new System.Drawing.Size(0, 33);
            this.lblEmailV.TabIndex = 7;
            // 
            // lblPhoneK
            // 
            this.lblPhoneK.AutoSize = true;
            this.lblPhoneK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPhoneK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPhoneK.Location = new System.Drawing.Point(16, 200);
            this.lblPhoneK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneK.Name = "lblPhoneK";
            this.lblPhoneK.Size = new System.Drawing.Size(86, 33);
            this.lblPhoneK.TabIndex = 8;
            this.lblPhoneK.Text = "Phone";
            // 
            // lblPhoneV
            // 
            this.lblPhoneV.AutoSize = true;
            this.lblPhoneV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPhoneV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPhoneV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneV.Location = new System.Drawing.Point(200, 202);
            this.lblPhoneV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneV.Name = "lblPhoneV";
            this.lblPhoneV.Size = new System.Drawing.Size(0, 33);
            this.lblPhoneV.TabIndex = 9;
            // 
            // lblResSection
            // 
            this.lblResSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblResSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblResSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblResSection.Location = new System.Drawing.Point(814, 100);
            this.lblResSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResSection.Name = "lblResSection";
            this.lblResSection.Size = new System.Drawing.Size(250, 31);
            this.lblResSection.TabIndex = 3;
            this.lblResSection.Text = "Reservation Details";
            // 
            // panelRes
            // 
            this.panelRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRes.Controls.Add(this.lblStatusK);
            this.panelRes.Controls.Add(this.lblStatusV);
            this.panelRes.Controls.Add(this.lblDeadlineK);
            this.panelRes.Controls.Add(this.lblDeadlineV);
            this.panelRes.Controls.Add(this.lblPickupDateK);
            this.panelRes.Controls.Add(this.lblPickupDateV);
            this.panelRes.Controls.Add(this.lblReturnDateK);
            this.panelRes.Controls.Add(this.lblReturnDateV);
            this.panelRes.Controls.Add(this.lblResDateK);
            this.panelRes.Controls.Add(this.lblResDateV);
            this.panelRes.Location = new System.Drawing.Point(814, 158);
            this.panelRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(480, 248);
            this.panelRes.TabIndex = 4;
            // 
            // lblStatusK
            // 
            this.lblStatusK.AutoSize = true;
            this.lblStatusK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblStatusK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblStatusK.Location = new System.Drawing.Point(16, 19);
            this.lblStatusK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusK.Name = "lblStatusK";
            this.lblStatusK.Size = new System.Drawing.Size(84, 33);
            this.lblStatusK.TabIndex = 0;
            this.lblStatusK.Text = "Status";
            // 
            // lblStatusV
            // 
            this.lblStatusV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.lblStatusV.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblStatusV.Location = new System.Drawing.Point(246, 19);
            this.lblStatusV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusV.Name = "lblStatusV";
            this.lblStatusV.Size = new System.Drawing.Size(202, 33);
            this.lblStatusV.TabIndex = 1;
            this.lblStatusV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeadlineK
            // 
            this.lblDeadlineK.AutoSize = true;
            this.lblDeadlineK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblDeadlineK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadlineK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblDeadlineK.Location = new System.Drawing.Point(16, 60);
            this.lblDeadlineK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadlineK.Name = "lblDeadlineK";
            this.lblDeadlineK.Size = new System.Drawing.Size(115, 33);
            this.lblDeadlineK.TabIndex = 2;
            this.lblDeadlineK.Text = "Deadline";
            // 
            // lblDeadlineV
            // 
            this.lblDeadlineV.AutoSize = true;
            this.lblDeadlineV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblDeadlineV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDeadlineV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeadlineV.Location = new System.Drawing.Point(240, 60);
            this.lblDeadlineV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadlineV.Name = "lblDeadlineV";
            this.lblDeadlineV.Size = new System.Drawing.Size(0, 33);
            this.lblDeadlineV.TabIndex = 3;
            // 
            // lblPickupDateK
            // 
            this.lblPickupDateK.AutoSize = true;
            this.lblPickupDateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPickupDateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPickupDateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPickupDateK.Location = new System.Drawing.Point(16, 100);
            this.lblPickupDateK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickupDateK.Name = "lblPickupDateK";
            this.lblPickupDateK.Size = new System.Drawing.Size(147, 33);
            this.lblPickupDateK.TabIndex = 4;
            this.lblPickupDateK.Text = "Pickup Date";
            // 
            // lblPickupDateV
            // 
            this.lblPickupDateV.AutoSize = true;
            this.lblPickupDateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPickupDateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPickupDateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickupDateV.Location = new System.Drawing.Point(240, 100);
            this.lblPickupDateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickupDateV.Name = "lblPickupDateV";
            this.lblPickupDateV.Size = new System.Drawing.Size(0, 33);
            this.lblPickupDateV.TabIndex = 5;
            // 
            // lblReturnDateK
            // 
            this.lblReturnDateK.AutoSize = true;
            this.lblReturnDateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblReturnDateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblReturnDateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblReturnDateK.Location = new System.Drawing.Point(16, 154);
            this.lblReturnDateK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDateK.Name = "lblReturnDateK";
            this.lblReturnDateK.Size = new System.Drawing.Size(150, 33);
            this.lblReturnDateK.TabIndex = 6;
            this.lblReturnDateK.Text = "Return Date";
            // 
            // lblReturnDateV
            // 
            this.lblReturnDateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(10)))));
            this.lblReturnDateV.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnDateV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.lblReturnDateV.Location = new System.Drawing.Point(246, 158);
            this.lblReturnDateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDateV.Name = "lblReturnDateV";
            this.lblReturnDateV.Size = new System.Drawing.Size(202, 29);
            this.lblReturnDateV.TabIndex = 7;
            this.lblReturnDateV.Text = "Not Returned";
            this.lblReturnDateV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResDateK
            // 
            this.lblResDateK.AutoSize = true;
            this.lblResDateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblResDateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblResDateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblResDateK.Location = new System.Drawing.Point(16, 200);
            this.lblResDateK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResDateK.Name = "lblResDateK";
            this.lblResDateK.Size = new System.Drawing.Size(209, 33);
            this.lblResDateK.TabIndex = 8;
            this.lblResDateK.Text = "Reservation Date";
            // 
            // lblResDateV
            // 
            this.lblResDateV.AutoSize = true;
            this.lblResDateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblResDateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblResDateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResDateV.Location = new System.Drawing.Point(240, 202);
            this.lblResDateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResDateV.Name = "lblResDateV";
            this.lblResDateV.Size = new System.Drawing.Size(0, 33);
            this.lblResDateV.TabIndex = 9;
            // 
            // lblCarSection
            // 
            this.lblCarSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCarSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCarSection.Location = new System.Drawing.Point(82, 431);
            this.lblCarSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarSection.Name = "lblCarSection";
            this.lblCarSection.Size = new System.Drawing.Size(200, 56);
            this.lblCarSection.TabIndex = 5;
            this.lblCarSection.Text = "Assigned Car";
            // 
            // panelCar
            // 
            this.panelCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.lblPlateK);
            this.panelCar.Controls.Add(this.lblPlateV);
            this.panelCar.Controls.Add(this.lblConditionK);
            this.panelCar.Controls.Add(this.lblConditionV);
            this.panelCar.Controls.Add(this.lblSeatsK);
            this.panelCar.Controls.Add(this.lblSeatsV);
            this.panelCar.Controls.Add(this.lblMileageK);
            this.panelCar.Controls.Add(this.lblMileageV);
            this.panelCar.Controls.Add(this.lblColourK);
            this.panelCar.Controls.Add(this.lblColourV);
            this.panelCar.Location = new System.Drawing.Point(80, 490);
            this.panelCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(638, 310);
            this.panelCar.TabIndex = 6;
            // 
            // lblPlateK
            // 
            this.lblPlateK.AutoSize = true;
            this.lblPlateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPlateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPlateK.Location = new System.Drawing.Point(20, 19);
            this.lblPlateK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlateK.Name = "lblPlateK";
            this.lblPlateK.Size = new System.Drawing.Size(160, 33);
            this.lblPlateK.TabIndex = 0;
            this.lblPlateK.Text = "License Plate";
            // 
            // lblPlateV
            // 
            this.lblPlateV.AutoSize = true;
            this.lblPlateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPlateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPlateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlateV.Location = new System.Drawing.Point(240, 19);
            this.lblPlateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlateV.Name = "lblPlateV";
            this.lblPlateV.Size = new System.Drawing.Size(0, 33);
            this.lblPlateV.TabIndex = 1;
            // 
            // lblConditionK
            // 
            this.lblConditionK.AutoSize = true;
            this.lblConditionK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblConditionK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblConditionK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblConditionK.Location = new System.Drawing.Point(20, 83);
            this.lblConditionK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConditionK.Name = "lblConditionK";
            this.lblConditionK.Size = new System.Drawing.Size(124, 33);
            this.lblConditionK.TabIndex = 2;
            this.lblConditionK.Text = "Condition";
            // 
            // lblConditionV
            // 
            this.lblConditionV.AutoSize = true;
            this.lblConditionV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblConditionV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblConditionV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConditionV.Location = new System.Drawing.Point(240, 83);
            this.lblConditionV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConditionV.Name = "lblConditionV";
            this.lblConditionV.Size = new System.Drawing.Size(0, 33);
            this.lblConditionV.TabIndex = 3;
            // 
            // lblSeatsK
            // 
            this.lblSeatsK.AutoSize = true;
            this.lblSeatsK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSeatsK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeatsK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblSeatsK.Location = new System.Drawing.Point(20, 140);
            this.lblSeatsK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatsK.Name = "lblSeatsK";
            this.lblSeatsK.Size = new System.Drawing.Size(121, 33);
            this.lblSeatsK.TabIndex = 4;
            this.lblSeatsK.Text = "No. Seats";
            // 
            // lblSeatsV
            // 
            this.lblSeatsV.AutoSize = true;
            this.lblSeatsV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSeatsV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblSeatsV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeatsV.Location = new System.Drawing.Point(240, 140);
            this.lblSeatsV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatsV.Name = "lblSeatsV";
            this.lblSeatsV.Size = new System.Drawing.Size(0, 33);
            this.lblSeatsV.TabIndex = 5;
            // 
            // lblMileageK
            // 
            this.lblMileageK.AutoSize = true;
            this.lblMileageK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMileageK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMileageK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMileageK.Location = new System.Drawing.Point(20, 194);
            this.lblMileageK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMileageK.Name = "lblMileageK";
            this.lblMileageK.Size = new System.Drawing.Size(164, 33);
            this.lblMileageK.TabIndex = 6;
            this.lblMileageK.Text = "Mileage (km)";
            // 
            // lblMileageV
            // 
            this.lblMileageV.AutoSize = true;
            this.lblMileageV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMileageV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMileageV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMileageV.Location = new System.Drawing.Point(240, 194);
            this.lblMileageV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMileageV.Name = "lblMileageV";
            this.lblMileageV.Size = new System.Drawing.Size(0, 33);
            this.lblMileageV.TabIndex = 7;
            // 
            // lblColourK
            // 
            this.lblColourK.AutoSize = true;
            this.lblColourK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblColourK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblColourK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblColourK.Location = new System.Drawing.Point(20, 250);
            this.lblColourK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourK.Name = "lblColourK";
            this.lblColourK.Size = new System.Drawing.Size(90, 33);
            this.lblColourK.TabIndex = 8;
            this.lblColourK.Text = "Colour";
            // 
            // lblColourV
            // 
            this.lblColourV.AutoSize = true;
            this.lblColourV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblColourV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblColourV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColourV.Location = new System.Drawing.Point(240, 250);
            this.lblColourV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourV.Name = "lblColourV";
            this.lblColourV.Size = new System.Drawing.Size(0, 33);
            this.lblColourV.TabIndex = 9;
            // 
            // lblCatSection
            // 
            this.lblCatSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblCatSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblCatSection.Location = new System.Drawing.Point(806, 431);
            this.lblCatSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatSection.Name = "lblCatSection";
            this.lblCatSection.Size = new System.Drawing.Size(230, 56);
            this.lblCatSection.TabIndex = 7;
            this.lblCatSection.Text = "Car Category";
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCat.Controls.Add(this.lblCarTypeK);
            this.panelCat.Controls.Add(this.lblCarTypeV);
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
            this.panelCat.Location = new System.Drawing.Point(810, 490);
            this.panelCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(480, 310);
            this.panelCat.TabIndex = 8;
            // 
            // lblCarTypeK
            // 
            this.lblCarTypeK.AutoSize = true;
            this.lblCarTypeK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCarTypeK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCarTypeK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCarTypeK.Location = new System.Drawing.Point(16, 19);
            this.lblCarTypeK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarTypeK.Name = "lblCarTypeK";
            this.lblCarTypeK.Size = new System.Drawing.Size(111, 33);
            this.lblCarTypeK.TabIndex = 0;
            this.lblCarTypeK.Text = "Car Type";
            // 
            // lblCarTypeV
            // 
            this.lblCarTypeV.AutoSize = true;
            this.lblCarTypeV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblCarTypeV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCarTypeV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarTypeV.Location = new System.Drawing.Point(240, 19);
            this.lblCarTypeV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarTypeV.Name = "lblCarTypeV";
            this.lblCarTypeV.Size = new System.Drawing.Size(0, 33);
            this.lblCarTypeV.TabIndex = 1;
            // 
            // lblMakeK
            // 
            this.lblMakeK.AutoSize = true;
            this.lblMakeK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMakeK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMakeK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblMakeK.Location = new System.Drawing.Point(16, 60);
            this.lblMakeK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeK.Name = "lblMakeK";
            this.lblMakeK.Size = new System.Drawing.Size(78, 33);
            this.lblMakeK.TabIndex = 2;
            this.lblMakeK.Text = "Make";
            // 
            // lblMakeV
            // 
            this.lblMakeV.AutoSize = true;
            this.lblMakeV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblMakeV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMakeV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeV.Location = new System.Drawing.Point(240, 60);
            this.lblMakeV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeV.Name = "lblMakeV";
            this.lblMakeV.Size = new System.Drawing.Size(0, 33);
            this.lblMakeV.TabIndex = 3;
            // 
            // lblModelK
            // 
            this.lblModelK.AutoSize = true;
            this.lblModelK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModelK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblModelK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblModelK.Location = new System.Drawing.Point(16, 104);
            this.lblModelK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelK.Name = "lblModelK";
            this.lblModelK.Size = new System.Drawing.Size(89, 33);
            this.lblModelK.TabIndex = 4;
            this.lblModelK.Text = "Model";
            // 
            // lblModelV
            // 
            this.lblModelV.AutoSize = true;
            this.lblModelV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblModelV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblModelV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelV.Location = new System.Drawing.Point(240, 100);
            this.lblModelV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelV.Name = "lblModelV";
            this.lblModelV.Size = new System.Drawing.Size(0, 33);
            this.lblModelV.TabIndex = 5;
            // 
            // lblYearK
            // 
            this.lblYearK.AutoSize = true;
            this.lblYearK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblYearK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblYearK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblYearK.Location = new System.Drawing.Point(16, 152);
            this.lblYearK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearK.Name = "lblYearK";
            this.lblYearK.Size = new System.Drawing.Size(144, 33);
            this.lblYearK.TabIndex = 6;
            this.lblYearK.Text = "Model Year";
            // 
            // lblYearV
            // 
            this.lblYearV.AutoSize = true;
            this.lblYearV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblYearV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblYearV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYearV.Location = new System.Drawing.Point(240, 154);
            this.lblYearV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearV.Name = "lblYearV";
            this.lblYearV.Size = new System.Drawing.Size(0, 33);
            this.lblYearV.TabIndex = 7;
            // 
            // lblTransK
            // 
            this.lblTransK.AutoSize = true;
            this.lblTransK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTransK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblTransK.Location = new System.Drawing.Point(16, 250);
            this.lblTransK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransK.Name = "lblTransK";
            this.lblTransK.Size = new System.Drawing.Size(161, 33);
            this.lblTransK.TabIndex = 8;
            this.lblTransK.Text = "Transmission";
            // 
            // lblTransV
            // 
            this.lblTransV.AutoSize = true;
            this.lblTransV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblTransV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTransV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransV.Location = new System.Drawing.Point(240, 250);
            this.lblTransV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransV.Name = "lblTransV";
            this.lblTransV.Size = new System.Drawing.Size(0, 33);
            this.lblTransV.TabIndex = 9;
            // 
            // lblRateK
            // 
            this.lblRateK.AutoSize = true;
            this.lblRateK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblRateK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblRateK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblRateK.Location = new System.Drawing.Point(20, 200);
            this.lblRateK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRateK.Name = "lblRateK";
            this.lblRateK.Size = new System.Drawing.Size(129, 33);
            this.lblRateK.TabIndex = 10;
            this.lblRateK.Text = "Daily Rate";
            // 
            // lblRateV
            // 
            this.lblRateV.AutoSize = true;
            this.lblRateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblRateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblRateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRateV.Location = new System.Drawing.Point(240, 202);
            this.lblRateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRateV.Name = "lblRateV";
            this.lblRateV.Size = new System.Drawing.Size(0, 33);
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
            this.btnClose.Location = new System.Drawing.Point(1136, 1108);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 69);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnEdit.BackgroundImage = global::VehicleRentalApp.Properties.Resources.compose__1_1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(940, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 31);
            this.btnEdit.TabIndex = 100;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnDelete.BackgroundImage = global::VehicleRentalApp.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1024, 1108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 69);
            this.btnDelete.TabIndex = 101;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.panelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPayment.Controls.Add(this.lblPayID);
            this.panelPayment.Controls.Add(this.lblPayIDV);
            this.panelPayment.Controls.Add(this.lblPayMethod);
            this.panelPayment.Controls.Add(this.lblPayMethodV);
            this.panelPayment.Controls.Add(this.lblPayDate);
            this.panelPayment.Controls.Add(this.lblPayDateV);
            this.panelPayment.Location = new System.Drawing.Point(80, 877);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(1210, 200);
            this.panelPayment.TabIndex = 10;
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPayID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPayID.Location = new System.Drawing.Point(20, 19);
            this.lblPayID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(149, 33);
            this.lblPayID.TabIndex = 0;
            this.lblPayID.Text = "Payment ID ";
            // 
            // lblPayIDV
            // 
            this.lblPayIDV.AutoSize = true;
            this.lblPayIDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayIDV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPayIDV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayIDV.Location = new System.Drawing.Point(240, 19);
            this.lblPayIDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayIDV.Name = "lblPayIDV";
            this.lblPayIDV.Size = new System.Drawing.Size(0, 33);
            this.lblPayIDV.TabIndex = 103;
            this.lblPayIDV.Text = "XXXX";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayMethod.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPayMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPayMethod.Location = new System.Drawing.Point(22, 77);
            this.lblPayMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(209, 33);
            this.lblPayMethod.TabIndex = 2;
            this.lblPayMethod.Text = "Payment Method";
            // 
            // lblPayMethodV
            // 
            this.lblPayMethodV.AutoSize = true;
            this.lblPayMethodV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayMethodV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPayMethodV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayMethodV.Location = new System.Drawing.Point(240, 77);
            this.lblPayMethodV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethodV.Name = "lblPayMethodV";
            this.lblPayMethodV.Size = new System.Drawing.Size(0, 33);
            this.lblPayMethodV.TabIndex = 104;
            this.lblPayMethodV.Text = "Not Payed";
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblPayDate.Location = new System.Drawing.Point(20, 140);
            this.lblPayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(172, 33);
            this.lblPayDate.TabIndex = 4;
            this.lblPayDate.Text = "Payment Date";
            // 
            // lblPayDateV
            // 
            this.lblPayDateV.AutoSize = true;
            this.lblPayDateV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblPayDateV.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPayDateV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayDateV.Location = new System.Drawing.Point(240, 140);
            this.lblPayDateV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayDateV.Name = "lblPayDateV";
            this.lblPayDateV.Size = new System.Drawing.Size(0, 33);
            this.lblPayDateV.TabIndex = 105;
            this.lblPayDateV.Text = "Not Payed";
            // 
            // lblPaymentDetails
            // 
            this.lblPaymentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.lblPaymentDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblPaymentDetails.Location = new System.Drawing.Point(82, 817);
            this.lblPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDetails.Name = "lblPaymentDetails";
            this.lblPaymentDetails.Size = new System.Drawing.Size(200, 56);
            this.lblPaymentDetails.TabIndex = 102;
            this.lblPaymentDetails.Text = "Payment";
            // 
            // ReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1374, 1208);
            this.Controls.Add(this.lblPaymentDetails);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClientSection);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.lblResSection);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.lblCarSection);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.lblCatSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation Details";
            this.Load += new System.EventHandler(this.ReservationDetails_Load);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelRes.ResumeLayout(false);
            this.panelRes.PerformLayout();
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientSection;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Label lblLicenceNoK, lblLicenceNoV;
        private System.Windows.Forms.Label lblFirstNameK, lblFirstNameV;
        private System.Windows.Forms.Label lblLastNameK, lblLastNameV;
        private System.Windows.Forms.Label lblEmailK, lblEmailV;
        private System.Windows.Forms.Label lblPhoneK, lblPhoneV;
        private System.Windows.Forms.Label lblResSection;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.Label lblStatusK, lblStatusV;
        private System.Windows.Forms.Label lblDeadlineK, lblDeadlineV;
        private System.Windows.Forms.Label lblPickupDateK, lblPickupDateV;
        private System.Windows.Forms.Label lblReturnDateK, lblReturnDateV;
        private System.Windows.Forms.Label lblResDateK, lblResDateV;
        private System.Windows.Forms.Label lblCarSection;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label lblPlateK, lblPlateV;
        private System.Windows.Forms.Label lblConditionK, lblConditionV;
        private System.Windows.Forms.Label lblSeatsK, lblSeatsV;
        private System.Windows.Forms.Label lblMileageK, lblMileageV;
        private System.Windows.Forms.Label lblColourK, lblColourV;
        private System.Windows.Forms.Label lblCatSection;
        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.Label lblCarTypeK, lblCarTypeV;
        private System.Windows.Forms.Label lblMakeK, lblMakeV;
        private System.Windows.Forms.Label lblModelK, lblModelV;
        private System.Windows.Forms.Label lblYearK, lblYearV;
        private System.Windows.Forms.Label lblTransK, lblTransV;
        private System.Windows.Forms.Label lblRateK, lblRateV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lblPayID, lblPayIDV;
        private System.Windows.Forms.Label lblPayMethod, lblPayMethodV;
        private System.Windows.Forms.Label lblPayDate, lblPayDateV;
        private System.Windows.Forms.Label lblPaymentDetails;  
    }
}