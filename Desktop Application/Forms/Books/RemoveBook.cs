using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class RemoveBook : Form
{
    private readonly DataGridView _books_grd;

    public RemoveBook(DataGridView books_grd)
    {
        _books_grd = books_grd;
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
        HandleQueries.Delete(_books_grd, "Books", "ISBN", "ISBN");
        MessageBox.Show("Book removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}