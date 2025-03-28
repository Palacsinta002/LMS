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
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
        HandleKeys.Handle(this, Keys.Space, MoveCategories);

        var result = HandleQueries.SelectFromFile("SelectCategory");
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

    private void Save(object sender, EventArgs e)
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

    private void MoveCategories(object sender, EventArgs e)
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
            ChangeColor(selectedCategories_grd, Color.White);
            ChangeColor(allCategories_grd, Color.LightGray);
        }
        else if (tabIndex == 2)
        {
            ChangeColor(allCategories_grd, Color.White);
            ChangeColor(selectedCategories_grd, Color.LightGray);
        }

        static void ChangeColor(DataGridView grd, Color color)
        {
            grd.ColumnHeadersDefaultCellStyle.BackColor = color;
            grd.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
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