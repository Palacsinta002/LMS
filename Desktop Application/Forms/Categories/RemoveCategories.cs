using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Categories;

public partial class RemoveCategories : Form
{
    private readonly DataGridView _categories_grd;

    public RemoveCategories(DataGridView categories_grd)
    {
        _categories_grd = categories_grd;
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
        HandleQueries.Delete(_categories_grd, "Categories", "categories_category", "Category");
        MessageBox.Show("Category/categories removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}