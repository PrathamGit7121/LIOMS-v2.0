namespace LibraryBarcodeSystem
{
    partial class frmCollegeStudentRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtacademic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncollegestudentupload = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.datagridstudentregister = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.cmbprogram = new System.Windows.Forms.ComboBox();
            this.cmbfaculty = new System.Windows.Forms.ComboBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.cmbdivision = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.btnexternalstudentupload = new System.Windows.Forms.Button();
            this.btnteacherupload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkteacher = new System.Windows.Forms.LinkLabel();
            this.linkexstd = new System.Windows.Forms.LinkLabel();
            this.linkcollegestd = new System.Windows.Forms.LinkLabel();
            this.libraryInOutManagementSystemDataSet = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.datagridstudentregister)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(156, 27);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.MaxLength = 45;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 27);
            this.txtname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Academic year";
            // 
            // txtacademic
            // 
            this.txtacademic.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacademic.Location = new System.Drawing.Point(156, 137);
            this.txtacademic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtacademic.MaxLength = 45;
            this.txtacademic.Name = "txtacademic";
            this.txtacademic.Size = new System.Drawing.Size(200, 27);
            this.txtacademic.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Barcode";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(156, 192);
            this.txtbarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbarcode.MaxLength = 45;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(200, 27);
            this.txtbarcode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Faculty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "College";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "RollNo";
            // 
            // txtrollno
            // 
            this.txtrollno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrollno.Location = new System.Drawing.Point(156, 82);
            this.txtrollno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrollno.MaxLength = 45;
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(200, 27);
            this.txtrollno.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Division";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Class";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Program";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(379, 591);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(173, 53);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(604, 591);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(173, 53);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(829, 591);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(173, 53);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncollegestudentupload
            // 
            this.btncollegestudentupload.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncollegestudentupload.Location = new System.Drawing.Point(379, 666);
            this.btncollegestudentupload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncollegestudentupload.Name = "btncollegestudentupload";
            this.btncollegestudentupload.Size = new System.Drawing.Size(268, 47);
            this.btncollegestudentupload.TabIndex = 15;
            this.btncollegestudentupload.Text = "COLLEGE STUDENT UPLOAD";
            this.btncollegestudentupload.UseVisualStyleBackColor = true;
            this.btncollegestudentupload.Click += new System.EventHandler(this.btncollegestudentupload_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(1055, 591);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(173, 53);
            this.btnreset.TabIndex = 14;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // datagridstudentregister
            // 
            this.datagridstudentregister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridstudentregister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridstudentregister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridstudentregister.Location = new System.Drawing.Point(379, 27);
            this.datagridstudentregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridstudentregister.Name = "datagridstudentregister";
            this.datagridstudentregister.RowTemplate.Height = 24;
            this.datagridstudentregister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridstudentregister.Size = new System.Drawing.Size(852, 540);
            this.datagridstudentregister.TabIndex = 32;
            this.datagridstudentregister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridstudentregister_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 543);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Type";
            // 
            // cmbCollege
            // 
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Items.AddRange(new object[] {
            "",
            "Gogate Jogalekar College",
            "Abhyankar Kulkarni College",
            "Other"});
            this.cmbCollege.Location = new System.Drawing.Point(156, 247);
            this.cmbCollege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(200, 24);
            this.cmbCollege.TabIndex = 4;
            // 
            // cmbprogram
            // 
            this.cmbprogram.FormattingEnabled = true;
            this.cmbprogram.Items.AddRange(new object[] {
            "",
            "UG",
            "PG",
            "Other"});
            this.cmbprogram.Location = new System.Drawing.Point(156, 346);
            this.cmbprogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbprogram.Name = "cmbprogram";
            this.cmbprogram.Size = new System.Drawing.Size(200, 24);
            this.cmbprogram.TabIndex = 6;
            // 
            // cmbfaculty
            // 
            this.cmbfaculty.FormattingEnabled = true;
            this.cmbfaculty.Items.AddRange(new object[] {
            "",
            "Science",
            "Commerce",
            "Arts",
            "Other"});
            this.cmbfaculty.Location = new System.Drawing.Point(156, 297);
            this.cmbfaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbfaculty.Name = "cmbfaculty";
            this.cmbfaculty.Size = new System.Drawing.Size(200, 24);
            this.cmbfaculty.TabIndex = 5;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "",
            "XI",
            "XII",
            "FY",
            "SY",
            "TY",
            "Part I",
            "Part II",
            "Other"});
            this.cmbclass.Location = new System.Drawing.Point(156, 395);
            this.cmbclass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(200, 24);
            this.cmbclass.TabIndex = 7;
            // 
            // cmbdivision
            // 
            this.cmbdivision.FormattingEnabled = true;
            this.cmbdivision.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "Other"});
            this.cmbdivision.Location = new System.Drawing.Point(156, 444);
            this.cmbdivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbdivision.Name = "cmbdivision";
            this.cmbdivision.Size = new System.Drawing.Size(200, 24);
            this.cmbdivision.TabIndex = 8;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "",
            "Active",
            "Deactive"});
            this.cmbstatus.Location = new System.Drawing.Point(156, 494);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(200, 24);
            this.cmbstatus.TabIndex = 9;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "",
            "CollegeStudent",
            "ExternalStudent",
            "Staff"});
            this.cmbtype.Location = new System.Drawing.Point(156, 543);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(200, 24);
            this.cmbtype.TabIndex = 10;
            // 
            // btnexternalstudentupload
            // 
            this.btnexternalstudentupload.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexternalstudentupload.Location = new System.Drawing.Point(671, 666);
            this.btnexternalstudentupload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexternalstudentupload.Name = "btnexternalstudentupload";
            this.btnexternalstudentupload.Size = new System.Drawing.Size(268, 47);
            this.btnexternalstudentupload.TabIndex = 16;
            this.btnexternalstudentupload.Text = "EXTERNAL STUDENT UPLOAD";
            this.btnexternalstudentupload.UseVisualStyleBackColor = true;
            this.btnexternalstudentupload.Click += new System.EventHandler(this.btnexternalstudentupload_Click);
            // 
            // btnteacherupload
            // 
            this.btnteacherupload.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacherupload.Location = new System.Drawing.Point(963, 666);
            this.btnteacherupload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnteacherupload.Name = "btnteacherupload";
            this.btnteacherupload.Size = new System.Drawing.Size(268, 47);
            this.btnteacherupload.TabIndex = 17;
            this.btnteacherupload.Text = "TEACHER UPLOAD";
            this.btnteacherupload.UseVisualStyleBackColor = true;
            this.btnteacherupload.Click += new System.EventHandler(this.btnteacherupload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkteacher);
            this.groupBox1.Controls.Add(this.linkexstd);
            this.groupBox1.Controls.Add(this.linkcollegestd);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 591);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(343, 123);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample Downloads";
            // 
            // linkteacher
            // 
            this.linkteacher.AutoSize = true;
            this.linkteacher.LinkColor = System.Drawing.Color.White;
            this.linkteacher.Location = new System.Drawing.Point(31, 86);
            this.linkteacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkteacher.Name = "linkteacher";
            this.linkteacher.Size = new System.Drawing.Size(187, 17);
            this.linkteacher.TabIndex = 35;
            this.linkteacher.TabStop = true;
            this.linkteacher.Text = "Teacher Upload Sample File";
            this.linkteacher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkteacher_LinkClicked);
            // 
            // linkexstd
            // 
            this.linkexstd.AutoSize = true;
            this.linkexstd.LinkColor = System.Drawing.Color.White;
            this.linkexstd.Location = new System.Drawing.Point(31, 55);
            this.linkexstd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkexstd.Name = "linkexstd";
            this.linkexstd.Size = new System.Drawing.Size(238, 17);
            this.linkexstd.TabIndex = 35;
            this.linkexstd.TabStop = true;
            this.linkexstd.Text = "External Student Upload Sample File";
            this.linkexstd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkexstd_LinkClicked);
            // 
            // linkcollegestd
            // 
            this.linkcollegestd.AutoSize = true;
            this.linkcollegestd.LinkColor = System.Drawing.Color.White;
            this.linkcollegestd.Location = new System.Drawing.Point(31, 20);
            this.linkcollegestd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkcollegestd.Name = "linkcollegestd";
            this.linkcollegestd.Size = new System.Drawing.Size(234, 17);
            this.linkcollegestd.TabIndex = 35;
            this.linkcollegestd.TabStop = true;
            this.linkcollegestd.Text = "College Student Upload Sample File";
            this.linkcollegestd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcollegestd_LinkClicked);
            // 
            // libraryInOutManagementSystemDataSet
            // 
            this.libraryInOutManagementSystemDataSet.DataSetName = "LibraryInOutManagementSystemDataSet";
            this.libraryInOutManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCollegeStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1245, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbfaculty);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.cmbdivision);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.cmbprogram);
            this.Controls.Add(this.cmbCollege);
            this.Controls.Add(this.datagridstudentregister);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnteacherupload);
            this.Controls.Add(this.btnexternalstudentupload);
            this.Controls.Add(this.btncollegestudentupload);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtacademic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCollegeStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCollegeStudentRegistration";
            this.Load += new System.EventHandler(this.frmCollegeStudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridstudentregister)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtacademic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncollegestudentupload;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView datagridstudentregister;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.ComboBox cmbprogram;
        private System.Windows.Forms.ComboBox cmbfaculty;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.ComboBox cmbdivision;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnexternalstudentupload;
        private System.Windows.Forms.Button btnteacherupload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkcollegestd;
        private System.Windows.Forms.LinkLabel linkteacher;
        private System.Windows.Forms.LinkLabel linkexstd;
        private LibraryInOutManagementSystemDataSet libraryInOutManagementSystemDataSet;
    }
}