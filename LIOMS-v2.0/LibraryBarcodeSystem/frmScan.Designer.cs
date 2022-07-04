namespace LibraryBarcodeSystem
{
    partial class frmScan
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.tabScanControl = new System.Windows.Forms.TabControl();
            this.tabScanMode = new System.Windows.Forms.TabPage();
            this.dgvCurrentUsers = new System.Windows.Forms.DataGridView();
            this.tabManualMode = new System.Windows.Forms.TabPage();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inOutInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryInOutManagementSystemDataSet = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSet();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.inOutInfoTableAdapter = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter();
            this.tabScanControl.SuspendLayout();
            this.tabScanMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentUsers)).BeginInit();
            this.tabManualMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBarcode.Location = new System.Drawing.Point(1, 1);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(411, 43);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // tabScanControl
            // 
            this.tabScanControl.Controls.Add(this.tabScanMode);
            this.tabScanControl.Controls.Add(this.tabManualMode);
            this.tabScanControl.Location = new System.Drawing.Point(1, 50);
            this.tabScanControl.Name = "tabScanControl";
            this.tabScanControl.SelectedIndex = 0;
            this.tabScanControl.Size = new System.Drawing.Size(915, 505);
            this.tabScanControl.TabIndex = 1;
            // 
            // tabScanMode
            // 
            this.tabScanMode.Controls.Add(this.dgvCurrentUsers);
            this.tabScanMode.Location = new System.Drawing.Point(4, 22);
            this.tabScanMode.Name = "tabScanMode";
            this.tabScanMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabScanMode.Size = new System.Drawing.Size(907, 479);
            this.tabScanMode.TabIndex = 0;
            this.tabScanMode.Text = "Scan Mode";
            this.tabScanMode.UseVisualStyleBackColor = true;
            // 
            // dgvCurrentUsers
            // 
            this.dgvCurrentUsers.AllowUserToAddRows = false;
            this.dgvCurrentUsers.AllowUserToDeleteRows = false;
            this.dgvCurrentUsers.AllowUserToResizeRows = false;
            this.dgvCurrentUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvCurrentUsers.Name = "dgvCurrentUsers";
            this.dgvCurrentUsers.ReadOnly = true;
            this.dgvCurrentUsers.Size = new System.Drawing.Size(901, 473);
            this.dgvCurrentUsers.TabIndex = 0;
            this.dgvCurrentUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentUsers_CellContentClick);
            // 
            // tabManualMode
            // 
            this.tabManualMode.BackColor = System.Drawing.Color.DarkGray;
            this.tabManualMode.Controls.Add(this.btndelete);
            this.tabManualMode.Controls.Add(this.btnadd);
            this.tabManualMode.Controls.Add(this.dataGridview1);
            this.tabManualMode.Controls.Add(this.label3);
            this.tabManualMode.Controls.Add(this.textBox1);
            this.tabManualMode.Location = new System.Drawing.Point(4, 22);
            this.tabManualMode.Name = "tabManualMode";
            this.tabManualMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualMode.Size = new System.Drawing.Size(907, 479);
            this.tabManualMode.TabIndex = 1;
            this.tabManualMode.Text = "Manual Mode";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(724, 9);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(178, 43);
            this.btndelete.TabIndex = 57;
            this.btndelete.Text = "OUT";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(542, 9);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(178, 43);
            this.btnadd.TabIndex = 56;
            this.btnadd.Text = "IN / OUT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.Location = new System.Drawing.Point(6, 57);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.ReadOnly = true;
            this.dataGridview1.Size = new System.Drawing.Size(895, 416);
            this.dataGridview1.TabIndex = 58;
            this.dataGridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Barcode";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 23);
            this.textBox1.TabIndex = 38;
            // 
            // inOutInfoBindingSource
            // 
            this.inOutInfoBindingSource.DataMember = "InOutInfo";
            this.inOutInfoBindingSource.DataSource = this.libraryInOutManagementSystemDataSet;
            // 
            // libraryInOutManagementSystemDataSet
            // 
            this.libraryInOutManagementSystemDataSet.DataSetName = "LibraryInOutManagementSystemDataSet";
            this.libraryInOutManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // academicYearDataGridViewTextBoxColumn1
            // 
            this.academicYearDataGridViewTextBoxColumn1.DataPropertyName = "AcademicYear";
            this.academicYearDataGridViewTextBoxColumn1.HeaderText = "AcademicYear";
            this.academicYearDataGridViewTextBoxColumn1.Name = "academicYearDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // barcodeDataGridViewTextBoxColumn1
            // 
            this.barcodeDataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn1.Name = "barcodeDataGridViewTextBoxColumn1";
            // 
            // facultyDataGridViewTextBoxColumn1
            // 
            this.facultyDataGridViewTextBoxColumn1.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn1.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn1.Name = "facultyDataGridViewTextBoxColumn1";
            // 
            // programDataGridViewTextBoxColumn1
            // 
            this.programDataGridViewTextBoxColumn1.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn1.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn1.Name = "programDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // inTimeDataGridViewTextBoxColumn1
            // 
            this.inTimeDataGridViewTextBoxColumn1.DataPropertyName = "InTime";
            this.inTimeDataGridViewTextBoxColumn1.HeaderText = "InTime";
            this.inTimeDataGridViewTextBoxColumn1.Name = "inTimeDataGridViewTextBoxColumn1";
            // 
            // outTimeDataGridViewTextBoxColumn1
            // 
            this.outTimeDataGridViewTextBoxColumn1.DataPropertyName = "OutTime";
            this.outTimeDataGridViewTextBoxColumn1.HeaderText = "OutTime";
            this.outTimeDataGridViewTextBoxColumn1.Name = "outTimeDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(418, 1);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(498, 43);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // inOutInfoTableAdapter
            // 
            this.inOutInfoTableAdapter.ClearBeforeFill = true;
            // 
            // frmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.tabScanControl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBarcode);
            this.Name = "frmScan";
            this.Load += new System.EventHandler(this.frmScan_Load);
            this.tabScanControl.ResumeLayout(false);
            this.tabScanMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentUsers)).EndInit();
            this.tabManualMode.ResumeLayout(false);
            this.tabManualMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TabControl tabScanControl;
        private System.Windows.Forms.TabPage tabScanMode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvCurrentUsers;
        private System.Windows.Forms.TabPage tabManualMode;
        private LibraryInOutManagementSystemDataSet libraryInOutManagementSystemDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.BindingSource inOutInfoBindingSource;
        private LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter inOutInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
    }
}