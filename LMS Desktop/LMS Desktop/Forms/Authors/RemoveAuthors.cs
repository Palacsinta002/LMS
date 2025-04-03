using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Authors;

public partial class RemoveAuthors : Form
{
    private readonly List<string> _selectedAuthors;

    public RemoveAuthors(List<string> selectedAuthors)
    {
        _selectedAuthors = selectedAuthors;
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
        HandleQueries.Delete(_selectedAuthors, "Authors", "Author");
        MessageBox.Show("Authors removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}