using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Publishers;

public partial class RemovePublishers : Form
{
    private readonly List<string> _selectedPublishers;

    public RemovePublishers(List<string> selectedPublishers)
    {
        _selectedPublishers = selectedPublishers;
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
        HandleQueries.Delete(_selectedPublishers, "Publishers", "Publisher");
        MessageBox.Show("Publisher(s) removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}