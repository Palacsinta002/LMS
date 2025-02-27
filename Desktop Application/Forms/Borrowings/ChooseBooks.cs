namespace Desktop_Application.Forms.Borrowings; 

using Desktop_Application.Classes;

public partial class ChooseBooks : Form
{
    private static List<string> _selectedISBNs = [];
    public static List<string> SelectedISBNs
    {
        get { return _selectedISBNs; }
    }

    public ChooseBooks(List<string> selectedBooks)
    {
        _selectedISBNs = selectedBooks;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var result = HandleQueries.Select("SelectBookForBorrowings");
        if (_selectedISBNs.Count > 0)
        {
            foreach (var item in result)
            {
                if (_selectedISBNs.Contains(item[3]))
                {
                    selectedBooks_grd.Rows.Add(item);
                }
                else
                {
                    allBooks_grd.Rows.Add(item);
                }
            }
        }
        else
        {
            HandleGrids.Fill(allBooks_grd, result);
        }
    }

    private void Ok(object sender, EventArgs e)
    {
        _selectedISBNs = [];
        foreach (DataGridViewRow row in selectedBooks_grd.Rows)
        {
            _selectedISBNs.Add(row.Cells["selectedBooks_isbn"].Value.ToString() ?? string.Empty);
        }
        this.Close();
    }

    private void MoveRight(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in allBooks_grd.SelectedRows)
        {
            allBooks_grd.Rows.Remove(row);
            selectedBooks_grd.Rows.Add(row);
        }
    }

    private void MoveLeft(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in selectedBooks_grd.SelectedRows)
        {
            selectedBooks_grd.Rows.Remove(row);
            allBooks_grd.Rows.Add(row);
        }
    }
}