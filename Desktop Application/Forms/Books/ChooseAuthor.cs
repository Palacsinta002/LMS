using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class ChooseAuthor : Form
{
    private static List<string> _selectedAuthors = [];
    public static List<string> SelectedAuthors
    {
        get { return _selectedAuthors; }
    }

    public ChooseAuthor(List<string> selectedAuthors)
    {
        _selectedAuthors = selectedAuthors;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var result = HandleQueries.SelectFromFile("SelectAuthorWithBook");
        if (_selectedAuthors.Count > 0)
        {
            foreach (var item in result)
            {
                if (_selectedAuthors.Contains(item[0]))
                {
                    selectedAuthors_grd.Rows.Add(item);
                }
                else
                {
                    allAuthors_grd.Rows.Add(item);
                }
            }
        }
        else
        {
            HandleGrids.Fill(allAuthors_grd, result);
        }
    }

    private void Ok(object sender, EventArgs e)
    {
        _selectedAuthors = [];
        foreach (DataGridViewRow row in selectedAuthors_grd.Rows)
        {
            _selectedAuthors.Add(row.Cells["selectedAuthors_author"].Value.ToString() ?? string.Empty);
        }
        this.Close();
    }

    private void MoveRight(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in allAuthors_grd.SelectedRows)
        {
            allAuthors_grd.Rows.Remove(row);
            selectedAuthors_grd.Rows.Add(row);
        }
    }

    private void MoveLeft(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in selectedAuthors_grd.SelectedRows)
        {
            selectedAuthors_grd.Rows.Remove(row);
            allAuthors_grd.Rows.Add(row);
        }
    }

    private void SearchAllAuthors(object sender, EventArgs e)
    {
        string[] cols = ["allAuthors_author", "allAuthors_books"];
        HandleGrids.SearchGrid(allAuthors_grd, allAuthors_src.Text, cols);
    }

    private void SearchSelectedAuthors(object sender, EventArgs e)
    {
        string[] cols = ["selectedAuthors_author", "selectedAuthors_books"];
        HandleGrids.SearchGrid(selectedAuthors_grd, selectedAuthors_src.Text, cols);
    }
}