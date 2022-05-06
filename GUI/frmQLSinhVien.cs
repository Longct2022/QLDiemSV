using QLDiemSV.BUS;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLDiemSV.GUI
{
    public partial class frmQLSinhVien : Form
    {
        readonly QLSinhVienBUS bus = new QLSinhVienBUS(Program.strcon);

        List<SinhVien> lsv = new List<SinhVien>();
        int flag;
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void frmQLSinhVien_Load(object sender, EventArgs e)
        {
            lsv = bus.LayDSSinhVien();
            dgv.DataSource = lsv;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboMaLop.DataSource = bus.LayDSLop();
            cboMaLop.DisplayMember = "MaLop";
            cboLoc.Enabled = false;
            cbLoc.Checked = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgv.CurrentRow.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = dgv.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dgv.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboMaLop.Text = dgv.CurrentRow.Cells["MaLop"].Value.ToString();
            txtNgaySinh.Text = dgv.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cboSex.Text = dgv.CurrentRow.Cells["GioiTinh"].Value.ToString();

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            //txtUserID.Clear();
            //txtFullName .Clear();
            //txtPassword .Clear();
            //txtPhoneNumber .Clear();
            //txtEmail.Clear();
            //cboRole.ResetText();
            //cboSex.ResetText();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaSV.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = lsv.Find(u => u.MaSV == txtMaSV.Text);
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
            }
            else if (sv == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
            }    
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản " + txtMaSV.Text.ToString() + " không Y/N", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int currentRow = lsv.FindIndex(s => s.MaSV == txtMaSV.Text);
                    if (currentRow == 0) currentRow = 1;
                    bus.XoaSV(txtMaSV.Text);
                    SinhVien delUser = lsv.Find(s => s.MaSV == txtMaSV.Text);
                    lsv.Remove(delUser);
                    MessageBox.Show("Đã xóa tài khoản " + txtMaSV.Text);
                    dgv.DataSource = null;
                    dgv.DataSource = lsv;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgv.CurrentCell = dgv.Rows[currentRow - 1].Cells[0];

                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    btnMoi.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void cbLocSV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
            {
                cboLoc.DataSource = cboMaLop.DataSource;
                cboLoc.DisplayMember = "MaLop";
                cboLoc.SelectedIndex = 0;
                cboLoc.Enabled = cbLoc.Checked;
            }
            else
            {
                cboLoc.Enabled = false;
                cboLoc.SelectedIndex = -1;
            }                
        }

        private void cboLocMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
                dgv.DataSource = bus.LayDSSinhVien(cboLoc.Text);
            else
                dgv.DataSource = bus.LayDSSinhVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.frmQLSinhVien_Load(sender, e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Mã Sinh Viên không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            else if (cboMaLop.Text == "")
            {
                MessageBox.Show("Mã Lớp không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                cboMaLop.Focus();
            }
            else
            {
                if (flag == 0)      // Trường hợp thêm SV mới
                {
                    SinhVien u = lsv.Find(s => s.MaSV == txtMaSV.Text);
                    if (u != null)
                    {
                        MessageBox.Show("UserID đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtMaSV.Focus();
                    }
                    else
                    {
                        SinhVien nsv = new SinhVien
                        {
                            MaSV = txtMaSV.Text,
                            MaLop = cboMaLop.Text,
                            DiaChi = txtDiaChi.Text,
                            GioiTinh = cboSex.Text,
                            HoTen = txtHoTen.Text,
                            NgaySinh = txtNgaySinh.Text
                        };

                        bus.ThemSV(nsv);
                        lsv.Add(nsv);
                        MessageBox.Show("Đã thêm sinh viên có mã " + nsv.MaSV);
                        dgv.DataSource = null;
                        dgv.DataSource = lsv;
                        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
                    }
                }
                else if (flag == 1) // Trường hợp sửa thông tin SV
                {
                    SinhVien esv = new SinhVien
                    {
                        MaSV = txtMaSV.Text,
                        MaLop = cboMaLop.Text,
                        HoTen = txtHoTen.Text,
                        GioiTinh = cboSex.Text,
                        DiaChi = txtDiaChi.Text,
                        NgaySinh = txtNgaySinh.Text
                    };


                    bus.SuaSV(esv);
                    SinhVien sv = lsv.Find(us => us.MaSV == esv.MaSV);
                    sv.MaSV = txtMaSV.Text;
                    sv.MaLop = cboMaLop.Text;
                    sv.HoTen = txtHoTen.Text;
                    sv.GioiTinh = cboSex.SelectedItem.ToString();
                    sv.DiaChi = txtDiaChi.Text;
                    sv.NgaySinh = txtNgaySinh.Text;
                    MessageBox.Show("Đã sửa tài khoản '" + esv.MaSV + "'");
                    dgv.DataSource = null;
                    dgv.DataSource = lsv;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgv.CurrentCell = dgv.Rows[lsv.FindIndex(us => us.MaSV == esv.MaSV)].Cells[0];
                }
            }
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            cboSex.ResetText();
            txtDiaChi.Clear();
            cboMaLop.ResetText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
    }
}
