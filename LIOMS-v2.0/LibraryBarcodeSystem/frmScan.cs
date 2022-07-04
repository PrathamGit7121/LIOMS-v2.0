using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using System.Data.SqlClient;

namespace LibraryBarcodeSystem
{
    public partial class frmScan : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        SqlCommand cmd, cmd1;
        string[] formats = { "M/d/yyyy", "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy" };
        string dateValue = DateTime.Now.Date.ToString("MM-dd-yyyy");

        DataTable dtInOut, dtLibrary, dtOutIn;
        SqlDataReader sdrInOut, sdrLibrary, sdrOutIn;

        public frmScan()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(txtBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

        }
        private void ResetFormControls()
        {

            textBox1.Clear();
        }
        public void getuserdetails()
        {

            SqlCommand cmd = new SqlCommand("Select [Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime], [Status] from [InOutInfo] WHERE Date='" + dateValue + "'", con);
            dtInOut = new DataTable();

            if (con.State == ConnectionState.Closed) con.Open();

            sdrInOut = cmd.ExecuteReader();
            dtInOut.Load(sdrInOut);


            if (con.State == ConnectionState.Open) con.Close();

            dgvCurrentUsers.DataSource = dtInOut;
        }
        public void getuserdetails1()
        {
            SqlCommand cmd1 = new SqlCommand("Select [Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime], [Status] from [InOutInfo] WHERE Date='" + dateValue + "'", con);
            dtOutIn = new DataTable();

            if (con.State == ConnectionState.Closed) con.Open();

            sdrOutIn = cmd1.ExecuteReader();
            dtOutIn.Load(sdrOutIn);

            if (con.State == ConnectionState.Open) con.Close();
            dataGridview1.DataSource = dtOutIn;
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            String barcodetext = e.Barcode;
            txtBarcode.Text = barcodetext;
            cmd = new SqlCommand("Select [RollNo], [Name], [AcademicYear], [College], [Faculty], [Program], [Status], [Type] from [LibraryUserInfo] WHERE AcademicYear = '" + Program.AcademicYear + "' and Barcode='" + e.Barcode + "'", con);


            dtLibrary = new DataTable();
            sdrLibrary = cmd.ExecuteReader();
            dtLibrary.Load(sdrLibrary);

            if (dtLibrary.Rows.Count == 1)
            {
                cmd = new SqlCommand("Select [Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime], [Status] from [InOutInfo] WHERE Name='" + dtLibrary.Rows[0]["Name"].ToString() + "' AND Status='In'", con);
                dtInOut = new DataTable();

                if (con.State == ConnectionState.Closed) con.Open();
                sdrInOut.Dispose();
                dtInOut.Clear();

                sdrInOut = cmd.ExecuteReader();
                dtInOut.Load(sdrInOut);

                if (con.State == ConnectionState.Open) con.Close();

                if (dtInOut.Rows.Count == 1)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd = new SqlCommand("UPDATE InOutInfo SET Status='Out' WHERE Name='" + dtInOut.Rows[0]["Name"].ToString() + "' AND Status='In'", con);
                    cmd.ExecuteNonQuery();
                    cmd1 = new SqlCommand("UPDATE InOutInfo SET OutTime ='" + DateTime.Now.ToString("HH:mm tt") + "'  WHERE Name='" + dtLibrary.Rows[0]["Name"].ToString() + "' AND OutTime='00:00:00'", con);
                    cmd1.ExecuteNonQuery();
                    ResetFormControls();
                    txtName.Text = "Thank you... " + dtInOut.Rows[0]["Name"].ToString();
                    txtName.ForeColor = Color.Orange;
                    txtBarcode.Focus();

                    getuserdetails();
                    getuserdetails1();
                    // MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (con.State == ConnectionState.Open) con.Close();
                }
                else
                {
               
                    if (con.State == ConnectionState.Closed) con.Open();

                    cmd = new SqlCommand("INSERT INTO InOutInfo([Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime],Status) VALUES(@Name, @AcademicYear, @Type, @Barcode, @Faculty, @Program,@Date,@InTime,@OutTime,@Status)", con);

                    cmd.Parameters.AddWithValue("@Name", dtLibrary.Rows[0]["Name"].ToString());
                    cmd.Parameters.AddWithValue("@AcademicYear", dtLibrary.Rows[0]["AcademicYear"].ToString());
                    cmd.Parameters.AddWithValue("@Barcode", e.Barcode);
                    cmd.Parameters.AddWithValue("@Type", "Internal Student");
                    cmd.Parameters.AddWithValue("@Faculty", dtLibrary.Rows[0]["Faculty"].ToString());
                    cmd.Parameters.AddWithValue("@Program", dtLibrary.Rows[0]["Program"].ToString());
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@InTime", DateTime.Now.ToString("HH:mm tt"));
                    cmd.Parameters.AddWithValue("@OutTime", "");
                    cmd.Parameters.AddWithValue("@Status", "In");

                    cmd.ExecuteNonQuery();

                    txtName.Text = "Welcome... " + dtLibrary.Rows[0]["Name"].ToString();
                    txtName.ForeColor = Color.Green;

                    txtBarcode.Focus();
                    //MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuserdetails();
                    getuserdetails1();
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
            else
            {
                txtName.Text = "No such user exists";
                txtName.ForeColor = Color.Red;
                txtBarcode.Focus();
            }

            if (con.State == ConnectionState.Open) con.Close();
        }

        private void frmScan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryInOutManagementSystemDataSet.InOutInfo' table. You can move, or remove it, as needed.


            DialogResult dialogResult = MessageBox.Show("Do you want to start a new session?", "New Session Alert!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                DialogResult dialogResultConfirm = MessageBox.Show("Are you confirmed to start a new session?", "New Session Confirmation!", MessageBoxButtons.YesNo);
                if (dialogResultConfirm == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd = new SqlCommand("UPDATE InOutInfo SET Status='Out' WHERE Status='In'", con);
                    cmd.ExecuteNonQuery();
                    cmd1 = new SqlCommand("UPDATE InOutInfo SET OutTime ='" + DateTime.Now.ToString("HH:mm tt") + "'  WHERE OutTime='00:00:00'", con);
                    cmd1.ExecuteNonQuery();
                    ResetFormControls();

                    MessageBox.Show("All previously in students are set to out... Started new session");
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("All previously in students are kept as it is... Previous session mentained...");
            }
            getuserdetails();
            getuserdetails1();
            this.inOutInfoTableAdapter.Fill(this.libraryInOutManagementSystemDataSet.InOutInfo);
        }


        //Manual
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();

            String barcodetext = textBox1.Text;
            txtBarcode.Text = barcodetext;
            cmd = new SqlCommand("Select [RollNo], [Name], [AcademicYear], [College], [Faculty], [Program], [Status], [Type] from [LibraryUserInfo] WHERE AcademicYear = '" + Program.AcademicYear + "' and Barcode='" + textBox1.Text + "'", con);

            dtLibrary = new DataTable();
            sdrLibrary = cmd.ExecuteReader();
            dtLibrary.Load(sdrLibrary);

            if (dtLibrary.Rows.Count == 1)
            {
                cmd = new SqlCommand("Select [Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime], [Status] from [InOutInfo] WHERE Name='" + dtLibrary.Rows[0]["Name"].ToString() + "' AND Status='In'", con);
                dtOutIn = new DataTable();

                if (con.State == ConnectionState.Closed) con.Open();
                sdrOutIn.Dispose();
                dtOutIn.Clear();

                sdrOutIn = cmd.ExecuteReader();
                dtOutIn.Load(sdrOutIn);

                if (con.State == ConnectionState.Open) con.Close();

                if (dtOutIn.Rows.Count == 1)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd = new SqlCommand("UPDATE InOutInfo SET Status='Out' WHERE Name='" + dtOutIn.Rows[0]["Name"].ToString() + "' AND Status='In'", con);
                    cmd.ExecuteNonQuery();
                    cmd1 = new SqlCommand("UPDATE InOutInfo SET OutTime ='" + DateTime.Now.ToString("HH:mm tt") + "'  WHERE Name='" + dtLibrary.Rows[0]["Name"].ToString() + "' AND OutTime='00:00:00'", con);
                    cmd1.ExecuteNonQuery();
                    ResetFormControls();
                    txtName.Text = "Thank you... " + dtOutIn.Rows[0]["Name"].ToString();
                    txtName.ForeColor = Color.Orange;
                    textBox1.Focus();
                    getuserdetails();
                    getuserdetails1();
                    // MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (con.State == ConnectionState.Open) con.Close();
                }
                else
                {

                    if (con.State == ConnectionState.Closed) con.Open();

                    cmd = new SqlCommand("INSERT INTO InOutInfo([Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime],Status) VALUES(@Name, @AcademicYear, @Type, @Barcode, @Faculty, @Program,@Date,@InTime,@OutTime,@Status)", con);

                    cmd.Parameters.AddWithValue("@Name", dtLibrary.Rows[0]["Name"].ToString());
                    cmd.Parameters.AddWithValue("@AcademicYear", dtLibrary.Rows[0]["AcademicYear"].ToString());
                    cmd.Parameters.AddWithValue("@Barcode", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Type", "Internal Student");
                    cmd.Parameters.AddWithValue("@Faculty", dtLibrary.Rows[0]["Faculty"].ToString());
                    cmd.Parameters.AddWithValue("@Program", dtLibrary.Rows[0]["Program"].ToString());
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@InTime", DateTime.Now.ToString("HH:mm tt"));
                    cmd.Parameters.AddWithValue("@OutTime", "");
                    cmd.Parameters.AddWithValue("@Status", "In");

                    cmd.ExecuteNonQuery();

                    txtName.Text = "Welcome... " + dtLibrary.Rows[0]["Name"].ToString();
                    txtName.ForeColor = Color.Green;

                    textBox1.Focus();
                    //MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuserdetails();
                    getuserdetails1();
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
            else
            {
                txtName.Text = "No such user exists";
                txtName.ForeColor = Color.Red;
                txtBarcode.Focus();
            }

            if (con.State == ConnectionState.Open) con.Close();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.Focus(); 
        }

        private void dgvCurrentUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Focus();
        }
    }

}