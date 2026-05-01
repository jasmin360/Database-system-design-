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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.chkEconomy = new System.Windows.Forms.CheckBox();
            this.chkCompact = new System.Windows.Forms.CheckBox();
            this.chkSUV = new System.Windows.Forms.CheckBox();
            this.chkLuxury = new System.Windows.Forms.CheckBox();
            this.chkVan = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button1.Location = new System.Drawing.Point(56, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button2.Location = new System.Drawing.Point(122, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Reserved";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.button3.Location = new System.Drawing.Point(207, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "Free";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 99);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.lblFilterTitle);
            this.filterPanel.Controls.Add(this.chkEconomy);
            this.filterPanel.Controls.Add(this.chkCompact);
            this.filterPanel.Controls.Add(this.chkSUV);
            this.filterPanel.Controls.Add(this.chkLuxury);
            this.filterPanel.Controls.Add(this.chkVan);
            this.filterPanel.Location = new System.Drawing.Point(689, 63);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // chkEconomy
            // 
            this.chkEconomy.AutoSize = true;
            this.chkEconomy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkEconomy.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkEconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkEconomy.Location = new System.Drawing.Point(8, 30);
            this.chkEconomy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEconomy.Name = "chkEconomy";
            this.chkEconomy.Size = new System.Drawing.Size(69, 21);
            this.chkEconomy.TabIndex = 1;
            this.chkEconomy.Text = "Picanto";
            this.chkEconomy.UseVisualStyleBackColor = false;
            // 
            // chkCompact
            // 
            this.chkCompact.AutoSize = true;
            this.chkCompact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkCompact.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkCompact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkCompact.Location = new System.Drawing.Point(8, 53);
            this.chkCompact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCompact.Name = "chkCompact";
            this.chkCompact.Size = new System.Drawing.Size(50, 21);
            this.chkCompact.TabIndex = 2;
            this.chkCompact.Text = "SUV";
            this.chkCompact.UseVisualStyleBackColor = false;
            // 
            // chkSUV
            // 
            this.chkSUV.AutoSize = true;
            this.chkSUV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkSUV.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkSUV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkSUV.Location = new System.Drawing.Point(8, 77);
            this.chkSUV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSUV.Name = "chkSUV";
            this.chkSUV.Size = new System.Drawing.Size(62, 21);
            this.chkSUV.TabIndex = 3;
            this.chkSUV.Text = "Coupe";
            this.chkSUV.UseVisualStyleBackColor = false;
            // 
            // chkLuxury
            // 
            this.chkLuxury.AutoSize = true;
            this.chkLuxury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkLuxury.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkLuxury.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkLuxury.Location = new System.Drawing.Point(8, 100);
            this.chkLuxury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLuxury.Name = "chkLuxury";
            this.chkLuxury.Size = new System.Drawing.Size(61, 21);
            this.chkLuxury.TabIndex = 4;
            this.chkLuxury.Text = "Sedan";
            this.chkLuxury.UseVisualStyleBackColor = false;
            // 
            // chkVan
            // 
            this.chkVan.AutoSize = true;
            this.chkVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.chkVan.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkVan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.chkVan.Location = new System.Drawing.Point(8, 123);
            this.chkVan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVan.Name = "chkVan";
            this.chkVan.Size = new System.Drawing.Size(87, 21);
            this.chkVan.TabIndex = 5;
            this.chkVan.Text = "Hatchback";
            this.chkVan.UseVisualStyleBackColor = false;
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
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cars";
            this.Size = new System.Drawing.Size(930, 599);
            this.Load += new System.EventHandler(this.Cars_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.CheckBox chkEconomy;
        private System.Windows.Forms.CheckBox chkCompact;
        private System.Windows.Forms.CheckBox chkSUV;
        private System.Windows.Forms.CheckBox chkLuxury;
        private System.Windows.Forms.CheckBox chkVan;
        private System.Windows.Forms.TextBox txtSearch;
    }
}