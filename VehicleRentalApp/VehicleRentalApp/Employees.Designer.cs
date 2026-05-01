namespace VehicleRentalApp
{
    partial class Employees
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblSortTitle = new System.Windows.Forms.Label();
            this.chkAtoZ = new System.Windows.Forms.CheckBox();
            this.chkCompact = new System.Windows.Forms.CheckBox();
            this.chkReservationCount = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.sortbutton = new System.Windows.Forms.Button();
            this.filterPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.lblSortTitle);
            this.filterPanel.Controls.Add(this.chkAtoZ);
            this.filterPanel.Controls.Add(this.chkCompact);
            this.filterPanel.Controls.Add(this.chkReservationCount);
            this.filterPanel.Location = new System.Drawing.Point(1744, 339);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(413, 253);
            this.filterPanel.TabIndex = 55;
            // 
            // lblSortTitle
            // 
            this.lblSortTitle.AutoSize = true;
            this.lblSortTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblSortTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblSortTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSortTitle.Location = new System.Drawing.Point(18, 18);
            this.lblSortTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSortTitle.Name = "lblSortTitle";
            this.lblSortTitle.Size = new System.Drawing.Size(115, 40);
            this.lblSortTitle.TabIndex = 0;
            this.lblSortTitle.Text = "Sort by";
            this.lblSortTitle.Click += new System.EventHandler(this.lblFilterTitle_Click);
            // 
            // chkAtoZ
            // 
            this.chkAtoZ.AutoSize = true;
            this.chkAtoZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkAtoZ.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkAtoZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkAtoZ.Location = new System.Drawing.Point(18, 68);
            this.chkAtoZ.Margin = new System.Windows.Forms.Padding(4);
            this.chkAtoZ.Name = "chkAtoZ";
            this.chkAtoZ.Size = new System.Drawing.Size(103, 41);
            this.chkAtoZ.TabIndex = 1;
            this.chkAtoZ.Text = "A - Z";
            this.chkAtoZ.UseVisualStyleBackColor = false;
            // 
            // chkCompact
            // 
            this.chkCompact.AutoSize = true;
            this.chkCompact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkCompact.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkCompact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkCompact.Location = new System.Drawing.Point(18, 120);
            this.chkCompact.Margin = new System.Windows.Forms.Padding(4);
            this.chkCompact.Name = "chkCompact";
            this.chkCompact.Size = new System.Drawing.Size(103, 41);
            this.chkCompact.TabIndex = 2;
            this.chkCompact.Text = "Z - A";
            this.chkCompact.UseVisualStyleBackColor = false;
            // 
            // chkReservationCount
            // 
            this.chkReservationCount.AutoSize = true;
            this.chkReservationCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkReservationCount.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkReservationCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkReservationCount.Location = new System.Drawing.Point(18, 172);
            this.chkReservationCount.Margin = new System.Windows.Forms.Padding(4);
            this.chkReservationCount.Name = "chkReservationCount";
            this.chkReservationCount.Size = new System.Drawing.Size(286, 41);
            this.chkReservationCount.TabIndex = 3;
            this.chkReservationCount.Text = "Reservations Count";
            this.chkReservationCount.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtSearch.Location = new System.Drawing.Point(834, 242);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(802, 48);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 402);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1988, 1058);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(936, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 51);
            this.label7.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button1.Location = new System.Drawing.Point(170, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 93);
            this.button1.TabIndex = 47;
            this.button1.Text = "Hire a New Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.filterPanel);
            this.contentPanel.Controls.Add(this.txtSearch);
            this.contentPanel.Controls.Add(this.plus);
            this.contentPanel.Controls.Add(this.flowLayoutPanel1);
            this.contentPanel.Controls.Add(this.sortbutton);
            this.contentPanel.Controls.Add(this.label7);
            this.contentPanel.Controls.Add(this.button1);
            this.contentPanel.Location = new System.Drawing.Point(0, 1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(2352, 1732);
            this.contentPanel.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(159, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 66);
            this.label1.TabIndex = 56;
            this.label1.Text = "Employees at branch (Branch_Address)";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.plus.BackgroundImage = global::VehicleRentalApp.Properties.Resources.add;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.plus.Location = new System.Drawing.Point(2106, 268);
            this.plus.Margin = new System.Windows.Forms.Padding(6);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 56);
            this.plus.TabIndex = 53;
            this.plus.UseVisualStyleBackColor = false;
            // 
            // sortbutton
            // 
            this.sortbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.sortbutton.BackgroundImage = global::VehicleRentalApp.Properties.Resources.sort;
            this.sortbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sortbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.sortbutton.FlatAppearance.BorderSize = 0;
            this.sortbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.sortbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.sortbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.sortbutton.Location = new System.Drawing.Point(2011, 264);
            this.sortbutton.Margin = new System.Windows.Forms.Padding(6);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(60, 64);
            this.sortbutton.TabIndex = 51;
            this.sortbutton.UseVisualStyleBackColor = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(2357, 1509);
            this.Controls.Add(this.contentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employees";
            this.Text = "Form1";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblSortTitle;
        private System.Windows.Forms.CheckBox chkAtoZ;
        private System.Windows.Forms.CheckBox chkCompact;
        private System.Windows.Forms.CheckBox chkReservationCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
    }
}