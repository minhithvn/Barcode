namespace volexbarcode
{
    partial class frmAddFuji
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
            this.dgv_Fuji = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_part = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canonPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fujiPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fuji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canonPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fujiPartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Fuji
            // 
            this.dgv_Fuji.AllowUserToAddRows = false;
            this.dgv_Fuji.AllowUserToDeleteRows = false;
            this.dgv_Fuji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Fuji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fuji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.Regex});
            this.dgv_Fuji.Location = new System.Drawing.Point(12, 162);
            this.dgv_Fuji.Name = "dgv_Fuji";
            this.dgv_Fuji.ReadOnly = true;
            this.dgv_Fuji.RowHeadersWidth = 62;
            this.dgv_Fuji.RowTemplate.Height = 28;
            this.dgv_Fuji.Size = new System.Drawing.Size(776, 276);
            this.dgv_Fuji.TabIndex = 19;
            this.dgv_Fuji.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Fuji_CellDoubleClick);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(445, 107);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 38);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(348, 107);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 38);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(251, 107);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 38);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(154, 107);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 38);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(154, 61);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(366, 26);
            this.txt_reg.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Regex";
            // 
            // txt_part
            // 
            this.txt_part.Location = new System.Drawing.Point(154, 13);
            this.txt_part.Name = "txt_part";
            this.txt_part.Size = new System.Drawing.Size(366, 26);
            this.txt_part.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã sản phẩm";
            // 
            // stt
            // 
            this.stt.DataPropertyName = "id";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 8;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Part Number";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // Regex
            // 
            this.Regex.DataPropertyName = "reg";
            this.Regex.HeaderText = "Regex";
            this.Regex.MinimumWidth = 8;
            this.Regex.Name = "Regex";
            this.Regex.ReadOnly = true;
            this.Regex.Width = 150;
            // 
            // canonPartBindingSource
            // 
            this.canonPartBindingSource.DataSource = typeof(volexbarcode.Model.CanonPart);
            // 
            // fujiPartBindingSource
            // 
            this.fujiPartBindingSource.DataSource = typeof(volexbarcode.Model.FujiPart);
            // 
            // frmAddFuji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Fuji);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_part);
            this.Controls.Add(this.label1);
            this.Name = "frmAddFuji";
            this.Text = "Thêm sản phẩm Fuji";
            this.Load += new System.EventHandler(this.frmAddFuji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fuji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canonPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fujiPartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Fuji;
        private System.Windows.Forms.BindingSource fujiPartBindingSource;
        private System.Windows.Forms.BindingSource canonPartBindingSource;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_part;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regex;
    }
}