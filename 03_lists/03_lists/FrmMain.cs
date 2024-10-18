namespace _03_lists
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void btnListBox_Click(object sender, EventArgs e)
        {
            FrmListBox frm = new FrmListBox();
            frm.ShowDialog();
        }

        public void btnCombobox_Click(object sender, EventArgs e)
        {
            FrmCombobox frm = new FrmCombobox();
            frm.ShowDialog();
        }

        public void btnBinding_Click(object sender, EventArgs e)
        {
            FrmBinding frm = new FrmBinding();
            frm.ShowDialog();
        }
    }
}
