namespace VehicleRentalApp
{
    partial class EmployeeCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.BackColor = System.Drawing.Color.Transparent;
            this.lblMakeModel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblMakeModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeModel.Location = new System.Drawing.Point(26, 33);
            this.lblMakeModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(315, 42);
            this.lblMakeModel.TabIndex = 1;
            this.lblMakeModel.Text = "Employee_Name";
            // 
            // lblPlate
            // 
            this.lblPlate.BackColor = System.Drawing.Color.Transparent;
            this.lblPlate.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblPlate.Location = new System.Drawing.Point(29, 75);
            this.lblPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(315, 42);
            this.lblPlate.TabIndex = 2;
            this.lblPlate.Text = "Role";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblType.Location = new System.Drawing.Point(30, 117);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(315, 52);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(330, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblMakeModel);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(446, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
    }
}
