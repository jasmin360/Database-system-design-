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
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(22, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(330, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Employee_Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblRole.Location = new System.Drawing.Point(24, 65);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(270, 37);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.lblEmail.Location = new System.Drawing.Point(26, 100);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(270, 44);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(181)))));
            this.lblEmpID.Location = new System.Drawing.Point(286, 77);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(96, 67);
            this.lblEmpID.TabIndex = 4;
            this.lblEmpID.Text = "ID";
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(378, 185);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmpID;
    }
}
