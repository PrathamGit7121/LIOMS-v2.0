using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebar
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool dropExpand;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Form2.show();
            new Form2().Show();
        }*/

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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            submenuTimer.Start();
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
