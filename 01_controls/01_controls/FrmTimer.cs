using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_controls
{
    public partial class FrmTimer : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private int val = 0;
        
        public FrmTimer()
        {
            InitializeComponent();

            timer.Interval = 1000;

            timer.Tick += (s, e) => {
                label1.Text = (++val).ToString();
            };

            timer.Start();
        }

        
    }
}
