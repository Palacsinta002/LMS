using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class ReturnBook : Form
{
    private readonly DataGridView _borrowings_grd;

    public ReturnBook(DataGridView borrowings_grd)
    {
        _borrowings_grd = borrowings_grd;
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
        if (CheckReturnDate())
        {
            // Mark the borrowing as returned
            DateTime currentDate = DateTime.Now;
            string returnDate = $"{currentDate.Year}-{currentDate.Month}-{currentDate.Day}";

            HandleQueries.UpdateBorrowing(_borrowings_grd, returnDate);

            // Remove it from the Borrowings table so it only remains in Borrowings_storage
            HandleQueries.Delete(_borrowings_grd, "Borrowings", "borrowings_isbn", "ISBN");

            MessageBox.Show("Borrowing marked as returned succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private static bool CheckReturnDate()
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