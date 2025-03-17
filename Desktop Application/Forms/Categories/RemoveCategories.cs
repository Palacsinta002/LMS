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
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, no);
    }

    private void Yes(object sender, EventArgs e)
    {
        HandleQueries.Delete(_categories_grd, "Categories", "categories_category", "Category");
        MessageBox.Show("Category/categories removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}