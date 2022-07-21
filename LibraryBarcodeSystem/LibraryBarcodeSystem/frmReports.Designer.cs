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
            this.btnGR = new System.Windows.Forms.Button();
            this.gridreport = new System.Windows.Forms.DataGridView();
            this.inOutInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryInOutManagementSystemDataSet = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSet();
            this.inOutInfoTableAdapter = new LibraryBarcodeSystem.LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter();
            this.datepickerFr = new System.Windows.Forms.DateTimePicker();
            this.datepickerTo = new System.Windows.Forms.DateTimePicker();
            this.scChBx = new System.Windows.Forms.CheckBox();
            this.coChBx = new System.Windows.Forms.CheckBox();
            this.arChBx = new System.Windows.Forms.CheckBox();
            this.otChBx = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngetFP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGR
            // 
            this.btnGR.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGR.Location = new System.Drawing.Point(768, 74);
            this.btnGR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGR.Name = "btnGR";
            this.btnGR.Size = new System.Drawing.Size(139, 43);
            this.btnGR.TabIndex = 57;
            this.btnGR.Tag = "";
            this.btnGR.Text = "Export EXCEL";
            this.btnGR.UseVisualStyleBackColor = true;
            this.btnGR.Click += new System.EventHandler(this.btnGR_Click);
            // 
            // gridreport
            // 
            this.gridreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridreport.Location = new System.Drawing.Point(3, 133);
            this.gridreport.Name = "gridreport";
            this.gridreport.ReadOnly = true;
            this.gridreport.Size = new System.Drawing.Size(914, 416);
            this.gridreport.TabIndex = 58;
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
            // datepickerFr
            // 
            this.datepickerFr.Location = new System.Drawing.Point(55, 26);
            this.datepickerFr.Name = "datepickerFr";
            this.datepickerFr.Size = new System.Drawing.Size(184, 20);
            this.datepickerFr.TabIndex = 59;

            // 
            // datepickerTo
            // 
            this.datepickerTo.Location = new System.Drawing.Point(299, 26);
            this.datepickerTo.Name = "datepickerTo";
            this.datepickerTo.Size = new System.Drawing.Size(184, 20);
            this.datepickerTo.TabIndex = 60;
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
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(744, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 65;
            // 
            // btnsearch
            // 
            this.btnsearch.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(276, 74);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(149, 43);
            this.btnsearch.TabIndex = 66;
            this.btnsearch.Text = "Search ";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            // btngetFP
            // 
            this.btngetFP.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btngetFP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetFP.Location = new System.Drawing.Point(440, 74);
            this.btngetFP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngetFP.Name = "btngetFP";
            this.btngetFP.Size = new System.Drawing.Size(149, 43);
            this.btngetFP.TabIndex = 70;
            this.btngetFP.Text = "Footprints";
            this.btngetFP.UseVisualStyleBackColor = true;
            this.btngetFP.Click += new System.EventHandler(this.btngetFP_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.btngetFP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.otChBx);
            this.Controls.Add(this.arChBx);
            this.Controls.Add(this.coChBx);
            this.Controls.Add(this.scChBx);
            this.Controls.Add(this.datepickerTo);
            this.Controls.Add(this.datepickerFr);
            this.Controls.Add(this.gridreport);
            this.Controls.Add(this.btnGR);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryInOutManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGR;
        private System.Windows.Forms.DataGridView gridreport;
        private LibraryInOutManagementSystemDataSet libraryInOutManagementSystemDataSet;
        private System.Windows.Forms.BindingSource inOutInfoBindingSource;
        private LibraryInOutManagementSystemDataSetTableAdapters.InOutInfoTableAdapter inOutInfoTableAdapter;
        private System.Windows.Forms.DateTimePicker datepickerFr;
        private System.Windows.Forms.DateTimePicker datepickerTo;
        private System.Windows.Forms.CheckBox scChBx;
        private System.Windows.Forms.CheckBox coChBx;
        private System.Windows.Forms.CheckBox arChBx;
        private System.Windows.Forms.CheckBox otChBx;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngetFP;

    }
}