using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBarcodeSystem
{
    public partial class frmDashboard : Form
    {
        bool sidebarExpand;
        bool dropExpand;
        public frmDashboard()
        {
            InitializeComponent();
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void submenuTimer_Tick(object sender, EventArgs e)
        {
            if (dropExpand)
            {
                panel3.Height -= 10;
                if (panel3.Height == panel3.MinimumSize.Height)
                {
                    dropExpand = false;
                    submenuTimer.Stop();
                }
            }
            else
            {
                panel3.Height += 10;
                if (panel3.Height == panel3.MaximumSize.Height)
                {
                    dropExpand = true;
                    submenuTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnstdRes_Click(object sender, EventArgs e)
        {
            if (Program.userRole != "Admin")
            {
                MessageBox.Show("Sorrry....You must have admin previliges");
            }
            else
            {
                lblchange.Text = "LIBRARY USER RESGISTRATION";
                this.Loadpnl.Controls.Clear();
                frmCollegeStudentRegistration frmUserRegister_Vrb = new frmCollegeStudentRegistration() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmUserRegister_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.Loadpnl.Controls.Add(frmUserRegister_Vrb);
                frmUserRegister_Vrb.Show();
            }           
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            if (Program.userRole != "Admin")
            {
                MessageBox.Show("Sorrry....You must have admin previliges");
            }
            else
            {
                lblchange.Text = "USER REGISTRATION";
                this.Loadpnl.Controls.Clear();
                frmUserRegistration frmUserRegister_Vrb = new frmUserRegistration() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmUserRegister_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.Loadpnl.Controls.Add(frmUserRegister_Vrb);
                frmUserRegister_Vrb.Show();
            }
            
           
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                new frmLogin().Show();
                this.Hide();
            }
            /*if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
                //Some task…
            }*/
            
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            if (Program.userRole != "Admin")
            {
                MessageBox.Show("Sorrry....You must have admin previliges");
            }
            else
            {
                lblchange.Text = "REPORT";
                this.Loadpnl.Controls.Clear();
                frmReports frmReports_Vrb = new frmReports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmReports_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.Loadpnl.Controls.Add(frmReports_Vrb);
                frmReports_Vrb.Show();
            }
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            lblchange.Text = "STUDY IN-OUT";
            this.Loadpnl.Controls.Clear();
            frmScan frmScan_Vrb = new frmScan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmScan_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Loadpnl.Controls.Add(frmScan_Vrb);
            frmScan_Vrb.Show();
        }

    }
}
