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
    public partial class FrmScroll : Form
    {
        int x;
        int y;
        public FrmScroll()
        {
            InitializeComponent();

            VScrollBar vscroll = new VScrollBar()
            {
                Width = 30,
                Height = pictureBox1.Height,
                Dock = DockStyle.Right,
                Maximum = pictureBox1.Image.Height - pictureBox1.Height
            };

            HScrollBar hscroll = new HScrollBar()
            {
                Height = 30,
                Width = pictureBox1.Width,
                Dock = DockStyle.Bottom,
                Maximum = pictureBox1.Image.Width - pictureBox1.Width
            };

            pictureBox1.Controls.Add(vscroll);
            pictureBox1.Controls.Add(hscroll);

            vscroll.Scroll += Vscroll_Scroll;
            hscroll.Scroll += Hscroll_Scroll;
        }

        private void Vscroll_Scroll(object? sender, ScrollEventArgs e)
        {
            y = (sender as VScrollBar).Value;
            pictureBox1.Refresh();
        }

        private void Hscroll_Scroll(object? sender, ScrollEventArgs e)
        {
            x = (sender as HScrollBar).Value;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                pictureBox1.Image,
                e.ClipRectangle,
                x,
                y,
                e.ClipRectangle.Width,
                e.ClipRectangle.Height,
                GraphicsUnit.Pixel
            );
        }
    }
}
