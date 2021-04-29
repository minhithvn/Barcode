namespace volexbarcode
{
    partial class frmScanFuji
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
            this.btn_start = new System.Windows.Forms.Button();
            this.comb_line = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_NG = new System.Windows.Forms.DataGridView();
            this.lab_erorr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_NG = new System.Windows.Forms.Label();
            this.lab_OK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comb_part = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NG)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(144, 63);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(714, 51);
            this.btn_start.TabIndex = 34;
            this.btn_start.Text = "SCAN";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // comb_line
            // 
            this.comb_line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_line.FormattingEnabled = true;
            this.comb_line.Items.AddRange(new object[] {
            "-----Select------"});
            this.comb_line.Location = new System.Drawing.Point(144, 20);
            this.comb_line.Name = "comb_line";
            this.comb_line.Size = new System.Drawing.Size(250, 28);
            this.comb_line.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dây chuyền";
            // 
            // dgv_NG
            // 
            this.dgv_NG.AllowUserToAddRows = false;
            this.dgv_NG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_NG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.partnumber,
            this.scanbarcode,
            this.status,
            this.error});
            this.dgv_NG.Location = new System.Drawing.Point(24, 323);
            this.dgv_NG.Name = "dgv_NG";
            this.dgv_NG.ReadOnly = true;
            this.dgv_NG.RowHeadersWidth = 62;
            this.dgv_NG.RowTemplate.Height = 28;
            this.dgv_NG.Size = new System.Drawing.Size(834, 332);
            this.dgv_NG.TabIndex = 32;
            // 
            // lab_erorr
            // 
            this.lab_erorr.AutoSize = true;
            this.lab_erorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_erorr.ForeColor = System.Drawing.Color.Red;
            this.lab_erorr.Location = new System.Drawing.Point(33, 231);
            this.lab_erorr.Name = "lab_erorr";
            this.lab_erorr.Size = new System.Drawing.Size(201, 32);
            this.lab_erorr.TabIndex = 31;
            this.lab_erorr.Text = "Thông báo lỗi";
            this.lab_erorr.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "NG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "OK";
            // 
            // lab_NG
            // 
            this.lab_NG.AutoSize = true;
            this.lab_NG.Location = new System.Drawing.Point(514, 282);
            this.lab_NG.Name = "lab_NG";
            this.lab_NG.Size = new System.Drawing.Size(18, 20);
            this.lab_NG.TabIndex = 28;
            this.lab_NG.Text = "0";
            // 
            // lab_OK
            // 
            this.lab_OK.AutoSize = true;
            this.lab_OK.Location = new System.Drawing.Point(177, 282);
            this.lab_OK.Name = "lab_OK";
            this.lab_OK.Size = new System.Drawing.Size(18, 20);
            this.lab_OK.TabIndex = 27;
            this.lab_OK.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Enabled = false;
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(144, 128);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(714, 39);
            this.txt_barcode.TabIndex = 23;
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã vạch";
            // 
            // btn_unlock
            // 
            this.btn_unlock.Enabled = false;
            this.btn_unlock.Location = new System.Drawing.Point(749, 181);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(110, 41);
            this.btn_unlock.TabIndex = 24;
            this.btn_unlock.Text = "Mở khóa";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Location = new System.Drawing.Point(144, 188);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(584, 26);
            this.txt_password.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comb_part
            // 
            this.comb_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_part.FormattingEnabled = true;
            this.comb_part.Location = new System.Drawing.Point(608, 20);
            this.comb_part.Name = "comb_part";
            this.comb_part.Size = new System.Drawing.Size(250, 28);
            this.comb_part.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã sản phẩm";
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 150;
            // 
            // partnumber
            // 
            this.partnumber.HeaderText = "Sản phẩm";
            this.partnumber.MinimumWidth = 8;
            this.partnumber.Name = "partnumber";
            this.partnumber.ReadOnly = true;
            this.partnumber.Width = 150;
            // 
            // scanbarcode
            // 
            this.scanbarcode.HeaderText = "Mã vạch đã quét";
            this.scanbarcode.MinimumWidth = 8;
            this.scanbarcode.Name = "scanbarcode";
            this.scanbarcode.ReadOnly = true;
            this.scanbarcode.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Kết quả";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // error
            // 
            this.error.HeaderText = "Loại lỗi";
            this.error.MinimumWidth = 8;
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Width = 150;
            // 
            // frmScanFuji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 667);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.comb_line);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_NG);
            this.Controls.Add(this.lab_erorr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_NG);
            this.Controls.Add(this.lab_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_part);
            this.Controls.Add(this.label1);
            this.Name = "frmScanFuji";
            this.Text = "Scan Fuji Barcode";
            this.Load += new System.EventHandler(this.frmScanFuji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox comb_line;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_NG;
        private System.Windows.Forms.Label lab_erorr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_NG;
        private System.Windows.Forms.Label lab_OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comb_part;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}