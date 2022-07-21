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
using _Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime;
using System.IO;

namespace LibraryBarcodeSystem
{
    public partial class frmCollegeStudentRegistration : Form
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        public frmCollegeStudentRegistration()
        {
            InitializeComponent();
        }

        public void getuserdetails()
        {
            SqlCommand cmd = new SqlCommand("Select [AcademicYear], [RollNo], [Name], [Barcode],  [College], [Faculty], [Program], [Class], [Division],  [Status], [Type] from [LibraryUserInfo]", con);
            DataTable dt = new DataTable();

            if (con.State == ConnectionState.Closed)  con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            
            if (con.State == ConnectionState.Open) con.Close();
            datagridstudentregister.DataSource = dt;
        }

        private void ResetFormControls()
        {
            txtname.Clear();
            txtbarcode.Clear();
            txtacademic.Clear();
           // txtcollege.Clear();
           // txtprogram.Clear();
            //txtfaculty.Clear();
           // txtclass.Clear();
           // txtdivision.Clear();
            txtrollno.Clear();
            //txtstatus.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == String.Empty)
            {
                MessageBox.Show("Something Went Wrong..!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO LibraryUserInfo([Name], [Barcode], [AcademicYear], [College], [Faculty], [Program], [Class], [Division], [RollNo], [Type], [Status], [EnteredBy], [EnteredDate]) VALUES(@Name, @Barcode, @AcademicYear, @College, @Faculty, @Program,@Class,@Division,@RollNo,@Status,@Type,@EnteredBy,@EnteredDate)", con);

                cmd.Parameters.AddWithValue("@AcademicYear", txtacademic.Text);
                cmd.Parameters.AddWithValue("@RollNo", txtrollno.Text);
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Barcode", txtbarcode.Text);

                cmd.Parameters.AddWithValue("@College", cmbCollege.Items[cmbCollege.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Faculty", cmbfaculty.Items[cmbfaculty.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Program", cmbprogram.Items[cmbprogram.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Class", cmbclass.Items[cmbclass.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Division", cmbdivision.Items[cmbdivision.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Status", cmbstatus.Items[cmbstatus.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Type", cmbtype.Items[cmbtype.SelectedIndex].ToString());

                cmd.Parameters.AddWithValue("@EnteredBy", Program.userName);
                cmd.Parameters.AddWithValue("@EnteredDate", System.DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                ResetFormControls();
                getuserdetails();
                MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (con.State == ConnectionState.Open) con.Close();

            }
        }


        private void frmCollegeStudentRegistration_Load(object sender, EventArgs e)
        {
            getuserdetails();
        }

        private void datagridstudentregister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtacademic.Text = datagridstudentregister.SelectedRows[0].Cells["AcademicYear"].Value.ToString();
            txtrollno.Text = datagridstudentregister.SelectedRows[0].Cells["RollNo"].Value.ToString();
            txtname.Text = datagridstudentregister.SelectedRows[0].Cells["Name"].Value.ToString();
            txtbarcode.Text = datagridstudentregister.SelectedRows[0].Cells["Barcode"].Value.ToString();
            
            cmbCollege.Text = datagridstudentregister.SelectedRows[0].Cells["College"].Value.ToString();
            cmbfaculty.Text = datagridstudentregister.SelectedRows[0].Cells["Faculty"].Value.ToString();
            cmbprogram.Text = datagridstudentregister.SelectedRows[0].Cells["Program"].Value.ToString();
           cmbclass.Text = datagridstudentregister.SelectedRows[0].Cells["Class"].Value.ToString();
           cmbdivision.Text = datagridstudentregister.SelectedRows[0].Cells["Division"].Value.ToString();          
           cmbstatus.Text = datagridstudentregister.SelectedRows[0].Cells["Status"].Value.ToString();
           cmbtype.Text = datagridstudentregister.SelectedRows[0].Cells["Type"].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void btncollegestudentupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.ShowDialog();
            string connetionString = null;
            SqlConnection con;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con = new SqlConnection(connetionString);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
                _Excel._Application xlApp = new _Excel.Application();
                _Excel._Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                _Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
                _Excel.Range xlRange = xlWorkSheet.UsedRange;

                int rowCount = 0;
                for (int i = 1; xlRange.Cells[i, 1].Value2!=null; i++)
                {
                    rowCount++;
                }

                int colCount = 9;
                String valueStr = "";

                try
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        valueStr = valueStr + "(";
                        valueStr = valueStr + "'" + xlRange.Cells[i, 1].Value2.ToString()+ "','"
                                            + xlRange.Cells[i, 2].Value2.ToString() + "','" 
                                            + xlRange.Cells[i, 3].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 4].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 5].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 6].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 7].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 8].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 9].Value2.ToString() + "', 'Active','College','"
                                            + Program.userName + "','"
                                            + DateTime.Now.ToString() + "'";
                        valueStr = valueStr + "),";
                    }

                   // MessageBox.Show(valueStr);
                    valueStr = valueStr.Remove(valueStr.Length - 1, 1);

                    String sqlStr = "insert into LibraryUserInfo values " + valueStr;
               
                    if (con.State == ConnectionState.Closed) con.Open();
                    
                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.ExecuteNonQuery();
                   
                    
                    if (con.State == ConnectionState.Open) con.Close();
                    getuserdetails();
                    MessageBox.Show("New College Student User(s) Uploaded", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

              //  MessageBox.Show(valueStr);
            }
        }

        private void btnexternalstudentupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.ShowDialog();
            string connetionString = null;
            SqlConnection con;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con = new SqlConnection(connetionString);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
                _Excel._Application xlApp = new _Excel.Application();
                _Excel._Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                _Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
                _Excel.Range xlRange = xlWorkSheet.UsedRange;
                int rowCount = 0;
                for (int i = 1; xlRange.Cells[i, 1].Value2!=null; i++)
                {
                    rowCount++;
                }
                int colCount = 4;
                String valueStr = "";

                try
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        valueStr = valueStr + "(";
                        valueStr = valueStr + "'" + xlRange.Cells[i, 1].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 2].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 3].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 4].Value2.ToString() + "','Other','Other','Other','Other','Other', 'Active','External',' "
                                            + Program.userName + "','"
                                            + DateTime.Now.ToString() + "'";
                        valueStr = valueStr + "),";
                    }

                  //  MessageBox.Show(valueStr);
                    valueStr = valueStr.Remove(valueStr.Length - 1, 1);

                    String sqlStr = "insert into LibraryUserInfo values " + valueStr;

                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.ExecuteNonQuery();


                    if (con.State == ConnectionState.Open) con.Close();
                    getuserdetails();
                    MessageBox.Show("New External Student User(s) Uploaded", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

               // MessageBox.Show(valueStr);
            }
        }

        private void btnteacherupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.ShowDialog();
            string connetionString = null;
            SqlConnection con;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con = new SqlConnection(connetionString);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
                _Excel._Application xlApp = new _Excel.Application();
                _Excel._Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                _Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
                _Excel.Range xlRange = xlWorkSheet.UsedRange;
                int rowCount = 0;
                for (int i = 1; xlRange.Cells[i, 1].Value2!= null; i++)
                {
                    rowCount++;
                }
                int colCount = 6;
                String valueStr = "";

                try
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        valueStr = valueStr + "(";
                        valueStr = valueStr + "'" + xlRange.Cells[i, 1].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 2].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 3].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 4].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 5].Value2.ToString() + "','"
                                            + xlRange.Cells[i, 6].Value2.ToString() + "','Other','Other','Other', 'Active','Teacher',' "
                                            + Program.userName + "','"
                                            + DateTime.Now.ToString() + "'";
                        valueStr = valueStr + "),";
                    }

                  //  MessageBox.Show(valueStr);
                    valueStr = valueStr.Remove(valueStr.Length - 1, 1);

                    String sqlStr = "insert into LibraryUserInfo values " + valueStr;

                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.ExecuteNonQuery();


                    if (con.State == ConnectionState.Open) con.Close();
                    getuserdetails();
                    MessageBox.Show("New Teacher User(s) Uploaded", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

               // MessageBox.Show(valueStr);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
           if (txtrollno.Text != String.Empty)
            {
               if (con.State == ConnectionState.Closed) con.Open();

               SqlCommand cmd = new SqlCommand("UPDATE LibraryUserInfo SET Name=@Name, Barcode=@Barcode, College=@College, Faculty=@Faculty, Program=@Program, Class=@Class, Division=@Division, Status=@Status, EnteredBy=@EnteredBy, EnteredDate=@EnteredDate WHERE RollNo=@RollNo and AcademicYear=@AcademicYear and Type=@Type", con);
                
                cmd.Parameters.AddWithValue("@AcademicYear", txtacademic.Text);
                cmd.Parameters.AddWithValue("@RollNo", txtrollno.Text);
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Barcode", txtbarcode.Text);
                
                cmd.Parameters.AddWithValue("@College", cmbCollege.Text);
                cmd.Parameters.AddWithValue("@Faculty", cmbfaculty.Text);
                cmd.Parameters.AddWithValue("@Program", cmbprogram.Text);
                cmd.Parameters.AddWithValue("@Class", cmbclass.Text);
                cmd.Parameters.AddWithValue("@Division", cmbdivision.Text);
                cmd.Parameters.AddWithValue("@Status", cmbstatus.Text);
                cmd.Parameters.AddWithValue("@Type", cmbtype.Text);

                cmd.Parameters.AddWithValue("@EnteredBy", Program.userName);
                cmd.Parameters.AddWithValue("@EnteredDate", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                ResetFormControls();
                getuserdetails();
                MessageBox.Show("User Updateted Successfully", "Updateted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (con.State == ConnectionState.Open) con.Close();
            }
            else
            {
                MessageBox.Show("Please select appropriate students from Grid for updation", "Updateted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            

            if (txtrollno.Text == String.Empty)
            {
                MessageBox.Show("Click and Select User To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM LibraryUserInfo WHERE RollNo=@rollNo and AcademicYear=@AcademicYear", con);
                    //cmd.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@AcademicYear", txtacademic.Text);
                    cmd1.Parameters.AddWithValue("@rollNo", txtrollno.Text);
                    
                    cmd1.ExecuteNonQuery();

                    getuserdetails();
                    ResetFormControls();
                    MessageBox.Show("Student Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (con.State == ConnectionState.Open) con.Close();
                    
                }
            }

            
        }

        private void linkcollegestd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                const string MyFileName = "CollegeStudentUpload.xlsx";

                string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                var filePath = Path.Combine(execPath, MyFileName);

                Microsoft.Office.Interop.Excel.Application app = new _Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);

                book.SaveAs(saveFileDialog.FileName); //Save

                book.Close();
            }           
        }

        private void linkexstd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                const string MyFileName = "ExternalStudentUpload.xlsx";

                string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                var filePath = Path.Combine(execPath, MyFileName);

                Microsoft.Office.Interop.Excel.Application app = new _Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);

                book.SaveAs(saveFileDialog.FileName); //Save

                book.Close();
            }
        }

        private void linkteacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                const string MyFileName = "TeacherUpload.xlsx";

                string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                var filePath = Path.Combine(execPath, MyFileName);

                Microsoft.Office.Interop.Excel.Application app = new _Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);

                book.SaveAs(saveFileDialog.FileName); //Save

                book.Close();
            }
        }

    }
}
