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
    public partial class FrmPicBox : Form
    {
        public FrmPicBox()
        {
            InitializeComponent();

            pic1.SizeMode = PictureBoxSizeMode.Normal;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.SizeMode = PictureBoxSizeMode.CenterImage;
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic5.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
