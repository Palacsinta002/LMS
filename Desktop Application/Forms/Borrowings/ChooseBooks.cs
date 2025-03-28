using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

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
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
        HandleKeys.Handle(this, Keys.Space, MoveBooks);

        var result = HandleQueries.SelectFromFile("SelectBookForBorrowings");
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

    private void Save(object sender, EventArgs e)
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

    private void MoveBooks(object sender, EventArgs e)
    {
        if (ActiveControl == null) return;
        int tabIndex = ActiveControl.TabIndex;
        if (tabIndex == 1)
        {
            MoveRight(sender, e);
        }
        else if (tabIndex == 2)
        {
            MoveLeft(sender, e);
        }
    }

    private void EnterGrid(object sender, EventArgs e)
    {
        if (ActiveControl == null) return;
        int tabIndex = ActiveControl.TabIndex;
        if (tabIndex == 1)
        {
            ChangeColor(selectedBooks_grd, Color.White);
            ChangeColor(allBooks_grd, Color.LightGray);
        }
        else if (tabIndex == 2)
        {
            ChangeColor(allBooks_grd, Color.White);
            ChangeColor(selectedBooks_grd, Color.LightGray);
        }

        static void ChangeColor(DataGridView grd, Color color)
        {
            grd.ColumnHeadersDefaultCellStyle.BackColor = color;
            grd.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
        }
    }

    private void SearchAllBooks(object sender, EventArgs e)
    {
        string[] cols = ["allBooks_title", "allBooks_author", "allBooks_pubYear", "allBooks_isbn"];
        HandleGrids.SearchGrid(allBooks_grd, allBooks_src.Text, cols);
    }

    private void SearchSelectedBooks(object sender, EventArgs e)
    {
        string[] cols = ["selectedBooks_title", "selectedBooks_author", "selectedBooks_pubYear", "selectedBooks_isbn"];
        HandleGrids.SearchGrid(selectedBooks_grd, selectedBooks_src.Text, cols);
    }
}