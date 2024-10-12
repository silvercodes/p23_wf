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
    public partial class FrmEvents : Form
    {
        public FrmEvents()
        {
            InitializeComponent();
        }

        private void FrmEvents_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Form loaded...");

            Button btn = new Button()
            {
                Text = "My button",
                BackColor = Color.Red,
                Location = new Point(300, 0),
                Size = new Size(400, 100),
            };

            btn.Click += (sender, e) => MessageBox.Show("My button handler");

            Label lblText = new Label()
            {
                Location = new Point(300, 200),
                Text = "Label caption",
                Size = new Size(400, 100),
            };

            Label lblImage = new Label()
            {
                Location = new Point(300, 300),
                Size = new Size(400, 400),
                Image = Image.FromFile("cs.png"),
            };

            Controls.Add(btn);
            Controls.Add(lblText);
            Controls.Add(lblImage);

        }
    }
}
