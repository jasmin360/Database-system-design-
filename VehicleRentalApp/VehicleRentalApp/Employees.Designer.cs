namespace VehicleRentalApp
{
    partial class Employees
    {

        private System.ComponentModel.IContainer components = null;



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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.HireButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.txtSearch.Location = new System.Drawing.Point(354, 119);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 25);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 180);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(852, 474);
            this.flowLayoutPanel1.TabIndex = 52;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(401, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 50;
            // 
            // HireButton
            // 
            this.HireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.HireButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.HireButton.FlatAppearance.BorderSize = 2;
            this.HireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.HireButton.Location = new System.Drawing.Point(73, 108);
            this.HireButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HireButton.Name = "HireButton";
            this.HireButton.Size = new System.Drawing.Size(195, 42);
            this.HireButton.TabIndex = 47;
            this.HireButton.Text = "Hire a New Employee";
            this.HireButton.UseVisualStyleBackColor = false;
            this.HireButton.Click += new System.EventHandler(this.HireEmployee_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.btnRefresh);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.txtSearch);
            this.contentPanel.Controls.Add(this.flowLayoutPanel1);
            this.contentPanel.Controls.Add(this.label7);
            this.contentPanel.Controls.Add(this.HireButton);
            this.contentPanel.Location = new System.Drawing.Point(-29, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1008, 776);
            this.contentPanel.TabIndex = 56;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Employees at branch (Branch_Address)";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::VehicleRentalApp.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(886, 111);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 38);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(957, 552);
            this.Controls.Add(this.contentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Employees";
            this.Text = "Form1";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button HireButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}