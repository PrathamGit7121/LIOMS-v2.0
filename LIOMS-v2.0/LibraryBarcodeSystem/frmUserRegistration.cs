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
    public partial class frmUserRegistration : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        public void getuserdetails()
        {
            SqlCommand cmd = new SqlCommand("Select Name,UserId,Role from UserInfo", con);
            DataTable dt = new DataTable();

            if (con.State == ConnectionState.Closed) con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            if (con.State == ConnectionState.Open) con.Close();

            datagriduserregister.DataSource = dt;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtname.Text == String.Empty || txtuserid.Text == String.Empty || txtpass.Text == String.Empty || txtpass2.Text == String.Empty || txtrole.Text == String.Empty||txtpass==txtpass2)
            {
                MessageBox.Show("Something Went Wrong..!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO UserInfo VALUES(@Name, @UserId, @Password, @Role, @EnteredBy, @EnteredDate)", con);
                    // cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@UserId", txtuserid.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@Role", txtrole.Text);
                    cmd.Parameters.AddWithValue("@EnteredBy", Program.userName);
                    cmd.Parameters.AddWithValue("@EnteredDate", System.DateTime.Now);
                    
                
                    cmd.ExecuteNonQuery();
                    ResetFormControls();
                    getuserdetails();
                    MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuserdetails();
                    if (con.State == ConnectionState.Open) con.Close();       
            }


        }
        private void ResetFormControls()
        {
            txtname.Clear();
            txtuserid.Clear();
            txtpass.Clear();
            txtpass2.Clear();
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            getuserdetails();
        }

        private void datagriduserregister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = datagriduserregister.SelectedRows[0].Cells[0].Value.ToString();
            txtuserid.Text = datagriduserregister.SelectedRows[0].Cells[1].Value.ToString();
            txtrole.Text = datagriduserregister.SelectedRows[0].Cells[2].Value.ToString();
            txtuserid.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtname.Text == String.Empty || txtuserid.Text == String.Empty)
            {
                MessageBox.Show("Click and Select User To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM UserInfo WHERE Name=@Name and UserId=@UrId ", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@UrId", txtuserid.Text);
                    //getuserdetails();
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuserdetails();
                    ResetFormControls();

                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == String.Empty || txtuserid.Text == String.Empty || txtpass.Text == String.Empty || txtpass2.Text == String.Empty || txtrole.Text == String.Empty || txtpass == txtpass2)
            {

                MessageBox.Show("Select User To Upadte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtpass.Text == String.Empty || txtpass2.Text == String.Empty)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    
                    SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET Name=@Name, UserId=@UserId, Role=@Role WHERE UserId=@UserId", con);
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@UserId", txtuserid.Text);
                    cmd.Parameters.AddWithValue("@Role", txtrole.Text);

                    cmd.ExecuteNonQuery();
                    getuserdetails();
                    MessageBox.Show("User Updateted Successfully", "Updateted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (con.State == ConnectionState.Open) con.Close();
                }
                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET Name=@Name, UserId=@UserId, Password=@Password, Role=@Role WHERE UserId=@UserId", con);

                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@UserId", txtuserid.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@Role", txtrole.Text);

                    cmd.ExecuteNonQuery();
                    getuserdetails();
                    MessageBox.Show("User Updated Successfully", "Updateted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (con.State == ConnectionState.Open) con.Close();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFormControls();
            txtuserid.Enabled = true;
            btnSave.Enabled = true;
        }


    }
}
    

