namespace VehicleRentalApp
{
    partial class Cars
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.all = new System.Windows.Forms.Button();
            this.reserv = new System.Windows.Forms.Button();
            this.free = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.chkPicanto = new System.Windows.Forms.CheckBox();
            this.chkSUV = new System.Windows.Forms.CheckBox();
            this.chkCoupe = new System.Windows.Forms.CheckBox();
            this.chkSedan = new System.Windows.Forms.CheckBox();
            this.chkHatchback = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.all.FlatAppearance.BorderSize = 2;
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.all.Location = new System.Drawing.Point(56, 28);
            this.all.Margin = new System.Windows.Forms.Padding(2);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(62, 31);
            this.all.TabIndex = 25;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserv
            // 
            this.reserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.reserv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.reserv.FlatAppearance.BorderSize = 2;
            this.reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserv.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.reserv.Location = new System.Drawing.Point(122, 28);
            this.reserv.Margin = new System.Windows.Forms.Padding(2);
            this.reserv.Name = "reserv";
            this.reserv.Size = new System.Drawing.Size(81, 31);
            this.reserv.TabIndex = 26;
            this.reserv.Text = "Reserved";
            this.reserv.UseVisualStyleBackColor = false;
            // 
            // free
            // 
            this.free.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.free.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.free.FlatAppearance.BorderSize = 2;
            this.free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.free.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.free.Location = new System.Drawing.Point(207, 28);
            this.free.Margin = new System.Windows.Forms.Padding(2);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(74, 31);
            this.free.TabIndex = 27;
            this.free.Text = "Free";
            this.free.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 99);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(820, 470);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(396, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 39;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.lblFilterTitle);
            this.filterPanel.Controls.Add(this.chkPicanto);
            this.filterPanel.Controls.Add(this.chkSUV);
            this.filterPanel.Controls.Add(this.chkCoupe);
            this.filterPanel.Controls.Add(this.chkSedan);
            this.filterPanel.Controls.Add(this.chkHatchback);
            this.filterPanel.Location = new System.Drawing.Point(689, 63);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(185, 177);
            this.filterPanel.TabIndex = 46;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.lblFilterTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFilterTitle.Location = new System.Drawing.Point(8, 8);
            this.lblFilterTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(115, 18);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter by Car Type";
            // 
            // chkPicanto
            // 
            this.chkPicanto.AutoSize = true;
            this.chkPicanto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkPicanto.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkPicanto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkPicanto.Location = new System.Drawing.Point(8, 30);
            this.chkPicanto.Margin = new System.Windows.Forms.Padding(2);
            this.chkPicanto.Name = "chkPicanto";
            this.chkPicanto.Size = new System.Drawing.Size(69, 21);
            this.chkPicanto.TabIndex = 1;
            this.chkPicanto.Text = "Picanto";
            this.chkPicanto.UseVisualStyleBackColor = false;
            // 
            // chkSUV
            // 
            this.chkSUV.AutoSize = true;
            this.chkSUV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkSUV.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkSUV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkSUV.Location = new System.Drawing.Point(8, 53);
            this.chkSUV.Margin = new System.Windows.Forms.Padding(2);
            this.chkSUV.Name = "chkSUV";
            this.chkSUV.Size = new System.Drawing.Size(50, 21);
            this.chkSUV.TabIndex = 2;
            this.chkSUV.Text = "SUV";
            this.chkSUV.UseVisualStyleBackColor = false;
            // 
            // chkCoupe
            // 
            this.chkCoupe.AutoSize = true;
            this.chkCoupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkCoupe.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkCoupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkCoupe.Location = new System.Drawing.Point(8, 77);
            this.chkCoupe.Margin = new System.Windows.Forms.Padding(2);
            this.chkCoupe.Name = "chkCoupe";
            this.chkCoupe.Size = new System.Drawing.Size(62, 21);
            this.chkCoupe.TabIndex = 3;
            this.chkCoupe.Text = "Coupe";
            this.chkCoupe.UseVisualStyleBackColor = false;
            // 
            // chkSedan
            // 
            this.chkSedan.AutoSize = true;
            this.chkSedan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkSedan.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkSedan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkSedan.Location = new System.Drawing.Point(8, 100);
            this.chkSedan.Margin = new System.Windows.Forms.Padding(2);
            this.chkSedan.Name = "chkSedan";
            this.chkSedan.Size = new System.Drawing.Size(61, 21);
            this.chkSedan.TabIndex = 4;
            this.chkSedan.Text = "Sedan";
            this.chkSedan.UseVisualStyleBackColor = false;
            // 
            // chkHatchback
            // 
            this.chkHatchback.AutoSize = true;
            this.chkHatchback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkHatchback.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkHatchback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkHatchback.Location = new System.Drawing.Point(8, 123);
            this.chkHatchback.Margin = new System.Windows.Forms.Padding(2);
            this.chkHatchback.Name = "chkHatchback";
            this.chkHatchback.Size = new System.Drawing.Size(87, 21);
            this.chkHatchback.TabIndex = 5;
            this.chkHatchback.Text = "Hatchback";
            this.chkHatchback.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 14.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtSearch.Location = new System.Drawing.Point(285, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 31);
            this.txtSearch.TabIndex = 47;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BtnRefresh.BackgroundImage = global::VehicleRentalApp.Properties.Resources.Refresh1;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.BtnRefresh.Location = new System.Drawing.Point(772, 31);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(23, 25);
            this.BtnRefresh.TabIndex = 48;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            this.plus.Location = new System.Drawing.Point(850, 32);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 25);
            this.plus.TabIndex = 43;
            this.plus.UseVisualStyleBackColor = false;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.right.BackgroundImage = global::VehicleRentalApp.Properties.Resources.filter__2_1;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.right.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.right.Location = new System.Drawing.Point(808, 30);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(27, 29);
            this.right.TabIndex = 40;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.free);
            this.Controls.Add(this.reserv);
            this.Controls.Add(this.all);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cars";
            this.Size = new System.Drawing.Size(930, 599);
            this.Load += new System.EventHandler(this.Cars_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button reserv;
        private System.Windows.Forms.Button free;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.CheckBox chkPicanto;
        private System.Windows.Forms.CheckBox chkSUV;
        private System.Windows.Forms.CheckBox chkCoupe;
        private System.Windows.Forms.CheckBox chkSedan;
        private System.Windows.Forms.CheckBox chkHatchback;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BtnRefresh;
    }
}