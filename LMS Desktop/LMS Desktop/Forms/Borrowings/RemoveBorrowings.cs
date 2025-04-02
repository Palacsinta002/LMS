using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class RemoveBorrowings : Form
{
    private readonly List<string> _selectedIsbns;

    public RemoveBorrowings(List<string> selectedIsbns)
    {
        _selectedIsbns = selectedIsbns;
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
        // Mark the borrowing as returned
        DateTime currentDate = DateTime.Now;
        string returnDate = $"{currentDate.Year}-{currentDate.Month}-{currentDate.Day}";

        // Update borrowing in Borrowings_storage so it will be marked as returned
        HandleQueries.UpdateBorrowing(_selectedIsbns, returnDate);

        // Remove it from the Borrowings table so it only remains in Borrowings_storage
        HandleQueries.Delete(_selectedIsbns, "Borrowings", "ISBN");

        MessageBox.Show("Book marked as returned succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}