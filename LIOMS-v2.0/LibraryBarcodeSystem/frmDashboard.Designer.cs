namespace LibraryBarcodeSystem
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.submenuTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Loadpnl = new System.Windows.Forms.Panel();
            this.lblchange = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.sidebarContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // submenuTimer
            // 
            this.submenuTimer.Interval = 10;
            this.submenuTimer.Tick += new System.EventHandler(this.submenuTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.Menu);
            this.sidebar.Controls.Add(this.menuButton);
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(228, 96);
            this.sidebar.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Location = new System.Drawing.Point(75, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 21);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Image = global::LibraryBarcodeSystem.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(13, 29);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 35);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::LibraryBarcodeSystem.Properties.Resources.regis;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, -2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(251, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "               Registration";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 2;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 51);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::LibraryBarcodeSystem.Properties.Resources.inout;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-1, -7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(251, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "               In-Out";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 51);
            this.panel2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::LibraryBarcodeSystem.Properties.Resources.user;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-1, -7);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(251, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "               User";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 51);
            this.panel4.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::LibraryBarcodeSystem.Properties.Resources.reports;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-1, -7);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(251, 64);
            this.button4.TabIndex = 2;
            this.button4.Text = "               Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(3, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 51);
            this.panel5.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::LibraryBarcodeSystem.Properties.Resources.logout;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-1, -7);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(251, 64);
            this.button5.TabIndex = 2;
            this.button5.Text = "               Logout";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebarContainer.Controls.Add(this.sidebar);
            this.sidebarContainer.Controls.Add(this.panel3);
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel4);
            this.sidebarContainer.Controls.Add(this.panel2);
            this.sidebarContainer.Controls.Add(this.panel5);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(231, 900);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(68, 900);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(68, 900);
            this.sidebarContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 105);
            this.panel3.MaximumSize = new System.Drawing.Size(228, 223);
            this.panel3.MinimumSize = new System.Drawing.Size(228, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 58);
            this.panel3.TabIndex = 2;
            // 
            // Loadpnl
            // 
            this.Loadpnl.BackColor = System.Drawing.Color.Transparent;
            this.Loadpnl.Location = new System.Drawing.Point(71, 44);
            this.Loadpnl.Margin = new System.Windows.Forms.Padding(2);
            this.Loadpnl.Name = "Loadpnl";
            this.Loadpnl.Size = new System.Drawing.Size(934, 592);
            this.Loadpnl.TabIndex = 3;
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.ForeColor = System.Drawing.Color.Black;
            this.lblchange.Location = new System.Drawing.Point(77, 7);
            this.lblchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(0, 30);
            this.lblchange.TabIndex = 4;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1009, 640);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.Loadpnl);
            this.Controls.Add(this.lblchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.sidebarContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer submenuTimer;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel Loadpnl;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Panel panel3;
    }
}