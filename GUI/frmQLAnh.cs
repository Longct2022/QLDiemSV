using QLDiemSV.BUS;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV.GUI
{
    public partial class frmQLAnh : Form
    {
        List<Anh> la;
        QLAnhBUS bus = new QLAnhBUS();
        public frmQLAnh()
        {
            InitializeComponent();
        }

        private void QLAnh_Load(object sender, EventArgs e)
        {
            la = bus.LayDSAnh();
            dgvTTUser.DataSource = la;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvTTUser.CurrentRow.Cells["UserID"].Value.ToString();
            byte i = (byte)dgvTTUser.CurrentRow.Cells["Picture"].Value;

            MemoryStream ms = new MemoryStream(i);
            pbAnh.Image = Image.FromStream(ms);
        }
    }
}
