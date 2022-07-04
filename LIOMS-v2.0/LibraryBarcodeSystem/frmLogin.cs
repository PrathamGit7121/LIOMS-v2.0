using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryBarcodeSystem
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("select * from UserInfo where [UserId]=@txtUsername", con);
                    cmd.Parameters.AddWithValue("@txtUsername", txtUsername.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    dr.Read();

                    if (dr.HasRows)
                    {
                        if ((dr["UserId"].ToString() == username) && (dr["Password"].ToString() == password))
                        {
                            Program.userName = dr.GetValue(1).ToString();
                            Program.userRole = dr.GetValue(3).ToString();
                            new frmDashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password Not Match", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Not found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    
                    dr.Close();                 
                    if (con.State == ConnectionState.Open) con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
        }
    }

