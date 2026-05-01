namespace VehicleRentalApp
{
    partial class ReservationCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientName.Location = new System.Drawing.Point(28, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(270, 30);
            this.lblClientName.TabIndex = 43;
            this.lblClientName.Text = "First Last";
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenceNo.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblLicenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblLicenceNo.Location = new System.Drawing.Point(28, 66);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(270, 25);
            this.lblLicenceNo.TabIndex = 45;
            this.lblLicenceNo.Text = "DL-00000";
            // 
            // lblResId
            // 
            this.lblResId.BackColor = System.Drawing.Color.Transparent;
            this.lblResId.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblResId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblResId.Location = new System.Drawing.Point(28, 44);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(270, 22);
            this.lblResId.TabIndex = 44;
            this.lblResId.Text = "ID: #00000";
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCarInfo.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblCarInfo.Location = new System.Drawing.Point(28, 91);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(270, 25);
            this.lblCarInfo.TabIndex = 46;
            this.lblCarInfo.Text = "Make Model • Plate";
            // 
            // lblDates
            // 
            this.lblDates.BackColor = System.Drawing.Color.Transparent;
            this.lblDates.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblDates.Location = new System.Drawing.Point(28, 116);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(270, 22);
            this.lblDates.TabIndex = 47;
            this.lblDates.Text = "Reserved: 01/01/2026";
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRate.Location = new System.Drawing.Point(28, 148);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(150, 28);
            this.lblRate.TabIndex = 48;
            this.lblRate.Text = "$0/day";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblStatus.Location = new System.Drawing.Point(234, 148);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 28);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Picked Up";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnEdit.BackgroundImage = global::VehicleRentalApp.Properties.Resources.compose__1_;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnEdit.Location = new System.Drawing.Point(322, 80);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 31);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnDelete.Location = new System.Drawing.Point(322, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 31);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ReservationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.lblLicenceNo);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ReservationCard";
            this.Size = new System.Drawing.Size(382, 202);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}