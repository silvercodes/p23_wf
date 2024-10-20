using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_controls_3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPicBox_Click(object sender, EventArgs e)
        {
            Form frm = new FrmPicBox();
            frm.ShowDialog();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTrack();
            frm.ShowDialog();
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            Form frm = new FrmScroll();
            frm.ShowDialog();
        }
    }
}
