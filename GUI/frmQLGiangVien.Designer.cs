namespace QLDiemSV.GUI
{
    partial class frmQLGiangVien
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
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPLGiangVien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoc
            // 
            this.cbLoc.AutoSize = true;
            this.cbLoc.Location = new System.Drawing.Point(33, 208);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(157, 24);
            this.cbLoc.TabIndex = 82;
            this.cbLoc.Text = "Lọc GV theo khoa";
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
            this.groupBox1.Location = new System.Drawing.Point(0, 554);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.groupBox1.Size = new System.Drawing.Size(885, 94);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(732, 15);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 63);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMoi.Location = new System.Drawing.Point(58, 15);
            this.btnMoi.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(112, 63);
            this.btnMoi.TabIndex = 26;
            this.btnMoi.Text = "Thêm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(552, 17);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 63);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(212, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 63);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(380, 17);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 63);
            this.btnXoa.TabIndex = 24;
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
            this.cboLoc.Location = new System.Drawing.Point(206, 203);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(88, 28);
            this.cboLoc.TabIndex = 78;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaKhoa.Location = new System.Drawing.Point(696, 203);
            this.cboMaKhoa.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(166, 28);
            this.cboMaKhoa.TabIndex = 79;
            this.cboMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaKhoa_SelectedIndexChanged);
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(132, 145);
            this.cboSex.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(139, 28);
            this.cboSex.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(885, 59);
            this.label4.TabIndex = 77;
            this.label4.Text = "QUẢN LÝ THÔNG TIN GIẢNG VIÊN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(696, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 26);
            this.txtEmail.TabIndex = 73;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(408, 88);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(154, 26);
            this.txtTenGV.TabIndex = 74;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(408, 148);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 26);
            this.txtPhone.TabIndex = 75;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(132, 89);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(139, 26);
            this.txtMaGV.TabIndex = 76;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Location = new System.Drawing.Point(597, 89);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(48, 20);
            this.txtGhiChu.TabIndex = 68;
            this.txtGhiChu.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tên GV";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(30, 151);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(67, 20);
            this.lblMaLop.TabIndex = 71;
            this.lblMaLop.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã GV";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-20, 266);
            this.dgv.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(902, 289);
            this.dgv.TabIndex = 67;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Phân loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Mã khoa";
            // 
            // cboPLGiangVien
            // 
            this.cboPLGiangVien.FormattingEnabled = true;
            this.cboPLGiangVien.Items.AddRange(new object[] {
            "Cơ hữu",
            "Thỉnh giảng"});
            this.cboPLGiangVien.Location = new System.Drawing.Point(696, 145);
            this.cboPLGiangVien.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.cboPLGiangVien.Name = "cboPLGiangVien";
            this.cboPLGiangVien.Size = new System.Drawing.Size(139, 28);
            this.cboPLGiangVien.TabIndex = 80;
            // 
            // frmQLGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 648);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.cboMaKhoa);
            this.Controls.Add(this.cboPLGiangVien);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQLGiangVien";
            this.Text = "frmQLGiangVien";
            this.Load += new System.EventHandler(this.frmQLGiangVien_Load);
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
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label txtGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPLGiangVien;
    }
}