using System.Drawing.Drawing2D;

namespace _02_controls2
{
    public partial class Form1 : Form
    {
        private Point lastPosiition;
        private bool isMouseDown;
        public Form1()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnClose.Width - 5, btnClose.Height - 5);
            Region region = new Region(path);

            btnClose.Region = region;

            // btnClose.Region
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastPosiition = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Location = new Point
                    (
                        Location.X - lastPosiition.X + e.X,
                        Location.Y - lastPosiition.Y + e.Y
                    );
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
