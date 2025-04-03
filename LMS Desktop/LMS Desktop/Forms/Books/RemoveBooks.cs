using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class RemoveBooks : Form
{
    private readonly List<string> _selectedIsbns;

    public RemoveBooks(List<string> selectedIsbns)
    {
        _selectedIsbns = selectedIsbns;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, no);
        HandleKeys.Handle(this, Keys.Enter, Remove);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Remove(object sender, EventArgs e)
    {
        HandleQueries.Delete(_selectedIsbns, "Books", "ISBN");
        MessageBox.Show("Book removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}