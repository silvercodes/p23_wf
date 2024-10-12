namespace _01_controls;

public partial class FrmMain : Form
{
    private FrmDialog frmDialog;
    public FrmMain()
    {
        InitializeComponent();

        frmDialog = new FrmDialog();
    }

    private void btnDialog_Click(object sender, EventArgs e)
    {
        // FrmDialog frm = new FrmDialog();
        // frm.ShowDialog();       // modal mode
        // frm.Show();                 // not modal mode

        // frmDialog.ShowDialog();

        FrmMain frm = new FrmMain();
        frm.ShowDialog();
    }

    private void btnEvents_Click(object sender, EventArgs e)
    {
        FrmEvents frm = new FrmEvents();
        frm.ShowDialog();
    }

    private void btnControls_Click(object sender, EventArgs e)
    {
        FrmControls frm = new FrmControls();
        frm.ShowDialog();
    }

    private void btnTimer_Click(object sender, EventArgs e)
    {
        FrmTimer frm = new FrmTimer();
        frm.ShowDialog();
    }
}
