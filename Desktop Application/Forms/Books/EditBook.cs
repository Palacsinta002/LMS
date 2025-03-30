using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class EditBook : Form
{
    private readonly DataGridView _books_grd;
    private string _oldIsbn;
    private string _originalImgPath;

    public EditBook(DataGridView books_grd)
    {
        _books_grd = books_grd;
        _oldIsbn = string.Empty;
        _originalImgPath = string.Empty;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        var result = HandleQueries.SelectFromFile("SelectPublisher");
        HandleGrids.Fill(dropDown_publisher, result);

        var selectedRow = _books_grd.SelectedRows[0].Cells;

        textBox_title.Text = selectedRow["books_title"].Value.ToString();
        textBox_pubYear.Text = selectedRow["books_publicationYear"].Value.ToString();
        textBox_author.Text = selectedRow["books_author"].Value.ToString();
        textBox_category.Text = selectedRow["books_category"].Value.ToString();
        dropDown_publisher.Text = selectedRow["books_publisher"].Value.ToString();
        textBox_isbn.Text = selectedRow["books_isbn"].Value.ToString();
        _oldIsbn = selectedRow["books_isbn"].Value.ToString() ?? string.Empty;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            bool uploadSuccessful = false;

            if (_originalImgPath != string.Empty)
            {
                string extension = Path.GetExtension(_originalImgPath);
                string newName = textBox_isbn.Text + extension;
                string tempPath = Path.Combine(Path.GetTempPath(), newName);
                File.Copy(_originalImgPath, tempPath, true);
                uploadSuccessful = HandleFiles.Upload(tempPath);
            }
            if (uploadSuccessful || _originalImgPath == string.Empty)
            {
                string[] authors = [.. textBox_author.Text.Split(", ")];
                string[] categories = [.. textBox_category.Text.Split(", ")];

                HandleQueries.UpdateBook(_oldIsbn, textBox_isbn.Text, dropDown_publisher.Text, textBox_title.Text, textBox_pubYear.Text, authors, categories);
                MessageBox.Show("Book updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        else if (!Regex.IsMatch(textBox_title.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Title is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!Regex.IsMatch(textBox_pubYear.Text, @"^[0-9]{4}$"))
        {
            MessageBox.Show("Publication year must be a 4 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        if (dropDown_publisher.Text == string.Empty)
        {
            MessageBox.Show("You must choose a publisher from the dropdown menu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!Regex.IsMatch(textBox_isbn.Text, @"^[0-9]{13}$"))
        {
            MessageBox.Show("ISBN number must be a 13 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void OpenChooseAuthor(object sender, EventArgs e)
    {
        List<string> selectedAuthors = [.. textBox_author.Text.Split(", ")];
        ChooseAuthor chooseAuthor = new(selectedAuthors);
        chooseAuthor.ShowDialog();

        textBox_author.Text = string.Join(", ", ChooseAuthor.SelectedAuthors);
    }

    private void OpenChooseCategory(object sender, EventArgs e)
    {
        List<string> selectedCategories = [.. textBox_category.Text.Split(", ")];
        ChooseCategories chooseCategory = new(selectedCategories);
        chooseCategory.ShowDialog();

        textBox_category.Text = string.Join(", ", ChooseCategories.SelectedCategories);
    }

    private void SelectImage(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new();
        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            _originalImgPath = fileDialog.FileName;
            textBox_image.Text = _originalImgPath;
            if (!ValidateFile())
            {
                _originalImgPath = string.Empty;
                textBox_image.Text = string.Empty;
            }
        }
        else
        {
            _originalImgPath = string.Empty;
            textBox_image.Text = string.Empty;
        }

        bool ValidateFile()
        {
            string extension = Path.GetExtension(_originalImgPath);
            string[] allowedExtensions = [".jpg", ".jpeg", ".png"];
            if (!allowedExtensions.Contains(extension.ToLower()))
            {
                MessageBox.Show("File format must be jpg, jpeg or png!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FileInfo fileInfo = new(_originalImgPath);
            double sizeInMegabytes = fileInfo.Length / Math.Pow(1024.0, 2);
            if (sizeInMegabytes > 5)
            {
                MessageBox.Show($"The maximum allowed file size is 5 MB, your file is {Math.Round(sizeInMegabytes)} MB!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}