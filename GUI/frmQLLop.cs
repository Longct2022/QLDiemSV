using QLDiemSV.BUS;
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
    public partial class frmQLLop : Form
    {
        QLLopBUS bus = new QLLopBUS();
        QLKhoaBUS khoaBUS = new QLKhoaBUS();
        List<Lop> llop;
        int flag;
        public frmQLLop()
        {
            InitializeComponent();
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            llop = bus.LayDSLop();
            dgv.DataSource = llop;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboKhoa.DataSource = khoaBUS.LayDSKhoa();
            cboKhoa.DisplayMember = "MaKhoa";
            cboLoc.Enabled = false;
            cbLoc.Checked = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dgv.CurrentRow.Cells["MaLop"].Value.ToString();
            cboKhoa.Text = dgv.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenLop.Text = dgv.CurrentRow.Cells["TenLop"].Value.ToString();
            txtSiso.Text = dgv.CurrentRow.Cells["SiSo"].Value.ToString();
        }

        private void cbLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
            {
                cboLoc.DataSource = cboKhoa.DataSource;
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
            if (cbLoc.Checked)
                dgv.DataSource = bus.LayDSLop(cboLoc.Text);
            else
                dgv.DataSource = bus.LayDSLop();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Lop lop = llop.Find(i => i.MaLop == txtMaLop.Text);
            if (txtMaLop == null)
            {
                MessageBox.Show("Mã Lớp không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
            }
            else if (lop == null)
            {
                MessageBox.Show("Mã Lớp không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
            }
            else if (lop.SiSo != 0)
            {
                MessageBox.Show("Không xóa được lớp có sinh viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
            }    
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa lớp " + txtMaLop.Text.ToString() + " không Y/N", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int currentRow = llop.FindIndex(i => i.MaLop == txtMaLop.Text);
                    if (currentRow == 0) currentRow = 1;
                    bus.XoaLop(txtMaLop.Text);
                    Lop dellop = llop.Find(i => i.MaLop == txtMaLop.Text);
                    llop.Remove(dellop);
                    MessageBox.Show("Đã xóa Lớp " + txtMaLop.Text);
                    dgv.DataSource = null;
                    dgv.DataSource = llop;
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
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaLop.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.frmQLLop_Load(sender, e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã Lớp không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                txtMaLop.Focus();
            }
            else if (cboKhoa.Text == "")
            {
                MessageBox.Show("Mã Khoa không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                cboKhoa.Focus();
            }
            else
            {
                if (flag == 0)      // Trường hợp thêm SV mới
                {
                    Lop u = llop.Find(s => s.MaLop == txtMaLop.Text);
                    if (u != null)
                    {
                        MessageBox.Show("Mã Lớp đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                    }
                    else
                    {
                        Lop lop = new Lop
                        {
                            MaLop = txtMaLop.Text,
                            TenLop = txtTenLop.Text,
                            MaKhoa = cboKhoa.Text,
                            SiSo = int.Parse(txtSiso.Text)
                        };

                        bus.ThemLop(lop);
                        llop.Add(lop);
                        MessageBox.Show("Đã thêm Lớp có mã " + lop.MaLop);
                        dgv.DataSource = null;
                        dgv.DataSource = llop;
                        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
                    }
                }
                else if (flag == 1)
                {
                    Lop lop = new Lop
                    {
                        MaLop = txtMaLop.Text,
                        TenLop = txtTenLop.Text,
                        MaKhoa = cboKhoa.Text,
                        SiSo = int.Parse(txtSiso.Text)
                };


                    bus.SuaLop(lop);
                    lop = llop.Find(us => us.MaLop == lop.MaLop);
                    lop.MaLop = txtMaLop.Text;
                    lop.TenLop = txtTenLop.Text;
                    lop.MaKhoa = cboKhoa.Text;
                    lop.SiSo = int.Parse(txtSiso.Text);
                    MessageBox.Show("Đã sửa Lớp '" + lop.MaLop + "'");
                    dgv.DataSource = null;
                    dgv.DataSource = llop;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgv.CurrentCell = dgv.Rows[llop.FindIndex(us => us.MaLop == lop.MaLop)].Cells[0];
                }
            }
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiso.Clear();
            cboKhoa.ResetText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }


    }
    
}
