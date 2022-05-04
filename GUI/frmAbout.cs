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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value >= 15)
            {
                timer1.Stop();
                this.frmAbout_Leave(sender, e);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
