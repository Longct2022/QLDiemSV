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
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            lsv = bus.LayDSSinhVien();
            dgvTTSV.DataSource = lsv;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            cboMaLop.DataSource = bus.LayDSLop();
            cboMaLop.DisplayMember = "MaLop";
        }

        int flag;
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
                MessageBox.Show("Mã sinh viên không được để trống !", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }    
            else if (cboMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không được để trống !", "Thông báo", MessageBoxButtons.OK);
                cboMaLop.Focus();
            }
            else
            {
                if (flag == 0)
                {
                    SinhVien sv = new SinhVien
                    {
                        MaSV = txtMaSV.Text,
                        HoTen = txtHoTen.Text,
                        NgaySinh = txtNgaySinh.Text,
                        GioiTinh = cboSex.Text,
                        DiaChi = txtDiaChi.Text,
                        MaLop = cboMaLop.Text
                    };
                    bus.ThemSV(sv);
                    lsv.Add(sv);
                    dgvTTSV.DataSource = null;
                    dgvTTSV.DataSource = lsv;
                }    
            }
        }
    }
}
