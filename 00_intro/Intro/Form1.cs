namespace Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button()
            {
                Text = "BEST BUTTON",
                Size = new Size(300, 300),
                Location = new Point(200, 200),
            };

            btn.Click += Btn_Click;

            this.Controls.Add(btn);

         
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            //while (true)
            //{

            //}

            MessageBox.Show("Hello from nandler");
        }
    }
}
