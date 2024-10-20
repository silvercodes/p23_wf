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
    public partial class FrmTrack : Form
    {
        public FrmTrack()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += (s, e) => 
            {
                progressBar1.PerformStep();
            };

            timer.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Text = $"Current val = {trackBar1.Value}";
        }
    }
}
