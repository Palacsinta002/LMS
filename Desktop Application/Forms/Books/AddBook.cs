using System.Text.RegularExpressions;
using Desktop_Application.Classes;
using Desktop_Application.Forms.Books;

namespace Desktop_Application
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);

            HandleQueries.SelectFill(dropDown_publisher, "PublisherSelect");
        }

        private void Save(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                HandleQueries.InsertBook(textBox_isbn.Text, dropDown_publisher.Text, textBox_title.Text, textBox_pubYear.Text, textBox_author.Text, textBox_category.Text);
                MessageBox.Show("Book uploaded succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HandleQueries.SelectFill(adminPanel.books_grd, "BookSelect");
                this.Close();
            }
        }

        // returns true if everything is correct
        private bool ValidateInput()
        {
            if (textBox_title.Text == string.Empty)
            {
                MessageBox.Show("Title is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(textBox_pubYear.Text, "^[0-9]{4}$"))
            {
                MessageBox.Show("Publication year must be a 4 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dropDown_publisher.Text == string.Empty)
            {
                MessageBox.Show("You must choose a publisher from the dropdown menu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_author.Text == string.Empty)
            {
                MessageBox.Show("You must choose at least one author!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_category.Text == string.Empty)
            {
                MessageBox.Show("You must choose at least one vategory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(textBox_isbn.Text, "^[0-9]{13}$"))
            {
                MessageBox.Show("ISBN number must be a 13 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void OpenChooseAuthor(object sender, EventArgs e)
        {
            ChooseAuthor chooseAuthor = new();
            chooseAuthor.ShowDialog();

            textBox_author.Text = string.Join(", ", ChooseAuthor.SelectedAuthors);
        }

        private void OpenChooseCategory(object sender, EventArgs e)
        {
            ChooseCategory chooseCategory = new();
            chooseCategory.ShowDialog();

            textBox_category.Text = string.Join(", ", ChooseCategory.SelectedCategories);
        }
    }
}
