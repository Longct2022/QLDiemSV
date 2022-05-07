using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDiemSV.BUS;
using QLDiemSV.Entities;



namespace QLDiemSV.GUI
{
    public partial class frmQLGiangVien : Form
    {
        QLGiangVienBUS bus = new QLGiangVienBUS(Program.strcon);

        List<GiangVien> lgv = new List<GiangVien>();
        int flag;
        public frmQLGiangVien()
        {
            InitializeComponent();
        }

        private void frmQLGiangVien_Load(object sender, EventArgs e)
        {
            lgv = bus.LayDSGiangVien();
            dgv.DataSource = lgv;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboMaKhoa.DataSource = bus.LayDSKhoa();
            cboMaKhoa.DisplayMember = "MaKhoa";
            cboLoc.Enabled = false;
            cbLoc.Checked = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgv.CurrentRow.Cells["MaGV"].Value.ToString();
            txtTenGV.Text = dgv.CurrentRow.Cells["TenGV"].Value.ToString();
            txtPhone.Text = dgv.CurrentRow.Cells["Phone"].Value.ToString();
            cboMaKhoa.Text = dgv.CurrentRow.Cells["MaKhoa"].Value.ToString();
            cboPLGiangVien.Text = dgv.CurrentRow.Cells["PhanLoaiGV"].Value.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
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
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaGV.Enabled = false;
            btnMoi.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = lgv.Find(u => u.MaGV == txtMaGV.Text);
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGV.Focus();
            }
            else if (gv == null)
            {
                MessageBox.Show("Mã giảng viên không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGV.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản " + txtMaGV.Text.ToString() + " không Y/N", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int currentRow = lgv.FindIndex(g => g.MaGV == txtMaGV.Text);
                    if (currentRow == 0) currentRow = 1;
                    bus.XoaGV(txtMaGV.Text);
                    GiangVien delGV = lgv.Find(g => g.MaGV == txtMaGV.Text);
                    lgv.Remove(delGV);
                    MessageBox.Show("Đã xóa tài khoản " + txtMaGV.Text);
                    dgv.DataSource = null;
                    dgv.DataSource = lgv;
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

        private void cbLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
            {
                cboLoc.DataSource = cboMaKhoa.DataSource;
                cboLoc.DisplayMember = "MaKhoa";
                cboLoc.SelectedIndex = 0;
                cboLoc.Enabled = cbLoc.Checked;
            }
            else
            {
                cboLoc.Enabled = false;
                cboLoc.SelectedIndex = -1;
            }
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lgv = bus.LayDSGiangVienAll(cboMaKhoa.Text);
            dgv.DataSource = lgv;
            if (cbLoc.Checked)
                dgv.DataSource = bus.LayDSGiangVienAll(cboLoc.Text);
            else
                dgv.DataSource = bus.LayDSGiangVien();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã Giang Viên không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                txtMaGV.Focus();
            }
            else if (cboMaKhoa.Text == "")
            {
                MessageBox.Show("Mã Khoa không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                cboMaKhoa.Focus();
            }
            else
            {
                if (flag == 0)      // Trường hợp thêm SV mới
                {
                    GiangVien u = lgv.Find(g => g.MaGV == txtMaGV.Text);
                    if (u != null)
                    {
                        MessageBox.Show("MaGV đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtMaGV.Focus();
                    }
                    else
                    {
                        GiangVien ngv = new GiangVien
                        {
                            MaGV = txtMaGV.Text,
                            MaKhoa = cboMaKhoa.Text,
                            Phone = txtPhone.Text,
                            GioiTinh = cboSex.Text,
                            TenGV = txtTenGV.Text,
                            PhanloaiGV = cboPLGiangVien.Text,
                            Email = txtEmail.Text
                        };

                        bus.ThemGV(ngv);
                        lgv.Add(ngv);
                        MessageBox.Show("Đã thêm giảng viên có mã " + ngv.MaGV);
                        dgv.DataSource = null;
                        dgv.DataSource = lgv;
                        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
                    }
                }
                else if (flag == 1)
                {
                    GiangVien egv = new GiangVien
                    {
                        MaGV = txtMaGV.Text,
                        MaKhoa = cboMaKhoa.Text,
                        Phone = txtPhone.Text,
                        GioiTinh = cboSex.Text,
                        TenGV = txtTenGV.Text,
                        PhanloaiGV = cboPLGiangVien.Text,
                        Email = txtEmail.Text
                    };

                    try
                    {
                        bus.SuaGV(egv);
                        GiangVien gv = lgv.Find(us => us.MaGV == egv.MaGV);
                        gv.MaGV = txtMaGV.Text;
                        gv.MaKhoa = cboMaKhoa.Text;
                        gv.TenGV = txtTenGV.Text;
                        gv.GioiTinh = cboSex.SelectedItem.ToString();
                        gv.PhanloaiGV = cboPLGiangVien.Text;
                        gv.Phone = txtPhone.Text;
                        gv.Email = txtEmail.Text;
                        MessageBox.Show("Đã sửa tài khoản '" + egv.MaGV + "'");
                        dgv.DataSource = null;
                        dgv.DataSource = lgv;
                        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgv.CurrentCell = dgv.Rows[lgv.FindIndex(u => u.MaGV == egv.MaGV)].Cells[0];
                    }
                    catch { }
                }
            }
            txtMaGV.Clear();
            txtTenGV.Clear();
            txtPhone.Clear();
            cboSex.ResetText();
            txtEmail.Clear();
            cboMaKhoa.ResetText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgv.CurrentRow.Cells["MaGV"].Value.ToString();
            txtTenGV.Text = dgv.CurrentRow.Cells["TenGV"].Value.ToString();
            cboPLGiangVien.Text = dgv.CurrentRow.Cells["PhanLoaiGV"].Value.ToString();
            txtPhone.Text = dgv.CurrentRow.Cells["Phone"].Value.ToString();
            cboMaKhoa.Text = dgv.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
            cboSex.Text = dgv.CurrentRow.Cells["GioiTinh"].Value.ToString();

        }


    }
}
