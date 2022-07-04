namespace LibraryBarcodeSystem
{
    partial class frmReports
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
            this.GetReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inOutInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryInOutManagementSystemDataSet = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSet();
            this.inOutInfoTableAdapter = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.scChBx = new System.Windows.Forms.CheckBox();
            this.coChBx = new System.Windows.Forms.CheckBox();
            this.arChBx = new System.Windows.Forms.CheckBox();
            this.otChBx = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetFootprints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GetReport
            // 
            this.GetReport.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetReport.Location = new System.Drawing.Point(567, 91);
            this.GetReport.Margin = new System.Windows.Forms.Padding(2);
            this.GetReport.Name = "GetReport";
            this.GetReport.Size = new System.Drawing.Size(139, 43);
            this.GetReport.TabIndex = 57;
            this.GetReport.Text = "Get To Excel";
            this.GetReport.UseVisualStyleBackColor = true;
            this.GetReport.Click += new System.EventHandler(this.GetReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(914, 385);
            this.dataGridView1.TabIndex = 58;
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
            // inOutInfoTableAdapter
            // 
            this.inOutInfoTableAdapter.ClearBeforeFill = true;
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(55, 26);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(184, 20);
            this.datePickerStart.TabIndex = 59;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(299, 26);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(184, 20);
            this.datePickerEnd.TabIndex = 60;
            // 
            // scChBx
            // 
            this.scChBx.AutoSize = true;
            this.scChBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scChBx.Location = new System.Drawing.Point(503, 12);
            this.scChBx.Name = "scChBx";
            this.scChBx.Size = new System.Drawing.Size(79, 20);
            this.scChBx.TabIndex = 61;
            this.scChBx.Text = "Science ";
            this.scChBx.UseVisualStyleBackColor = true;
            // 
            // coChBx
            // 
            this.coChBx.AutoSize = true;
            this.coChBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coChBx.Location = new System.Drawing.Point(503, 43);
            this.coChBx.Name = "coChBx";
            this.coChBx.Size = new System.Drawing.Size(93, 20);
            this.coChBx.TabIndex = 62;
            this.coChBx.Text = "Commerce";
            this.coChBx.UseVisualStyleBackColor = true;
            // 
            // arChBx
            // 
            this.arChBx.AutoSize = true;
            this.arChBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arChBx.Location = new System.Drawing.Point(608, 12);
            this.arChBx.Name = "arChBx";
            this.arChBx.Size = new System.Drawing.Size(50, 20);
            this.arChBx.TabIndex = 63;
            this.arChBx.Text = "Arts";
            this.arChBx.UseVisualStyleBackColor = true;
            // 
            // otChBx
            // 
            this.otChBx.AutoSize = true;
            this.otChBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otChBx.Location = new System.Drawing.Point(611, 43);
            this.otChBx.Name = "otChBx";
            this.otChBx.Size = new System.Drawing.Size(59, 20);
            this.otChBx.TabIndex = 64;
            this.otChBx.Text = "Other";
            this.otChBx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 66;
            this.button1.Text = "Search ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Name";
            // 
            // GetFootprints
            // 
            this.GetFootprints.DialogResult = System.Windows.Forms.DialogResult.No;
            this.GetFootprints.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFootprints.Location = new System.Drawing.Point(371, 91);
            this.GetFootprints.Margin = new System.Windows.Forms.Padding(2);
            this.GetFootprints.Name = "GetFootprints";
            this.GetFootprints.Size = new System.Drawing.Size(149, 43);
            this.GetFootprints.TabIndex = 70;
            this.GetFootprints.Text = "Get Footprints";
            this.GetFootprints.UseVisualStyleBackColor = true;
            this.GetFootprints.Click += new System.EventHandler(this.GetFootprints_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.GetFootprints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.otChBx);
            this.Controls.Add(this.arChBx);
            this.Controls.Add(this.coChBx);
            this.Controls.Add(this.scChBx);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetReport);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryInOutManagementSystemDataSet libraryInOutManagementSystemDataSet;
        private System.Windows.Forms.BindingSource inOutInfoBindingSource;
        private LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter inOutInfoTableAdapter;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.CheckBox scChBx;
        private System.Windows.Forms.CheckBox coChBx;
        private System.Windows.Forms.CheckBox arChBx;
        private System.Windows.Forms.CheckBox otChBx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetFootprints;

    }
}