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
            this.gridCurrentUser = new System.Windows.Forms.DataGridView();
            this.tabManualMode = new System.Windows.Forms.TabPage();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnInOut = new System.Windows.Forms.Button();
            this.gridMscan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMbarcode = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentUser)).BeginInit();
            this.tabManualMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMscan)).BeginInit();
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
            this.tabScanMode.Controls.Add(this.gridCurrentUser);
            this.tabScanMode.Location = new System.Drawing.Point(4, 22);
            this.tabScanMode.Name = "tabScanMode";
            this.tabScanMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabScanMode.Size = new System.Drawing.Size(907, 479);
            this.tabScanMode.TabIndex = 0;
            this.tabScanMode.Text = "Scan Mode";
            this.tabScanMode.UseVisualStyleBackColor = true;
            // 
            // gridCurrentUser
            // 
            this.gridCurrentUser.AllowUserToAddRows = false;
            this.gridCurrentUser.AllowUserToDeleteRows = false;
            this.gridCurrentUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCurrentUser.Location = new System.Drawing.Point(3, 3);
            this.gridCurrentUser.Name = "gridCurrentUser";
            this.gridCurrentUser.ReadOnly = true;
            this.gridCurrentUser.Size = new System.Drawing.Size(901, 473);
            this.gridCurrentUser.TabIndex = 0;
            this.gridCurrentUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCurrentUser_CellContentClick);
            // 
            // tabManualMode
            // 
            this.tabManualMode.BackColor = System.Drawing.Color.DarkGray;
            this.tabManualMode.Controls.Add(this.btnOut);
            this.tabManualMode.Controls.Add(this.btnInOut);
            this.tabManualMode.Controls.Add(this.gridMscan);
            this.tabManualMode.Controls.Add(this.label3);
            this.tabManualMode.Controls.Add(this.txtMbarcode);
            this.tabManualMode.Location = new System.Drawing.Point(4, 22);
            this.tabManualMode.Name = "tabManualMode";
            this.tabManualMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualMode.Size = new System.Drawing.Size(907, 479);
            this.tabManualMode.TabIndex = 1;
            this.tabManualMode.Text = "Manual Mode";
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(724, 9);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(178, 43);
            this.btnOut.TabIndex = 57;
            this.btnOut.Text = "OUT";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Visible = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnInOut
            // 
            this.btnInOut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOut.Location = new System.Drawing.Point(542, 9);
            this.btnInOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnInOut.Name = "btnInOut";
            this.btnInOut.Size = new System.Drawing.Size(178, 43);
            this.btnInOut.TabIndex = 56;
            this.btnInOut.Text = "IN / OUT";
            this.btnInOut.UseVisualStyleBackColor = true;
            this.btnInOut.Click += new System.EventHandler(this.btnInOut_Click);
            // 
            // gridMscan
            // 
            this.gridMscan.AllowUserToAddRows = false;
            this.gridMscan.AllowUserToDeleteRows = false;
            this.gridMscan.Location = new System.Drawing.Point(6, 57);
            this.gridMscan.Name = "gridMscan";
            this.gridMscan.ReadOnly = true;
            this.gridMscan.Size = new System.Drawing.Size(895, 416);
            this.gridMscan.TabIndex = 58;
            this.gridMscan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMscan_CellContentClick);
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
            // txtMbarcode
            // 
            this.txtMbarcode.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbarcode.Location = new System.Drawing.Point(197, 20);
            this.txtMbarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtMbarcode.MaxLength = 45;
            this.txtMbarcode.Name = "txtMbarcode";
            this.txtMbarcode.Size = new System.Drawing.Size(321, 23);
            this.txtMbarcode.TabIndex = 38;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentUser)).EndInit();
            this.tabManualMode.ResumeLayout(false);
            this.tabManualMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMscan)).EndInit();
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
        private System.Windows.Forms.DataGridView gridCurrentUser;
        private System.Windows.Forms.TabPage tabManualMode;
        private LibraryInOutManagementSystemDataSet libraryInOutManagementSystemDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMbarcode;
        private System.Windows.Forms.DataGridView gridMscan;
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
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnInOut;
    }
}