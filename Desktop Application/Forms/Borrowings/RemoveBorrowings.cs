using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class RemoveBorrowings : Form
{
    private readonly DataGridView _borrowings_grd;

    public RemoveBorrowings(DataGridView borrowings_grd)
    {
        _borrowings_grd = borrowings_grd;
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
        if (CheckReturnDate())
        {
            // Mark the borrowing as returned
            DateTime currentDate = DateTime.Now;
            string returnDate = $"{currentDate.Year}-{currentDate.Month}-{currentDate.Day}";

            List<string> isbns = [];
            foreach (DataGridViewRow row in _borrowings_grd.SelectedRows)
            {
                string? isbn = row.Cells["borrowings_isbn"].Value.ToString();
                if (isbn == null) continue;
                isbns.Add(isbn);
            }

            // Update borrowing in Borrowings_storage so it will be marked as returned
            HandleQueries.UpdateBorrowing(isbns, returnDate);

            // Remove it from the Borrowings table so it only remains in Borrowings_storage
            HandleQueries.Delete(_borrowings_grd, "Borrowings", "borrowings_isbn", "ISBN");

            MessageBox.Show("Book marked as returned succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool CheckReturnDate()
    {
        foreach(DataGridViewRow row in _borrowings_grd.SelectedRows)
        {
            if (row.Cells["borrowings_returnDate"].Value.ToString() != string.Empty)
            {
                MessageBox.Show("There is at least one book selected which is already returned!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        return true;
    }
}