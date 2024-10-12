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
    public partial class FrmControls : Form
    {
        public FrmControls()
        {
            InitializeComponent();

            //txtOne.Size = new Size(300, 300);
            //txtOne.Multiline = true;
            //txtOne.WordWrap = false;
            //txtOne.ScrollBars = ScrollBars.Horizontal;

            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Indeterminate;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (object item in pnlRadio.Controls)
            {
                if (item is RadioButton rb)
                    if (rb.Checked)
                        MessageBox.Show(rb.Tag.ToString());
            }
        }
    }
}
