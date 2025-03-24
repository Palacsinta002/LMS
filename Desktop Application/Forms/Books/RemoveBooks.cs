using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class RemoveBooks : Form
{
    private readonly DataGridView _books_grd;

    public RemoveBooks(DataGridView books_grd)
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
        HandleKeys.Handle(this, Keys.Enter, Remove);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Remove(object sender, EventArgs e)
    {
        HandleQueries.Delete(_books_grd, "Books", "books_isbn", "ISBN");
        MessageBox.Show("Book removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}