namespace volexbarcode
{
    partial class frmSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_line = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_result = new System.Windows.Forms.ComboBox();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stampDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scannedBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dây chuyền";
            // 
            // cmb_line
            // 
            this.cmb_line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_line.FormattingEnabled = true;
            this.cmb_line.Location = new System.Drawing.Point(132, 26);
            this.cmb_line.Name = "cmb_line";
            this.cmb_line.Size = new System.Drawing.Size(169, 28);
            this.cmb_line.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ";
            // 
            // dtp_from
            // 
            this.dtp_from.CustomFormat = "dd/MM/yyy HH:MM:ss";
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(382, 27);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(253, 26);
            this.dtp_from.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến";
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "dd/MM/yyy HH:MM:ss";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(728, 27);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(253, 26);
            this.dtp_to.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1008, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // cmb_result
            // 
            this.cmb_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_result.FormattingEnabled = true;
            this.cmb_result.Items.AddRange(new object[] {
            "Tất cả",
            "OK",
            "NG"});
            this.cmb_result.Location = new System.Drawing.Point(1099, 26);
            this.cmb_result.Name = "cmb_result";
            this.cmb_result.Size = new System.Drawing.Size(169, 28);
            this.cmb_result.TabIndex = 7;
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.AllowUserToDeleteRows = false;
            this.dgv_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_report.AutoGenerateColumns = false;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stampDateDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.scannedBarcodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgv_report.DataSource = this.transactionBindingSource;
            this.dgv_report.Location = new System.Drawing.Point(17, 83);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersWidth = 62;
            this.dgv_report.RowTemplate.Height = 28;
            this.dgv_report.Size = new System.Drawing.Size(1420, 355);
            this.dgv_report.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1295, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(138, 47);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // stampDateDataGridViewTextBoxColumn
            // 
            this.stampDateDataGridViewTextBoxColumn.DataPropertyName = "stampDate";
            this.stampDateDataGridViewTextBoxColumn.HeaderText = "stampDate";
            this.stampDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stampDateDataGridViewTextBoxColumn.Name = "stampDateDataGridViewTextBoxColumn";
            this.stampDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stampDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "line";
            this.lineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineDataGridViewTextBoxColumn.Width = 150;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "partName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "partName";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // scannedBarcodeDataGridViewTextBoxColumn
            // 
            this.scannedBarcodeDataGridViewTextBoxColumn.DataPropertyName = "scannedBarcode";
            this.scannedBarcodeDataGridViewTextBoxColumn.HeaderText = "scannedBarcode";
            this.scannedBarcodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scannedBarcodeDataGridViewTextBoxColumn.Name = "scannedBarcodeDataGridViewTextBoxColumn";
            this.scannedBarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.scannedBarcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(volexbarcode.Model.Transaction);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.cmb_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_line);
            this.Controls.Add(this.label1);
            this.Name = "frmSearch";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_result;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stampDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scannedBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionBindingSource;
    }
}