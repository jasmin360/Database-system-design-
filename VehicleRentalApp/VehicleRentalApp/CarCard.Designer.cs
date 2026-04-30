namespace VehicleRentalApp
{
    partial class CarCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.BackColor = System.Drawing.Color.Transparent;
            this.lblMakeModel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblMakeModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeModel.Location = new System.Drawing.Point(28, 20);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(270, 36);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Make Model";
            // 
            // lblPlate
            // 
            this.lblPlate.BackColor = System.Drawing.Color.Transparent;
            this.lblPlate.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblPlate.Location = new System.Drawing.Point(29, 53);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(270, 36);
            this.lblPlate.TabIndex = 1;
            this.lblPlate.Text = "ABC-1234";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblType.Location = new System.Drawing.Point(30, 84);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(270, 45);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRate.Location = new System.Drawing.Point(34, 134);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(180, 55);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "$0/day";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblStatus.Location = new System.Drawing.Point(220, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 31);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Free";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button1.Location = new System.Drawing.Point(308, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 31);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.BackgroundImage = global::VehicleRentalApp.Properties.Resources.compose__1_;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.edit.Location = new System.Drawing.Point(308, 80);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(29, 31);
            this.edit.TabIndex = 41;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.right_Click);
            // 
            // CarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.lblMakeModel);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblStatus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CarCard";
            this.Size = new System.Drawing.Size(382, 189);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit;
    }
}