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
    public partial class frmDoiTTNgDung : Form
    {
        CapNhatTKBUS ndbus = new CapNhatTKBUS(Program.strcon);
        List<Users> lus;
        int flag;
        public frmDoiTTNgDung()
        {
            InitializeComponent();
        }

        private void frmDoiTTNgDung_Load(object sender, EventArgs e)
        {
            flag = 0;   

            gbPasswordChange.Visible = false;
            gbUserInfor.Visible = true;
            btnCancel.Enabled = false;
            btnPasswordChange.Enabled = true;
            btnSave.Enabled = false;
            btnInforChange.Enabled = true;

            lus = ndbus.LayDSUser();
            txtUser.Enabled = false;
            txtFullName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtRole.Enabled = false;
            txtEmail.Enabled = false;
            cboSex.Enabled = false;


            txtUser.Text = Program.user.UserID;
            txtFullName.Text = Program.user.FullName;
            cboSex.Text = Program.user.Sex;
            txtPhoneNumber.Text = Program.user.PhoneNumber;
            txtEmail.Text = Program.user.Email;
            txtRole.Text = Program.user.Role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                Program.user.FullName = txtFullName.Text;
                Program.user.Sex = cboSex.Text;
                Program.user.PhoneNumber = txtPhoneNumber.Text;
                Program.user.Email = txtEmail.Text;
                ndbus.SuaUser(Program.user);

                MessageBox.Show("Đã cập nhật thông tin !", "Thông báo", MessageBoxButtons.OK);
            }    
         
            else if (flag == 1)
            {
                if (txtCurrentPassword.Text != Program.user.Password)
                {
                    MessageBox.Show("Mật khẩu hiện tại chưa đúng !", "Thông báo", MessageBoxButtons.OK);
                    this.btnPasswordChange_Click(sender, e);
                    txtCurrentPassword.Focus();
                }
                else if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Mật khẩu mới không được để trống !", "Thông báo", MessageBoxButtons.OK);
                    this.btnPasswordChange_Click(sender, e);
                    txtNewPassword.Focus();
                }
                else if (txtNewPassword.Text != txtNPassowrdConfirm.Text)
                {
                    MessageBox.Show("Nhắc lại mật khẩu không trùng !", "Thông báo", MessageBoxButtons.OK);
                    this.btnPasswordChange_Click(sender, e);
                    txtNPassowrdConfirm.Focus();
                }
                else
                {
                    Program.user.Password = txtNewPassword.Text;
                    ndbus.SuaUser(Program.user);
                    MessageBox.Show("Đã cập nhật mật khẩu. Mời đăng nhập lại !", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                    frmLogin f = new frmLogin();
                    f.Show();
                }
            }
            this.frmDoiTTNgDung_Load(sender, e);


        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            flag = 1;
            gbUserInfor.Visible = false;
            gbPasswordChange.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnInforChange.Enabled = false;
        }

        private void btnInforChange_Click(object sender, EventArgs e)
        {
            gbUserInfor.Visible = true;
            btnPasswordChange.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            gbPasswordChange.Visible = false;

            txtUser.Enabled = false;
            txtFullName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtRole.Enabled = false;
            txtEmail.Enabled = true;
            cboSex.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmDoiTTNgDung_Load(sender, e);
            //this.Close();
            //frmDoiTTNgDung f = new frmDoiTTNgDung();
            //f.Show();
        }
    }
}
