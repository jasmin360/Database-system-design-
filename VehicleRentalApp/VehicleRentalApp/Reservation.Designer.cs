namespace VehicleRentalApp
{
    partial class Reservation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.todaybtn = new System.Windows.Forms.Button();
            this.thisWeekbtn = new System.Windows.Forms.Button();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dayBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.siwtchViews = new System.Windows.Forms.Button();
            this.resDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // todaybtn
            // 
            this.todaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.todaybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.todaybtn.FlatAppearance.BorderSize = 2;
            this.todaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todaybtn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.todaybtn.Location = new System.Drawing.Point(112, 56);
            this.todaybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.todaybtn.Name = "todaybtn";
            this.todaybtn.Size = new System.Drawing.Size(140, 62);
            this.todaybtn.TabIndex = 25;
            this.todaybtn.Text = "Today";
            this.todaybtn.UseVisualStyleBackColor = false;
            // 
            // thisWeekbtn
            // 
            this.thisWeekbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.thisWeekbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.thisWeekbtn.FlatAppearance.BorderSize = 2;
            this.thisWeekbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisWeekbtn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisWeekbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.thisWeekbtn.Location = new System.Drawing.Point(260, 56);
            this.thisWeekbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisWeekbtn.Name = "thisWeekbtn";
            this.thisWeekbtn.Size = new System.Drawing.Size(176, 62);
            this.thisWeekbtn.TabIndex = 25;
            this.thisWeekbtn.Text = "This Week";
            this.thisWeekbtn.UseVisualStyleBackColor = false;
            // 
            // monthBtn
            // 
            this.monthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.monthBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.monthBtn.FlatAppearance.BorderSize = 2;
            this.monthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBtn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.monthBtn.Location = new System.Drawing.Point(448, 56);
            this.monthBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(212, 62);
            this.monthBtn.TabIndex = 25;
            this.monthBtn.Text = "Month";
            this.monthBtn.UseVisualStyleBackColor = false;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.dayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.dayBtn.FlatAppearance.BorderSize = 2;
            this.dayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayBtn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.dayBtn.Location = new System.Drawing.Point(668, 56);
            this.dayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(144, 62);
            this.dayBtn.TabIndex = 25;
            this.dayBtn.Text = "Day";
            this.dayBtn.UseVisualStyleBackColor = false;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 14.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtSearch.Location = new System.Drawing.Point(820, 56);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(598, 55);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.plus.Location = new System.Drawing.Point(1700, 62);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(48, 48);
            this.plus.TabIndex = 43;
            this.plus.UseVisualStyleBackColor = false;
            // 
            // siwtchViews
            // 
            this.siwtchViews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.siwtchViews.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.siwtchViews.FlatAppearance.BorderSize = 2;
            this.siwtchViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siwtchViews.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siwtchViews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.siwtchViews.Location = new System.Drawing.Point(1484, 56);
            this.siwtchViews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siwtchViews.Name = "siwtchViews";
            this.siwtchViews.Size = new System.Drawing.Size(188, 62);
            this.siwtchViews.TabIndex = 27;
            this.siwtchViews.Text = "Switch Views";
            this.siwtchViews.UseVisualStyleBackColor = false;
            // 
            // resDisplay
            // 
            this.resDisplay.AutoScroll = true;
            this.resDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.resDisplay.Location = new System.Drawing.Point(112, 198);
            this.resDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resDisplay.Name = "resDisplay";
            this.resDisplay.Size = new System.Drawing.Size(1640, 940);
            this.resDisplay.TabIndex = 42;
            this.resDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.resDisplay_Paint);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.siwtchViews);
            this.Controls.Add(this.resDisplay);
            this.Controls.Add(this.dayBtn);
            this.Controls.Add(this.monthBtn);
            this.Controls.Add(this.thisWeekbtn);
            this.Controls.Add(this.todaybtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(1860, 1198);
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button todaybtn;
        private System.Windows.Forms.Button thisWeekbtn;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button siwtchViews;
        private System.Windows.Forms.FlowLayoutPanel resDisplay;

        #endregion
    }
}
