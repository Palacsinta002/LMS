using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class ChooseCategories : Form
{
    private static List<string> _selectedCategories = [];
    public static List<string> SelectedCategories
    {
        get { return _selectedCategories; }
    }

    public ChooseCategories(List<string> selectedCategories)
    {
        _selectedCategories = selectedCategories;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var result = HandleQueries.Select("SelectCategory");
        if (_selectedCategories.Count > 0)
        {
            foreach (var item in result)
            {
                if (_selectedCategories.Contains(item[0]))
                {
                    selectedCategories_grd.Rows.Add(item);
                }
                else
                {
                    allCategories_grd.Rows.Add(item);
                }
            }
        }
        else
        {
            HandleGrids.Fill(allCategories_grd, result);
        }
    }

    private void Ok(object sender, EventArgs e)
    {
        _selectedCategories = [];
        foreach (DataGridViewRow row in selectedCategories_grd.Rows)
        {
            _selectedCategories.Add(row.Cells["selectedCategories_category"].Value.ToString() ?? string.Empty);
        }
        this.Close();
    }

    private void MoveRight(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in allCategories_grd.SelectedRows)
        {
            allCategories_grd.Rows.Remove(row);
            selectedCategories_grd.Rows.Add(row);
        }
    }

    private void MoveLeft(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in selectedCategories_grd.SelectedRows)
        {
            selectedCategories_grd.Rows.Remove(row);
            allCategories_grd.Rows.Add(row);
        }
    }

    private void SearchAllCategories(object sender, EventArgs e)
    {
        string[] cols = ["allCategories_category"];
        HandleGrids.SearchGrid(allCategories_grd, allCategories_src.Text, cols);
    }

    private void SearchSelectedCategories(object sender, EventArgs e)
    {
        string[] cols = ["selectedCategories_category"];
        HandleGrids.SearchGrid(selectedCategories_grd, selectedCategories_src.Text, cols);
    }
}