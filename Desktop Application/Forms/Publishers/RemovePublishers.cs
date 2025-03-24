using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Publishers;

public partial class RemovePublishers : Form
{
    private readonly DataGridView _publishers_grd;

    public RemovePublishers(DataGridView publishers_grd)
    {
        _publishers_grd = publishers_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, no);
        HandleKeys.Handle(this, Keys.Enter, Remove);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Remove(object sender, EventArgs e)
    {
        HandleQueries.Delete(_publishers_grd, "Publishers", "publishers_publisher", "Publisher");
        MessageBox.Show("Publisher(s) removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}