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
            this.btnstdRes = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadmin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
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
            this.sidebar.Location = new System.Drawing.Point(4, 4);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(304, 118);
            this.sidebar.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Location = new System.Drawing.Point(100, 47);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(62, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Image = global::LibraryBarcodeSystem.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(17, 36);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(44, 43);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btnstdRes
            // 
            this.btnstdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstdRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstdRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstdRes.Image = global::LibraryBarcodeSystem.Properties.Resources.regis;
            this.btnstdRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstdRes.Location = new System.Drawing.Point(-4, -2);
            this.btnstdRes.Margin = new System.Windows.Forms.Padding(4);
            this.btnstdRes.Name = "btnstdRes";
            this.btnstdRes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnstdRes.Size = new System.Drawing.Size(335, 79);
            this.btnstdRes.TabIndex = 2;
            this.btnstdRes.Text = "               Registration";
            this.btnstdRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstdRes.UseVisualStyleBackColor = true;
            this.btnstdRes.Click += new System.EventHandler(this.btnstdRes_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 2;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInOut);
            this.panel1.Location = new System.Drawing.Point(4, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 63);
            this.panel1.TabIndex = 6;
            // 
            // btnInOut
            // 
            this.btnInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInOut.Image = global::LibraryBarcodeSystem.Properties.Resources.inout;
            this.btnInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInOut.Location = new System.Drawing.Point(-1, -9);
            this.btnInOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnInOut.Name = "btnInOut";
            this.btnInOut.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnInOut.Size = new System.Drawing.Size(335, 79);
            this.btnInOut.TabIndex = 2;
            this.btnInOut.Text = "               In-Out";
            this.btnInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInOut.UseVisualStyleBackColor = true;
            this.btnInOut.Click += new System.EventHandler(this.btnInOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnadmin);
            this.panel2.Location = new System.Drawing.Point(4, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 63);
            this.panel2.TabIndex = 7;
            // 
            // btnadmin
            // 
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadmin.Image = global::LibraryBarcodeSystem.Properties.Resources.user;
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(-1, -9);
            this.btnadmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnadmin.Size = new System.Drawing.Size(335, 79);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "               User";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnreport);
            this.panel4.Location = new System.Drawing.Point(4, 280);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 63);
            this.panel4.TabIndex = 8;
            // 
            // btnreport
            // 
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreport.Image = global::LibraryBarcodeSystem.Properties.Resources.reports;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(-1, -9);
            this.btnreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(335, 79);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "               Report";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnlogout);
            this.panel5.Location = new System.Drawing.Point(4, 422);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 63);
            this.panel5.TabIndex = 9;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Image = global::LibraryBarcodeSystem.Properties.Resources.logout;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(-1, -9);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(335, 79);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "               Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.sidebarContainer.Margin = new System.Windows.Forms.Padding(4);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(308, 1108);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(91, 1108);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(91, 1108);
            this.sidebarContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnstdRes);
            this.panel3.Location = new System.Drawing.Point(4, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MaximumSize = new System.Drawing.Size(304, 274);
            this.panel3.MinimumSize = new System.Drawing.Size(304, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 71);
            this.panel3.TabIndex = 2;
            // 
            // Loadpnl
            // 
            this.Loadpnl.BackColor = System.Drawing.Color.Transparent;
            this.Loadpnl.Location = new System.Drawing.Point(95, 54);
            this.Loadpnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loadpnl.Name = "Loadpnl";
            this.Loadpnl.Size = new System.Drawing.Size(1245, 729);
            this.Loadpnl.TabIndex = 3;
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.ForeColor = System.Drawing.Color.Black;
            this.lblchange.Location = new System.Drawing.Point(103, 9);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(0, 37);
            this.lblchange.TabIndex = 4;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1345, 788);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.Loadpnl);
            this.Controls.Add(this.lblchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnstdRes;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnInOut;
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