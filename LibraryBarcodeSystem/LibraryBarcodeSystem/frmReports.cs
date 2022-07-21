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
    public partial class frmReports : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        DataTable dtInOut;
        SqlDataReader sdrInOut;
        public frmReports()
        {
            InitializeComponent();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            getuserdetails();
            this.inOutInfoTableAdapter.Fill(this.libraryInOutManagementSystemDataSet.InOutInfo);

        }

        public void getuserdetails()
        {

            SqlCommand cmd = new SqlCommand("Select [Name], [AcademicYear], [Type], [Barcode], [Faculty], [Program], [Date], [InTime], [OutTime], [Status] from [InOutInfo]  ORDER BY [ID] DESC", con);
            dtInOut = new DataTable();

            if (con.State == ConnectionState.Closed) con.Open();

            sdrInOut = cmd.ExecuteReader();
            dtInOut.Load(sdrInOut);

            if (con.State == ConnectionState.Open) con.Close();
            gridreport.DataSource = dtInOut;
        }
        private void btnGR_Click(object sender, EventArgs e)
        {
            if (gridreport.Rows.Count > 1)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < gridreport.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = gridreport.Columns[i - 1].HeaderText;
                }

                int cnt = gridreport.Rows.Count-1;
                for (int a = 0; a < cnt; a++)
                {
        
                    for (int j = 0; j < gridreport.Columns.Count; j++)
                    {
                        xcelApp.Cells[a + 2, j + 1] = gridreport.Rows[a].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            DateTime dtDate1 = DateTime.Parse(datepickerFr.Text);
            DateTime dtDate2 = DateTime.Parse(datepickerTo.Text);
            String chekbox = "";
            SqlCommand cmd;
            if (scChBx.Checked && coChBx.Checked && arChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if(scChBx.Checked && coChBx.Checked && arChBx.Checked){
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && coChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (scChBx.Checked && otChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + otChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (otChBx.Checked && coChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + otChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && coChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'";
            }
            else if (coChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (coChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (arChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + arChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (scChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'";
            }
            else if(coChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'";
            }
            else if (arChBx.Checked)
            {
                chekbox += "'" + arChBx.Text + "'";
            }
            else if (otChBx.Checked)
            {
                chekbox += "'" + otChBx.Text + "'";
            }
            else {
                MessageBox.Show("Please select faculty...","Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chekbox = "'Science','Arts','Commerce','Other'";              
            }

            String chek = chekbox; 
            if(txtname.Text!="")
                cmd = new SqlCommand("select * from InOutInfo where ([Faculty] in (" + chek + ") AND  [Date] between '" + dtDate1.ToString("MM/dd/yyyy") + "' and '" + dtDate2.ToString("MM/dd/yyyy") + "') AND [Name] like '%" + txtname.Text + "%' ORDER BY [ID] DESC ", con);
            else
                cmd = new SqlCommand("select * from InOutInfo where ([Faculty] in (" + chek + ") AND  [Date] between '" + dtDate1.ToString("MM/dd/yyyy") + "' and '" + dtDate2.ToString("MM/dd/yyyy") + "')  ORDER BY [ID] DESC", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            dt.Clear();
            da.Fill(dt);
            gridreport.DataSource = dt;
            con.Close();
        }

        private void btngetFP_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd ;
            DateTime dtDate1 = DateTime.Parse(datepickerFr.Text);
            DateTime dtDate2 = DateTime.Parse(datepickerTo.Text);
            String chekbox = "";
            if (scChBx.Checked && coChBx.Checked && arChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (scChBx.Checked && coChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && coChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (scChBx.Checked && otChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + otChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (otChBx.Checked && coChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + otChBx.Text + "'" + "," + "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && coChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + coChBx.Text + "'";
            }
            else if (coChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && arChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + arChBx.Text + "'";
            }
            else if (scChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (coChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (arChBx.Checked && otChBx.Checked)
            {
                chekbox += "'" + arChBx.Text + "'" + "," + "'" + otChBx.Text + "'";
            }
            else if (scChBx.Checked)
            {
                chekbox += "'" + scChBx.Text + "'";
            }
            else if (coChBx.Checked)
            {
                chekbox += "'" + coChBx.Text + "'";
            }
            else if (arChBx.Checked)
            {
                chekbox += "'" + arChBx.Text + "'";
            }
            else if (otChBx.Checked)
            {
                chekbox += "'" + otChBx.Text + "'";
            }
            else
            {
                MessageBox.Show("Please select faculty...", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chekbox = "'Science','Arts','Commerce','Other'";
            }

            String chek = chekbox;

            if (txtname.Text != "")
            
                 cmd = new SqlCommand("select [Date], count(distinct [Name]) as Students  from InOutInfo where [Faculty] in (" + chek + ") AND [Date] between '" + dtDate1.ToString("MM/dd/yyyy") + "' and '" + dtDate2.ToString("MM/dd/yyyy") + "' GROUP BY [Date]  ORDER BY [Date] DESC", con);
            
            else 
                cmd = new SqlCommand("select [Date], count(distinct [Name]) as Students  from InOutInfo where [Faculty] in (" + chek + ") AND [Date] between '" + dtDate1.ToString("MM/dd/yyyy") + "' and '" + dtDate2.ToString("MM/dd/yyyy") + "' GROUP BY [Date]  ORDER BY [Date] DESC", con);
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            dt.Clear();
            da.Fill(dt);
            gridreport.DataSource = dt;
            con.Close();

        }



    }
}
