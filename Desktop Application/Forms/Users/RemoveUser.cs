using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Users;

public partial class RemoveUser : Form
{
    private readonly DataGridView _users_grd;

    public RemoveUser(DataGridView users_grd)
    {
        _users_grd = users_grd;
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
        HandleQueries.Delete(_users_grd, "Users", "users_username", "Username");
        MessageBox.Show("User removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}