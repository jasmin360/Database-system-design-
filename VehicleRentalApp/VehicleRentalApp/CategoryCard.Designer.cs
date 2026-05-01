namespace VehicleRentalApp
{
    partial class CategoryCard
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.BackColor = System.Drawing.Color.Transparent;
            this.lblMakeModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMakeModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeModel.Location = new System.Drawing.Point(3, 3);
            this.lblMakeModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(120, 21);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Make Model";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.lblType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblType.Location = new System.Drawing.Point(4, 32);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 15);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblYear.Location = new System.Drawing.Point(106, 6);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "2020";
            // 
            // lblTrans
            // 
            this.lblTrans.BackColor = System.Drawing.Color.Transparent;
            this.lblTrans.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblTrans.Location = new System.Drawing.Point(4, 48);
            this.lblTrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(65, 16);
            this.lblTrans.TabIndex = 3;
            this.lblTrans.Text = "Automatic";
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRate.Location = new System.Drawing.Point(76, 80);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(67, 21);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "$0/day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.lblAvailable.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.lblAvailable.Location = new System.Drawing.Point(4, 80);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(42, 13);
            this.lblAvailable.TabIndex = 5;
            this.lblAvailable.Text = "0 available";
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMakeModel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAvailable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CategoryCard";
            this.Size = new System.Drawing.Size(145, 102);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblAvailable;
    }
}