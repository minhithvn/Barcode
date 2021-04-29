namespace volexbarcode
{
    partial class frmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_report = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // dtp_report
            // 
            this.dtp_report.CustomFormat = "dd/MM/yyyy";
            this.dtp_report.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_report.Location = new System.Drawing.Point(102, 22);
            this.dtp_report.Name = "dtp_report";
            this.dtp_report.Size = new System.Drawing.Size(303, 26);
            this.dtp_report.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ca làm việc";
            // 
            // cmb_shift
            // 
            this.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cmb_shift.Location = new System.Drawing.Point(589, 21);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(298, 28);
            this.cmb_shift.TabIndex = 3;
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line,
            this.part,
            this.status,
            this.count});
            this.dgv_report.Location = new System.Drawing.Point(13, 85);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersWidth = 62;
            this.dgv_report.RowTemplate.Height = 28;
            this.dgv_report.Size = new System.Drawing.Size(1079, 520);
            this.dgv_report.TabIndex = 4;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(960, 16);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(133, 39);
            this.btn_view.TabIndex = 5;
            this.btn_view.Text = "Xem";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // line
            // 
            this.line.DataPropertyName = "line";
            this.line.HeaderText = "line";
            this.line.MinimumWidth = 8;
            this.line.Name = "line";
            this.line.ReadOnly = true;
            this.line.Width = 150;
            // 
            // part
            // 
            this.part.DataPropertyName = "part";
            this.part.HeaderText = "Part Number";
            this.part.MinimumWidth = 8;
            this.part.Name = "part";
            this.part.ReadOnly = true;
            this.part.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Q\'ty";
            this.count.MinimumWidth = 8;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 150;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 617);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.cmb_shift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_report);
            this.Controls.Add(this.label1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn part;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
}