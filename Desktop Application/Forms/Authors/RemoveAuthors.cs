using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Authors;

public partial class RemoveAuthors : Form
{
    private readonly DataGridView _authors_grd;

    public RemoveAuthors(DataGridView authors_grd)
    {
        _authors_grd = authors_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, no);
    }

    private void Yes(object sender, EventArgs e)
    {
        HandleQueries.Delete(_authors_grd, "Authors", "authors_author", "Author");
        MessageBox.Show("Authors removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}