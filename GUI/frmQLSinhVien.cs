using QLDiemSV.BUS;
using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV.GUI
{
    public partial class frmQLSinhVien : Form
    {
        QLSinhVienBUS bus = new QLSinhVienBUS(Program.strcon);

        List<SinhVien> lsv = new List<SinhVien>();
        int flag;
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = lsv.Find(u => u.MaSV == txtMaSV.Text);
            if (sv == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dgvTTSV.DataSource = null;
                    dgvTTSV.DataSource = lsv;
                    dgvTTSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgvTTSV.CurrentCell = dgvTTSV.Rows[currentRow - 1].Cells[0];

                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    btnMoi.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }                
            }
        }

        private void frmQLSinhVien_Load(object sender, EventArgs e)
        {
            lsv = bus.LayDSSinhVien();
            dgvTTSV.DataSource = lsv;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboMaLop.DataSource = bus.LayDSLop();
            cboMaLop.DisplayMember = "MaLop";
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

        private void dgvTTSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgvTTSV.CurrentRow.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = dgvTTSV.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dgvTTSV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboMaLop.Text = dgvTTSV.CurrentRow.Cells["MaLop"].Value.ToString();
            txtNgaySinh.Text = dgvTTSV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cboSex.Text = dgvTTSV.CurrentRow.Cells["GioiTinh"].Value.ToString();

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
                if (flag == 0)
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
                        dgvTTSV.DataSource = null;
                        dgvTTSV.DataSource = lsv;
                        dgvTTSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgvTTSV.CurrentCell = dgvTTSV.Rows[dgvTTSV.Rows.Count - 1].Cells[0];
                    }
                }
                else if (flag == 1)
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
                    dgvTTSV.DataSource = null;
                    dgvTTSV.DataSource = lsv;
                    dgvTTSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgvTTSV.CurrentCell = dgvTTSV.Rows[lsv.FindIndex(us => us.MaSV == esv.MaSV)].Cells[0];
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaSV.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }


    }
}
