using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings
{
    public partial class AddBorrowing : Form
    {
        private DateTime _borrowDate;
        private DateTime _dueDate;

        public AddBorrowing()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);

            var result = HandleQueries.Select("SelectUsername");
            HandleGrids.Fill(dropDown_user, result);
        }

        private void Save(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                HandleQueries.InsertBorrowing(dropDown_user.Text, textBox_books.Text, _borrowDate, _dueDate);
                MessageBox.Show("Book lent succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // returns true if everything is correct
        private bool ValidateInput()
        {
            if (dropDown_user.Text == string.Empty)
            {
                MessageBox.Show("Username is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_books.Text == string.Empty)
            {
                MessageBox.Show("Books are required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!CheckBook(textBox_books.Text))
            {
                MessageBox.Show("You cannot lend this book because it is already lent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int[] bDate = borrowDate_datePicker.Text.Split('/').Select(int.Parse).ToArray();
            _borrowDate = new(bDate[2], bDate[1], bDate[0]);

            int[] dDate = dueDate_datePicker.Text.Split('/').Select(int.Parse).ToArray();
            _dueDate = new(dDate[2], dDate[1], dDate[0]);

            if (_borrowDate > _dueDate)
            {
                MessageBox.Show("Due date cannot be earlier than borrow date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        // Check if the ISBN given by the user is exist in the database
        private static bool CheckBook(string isbn)
        {
            var result = HandleQueries.Select("SelectBook");

            foreach (var item in result)
            {
                // index = 5, because the 5th column in the select is the ISBN
                if (item[5].ToString() == isbn)
                {
                    return true;
                }
            }
            return false;
        }

        private void OpenChooseBooks(object sender, EventArgs e)
        {
            ChooseBooks chooseBooks = new();
            chooseBooks.ShowDialog();

            textBox_books.Text = string.Join(", ", ChooseBooks.SelectedBooks);
        }
    }
}
