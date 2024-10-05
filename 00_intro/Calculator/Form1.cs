namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txbVal1.Text);
            int b = Convert.ToInt32(txbVal2.Text);
            int res = a + b;

            MessageBox.Show(res.ToString());
        }
    }
}
