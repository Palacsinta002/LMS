using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Users;

public partial class RemoveUser : Form
{
    private readonly List<string> _selectedUsernames;

    public RemoveUser(List<string> selectedUsernames)
    {
        _selectedUsernames = selectedUsernames;
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
        HandleQueries.Delete(_selectedUsernames, "Users", "Username");
        MessageBox.Show("User removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}