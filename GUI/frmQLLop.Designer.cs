namespace QLDiemSV.GUI
{
    partial class frmQLLop
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
            this.cbLoc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiso = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoc
            // 
            this.cbLoc.AutoSize = true;
            this.cbLoc.Location = new System.Drawing.Point(459, 117);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(190, 29);
            this.cbLoc.TabIndex = 5;
            this.cbLoc.Text = "Lọc SV theo khoa";
            this.cbLoc.UseVisualStyleBackColor = true;
            this.cbLoc.CheckedChanged += new System.EventHandler(this.cbLoc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnMoi);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 463);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.groupBox1.Size = new System.Drawing.Size(804, 75);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(684, 12);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMoi.Location = new System.Drawing.Point(85, 12);
            this.btnMoi.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(100, 50);
            this.btnMoi.TabIndex = 7;
            this.btnMoi.Text = "Thêm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(524, 13);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(221, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(370, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboLoc
            // 
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboLoc.Location = new System.Drawing.Point(689, 113);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(78, 33);
            this.cboLoc.TabIndex = 6;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboKhoa.Location = new System.Drawing.Point(375, 69);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(124, 33);
            this.cboKhoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(804, 48);
            this.label4.TabIndex = 93;
            this.label4.Text = "QUẢN LÝ THÔNG TIN LỚP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(619, 70);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(148, 30);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Location = new System.Drawing.Point(531, 72);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(85, 25);
            this.txtGhiChu.TabIndex = 84;
            this.txtGhiChu.Text = "Tên Lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(283, 74);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(59, 25);
            this.lblMaLop.TabIndex = 87;
            this.lblMaLop.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mã Lớp";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 161);
            this.dgv.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(804, 295);
            this.dgv.TabIndex = 83;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(118, 72);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(124, 30);
            this.txtMaLop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "Sĩ số";
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(118, 115);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.Size = new System.Drawing.Size(124, 30);
            this.txtSiso.TabIndex = 4;
            // 
            // frmQLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(804, 538);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtSiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtMaLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLLop";
            this.Text = "Quản lý thông tin lớp";
            this.Load += new System.EventHandler(this.frmQLLop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label txtGhiChu;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiso;
    }
}