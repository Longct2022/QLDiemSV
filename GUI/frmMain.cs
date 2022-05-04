using System;
using System.Windows.Forms;

namespace QLDiemSV.GUI
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Window " + childFormNumber++
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _ = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _ = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void qLSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            Hide();
        }

        private void mnuCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDoiTTNgDung f = new frmDoiTTNgDung
            {
                MdiParent = this
            };
            f.Show();
        }

        private void mnuQLNguoiDung_Click(object sender, EventArgs e)
        {
            frmQLNguoiDung f = new frmQLNguoiDung();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.user.Role == "Admin")
            {
                mnuQLNguoiDung.Enabled = true;
                mnuQLLop.Enabled = true;
                mnuQLGV.Enabled = true;
            }
            else if (Program.user.Role == "Member")
            {
                mnuQLNguoiDung.Enabled = false;
                mnuQLLop.Enabled = false;
                mnuQLGV.Enabled = false;
            }
            else
            {
                mnuQLNguoiDung.Enabled = false;
                mnuQLLop.Enabled = false;
                mnuQLGV.Enabled = false;
            }
        }

        private void mnuQLSV_Click(object sender, EventArgs e)
        {
            frmQLSinhVien f = new frmQLSinhVien();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuQLLop_Click(object sender, EventArgs e)
        {
            frmQLLop f = new frmQLLop();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.Show();
        }
    }
}
