using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books;

public partial class AddBook : Form
{
    private string _originalImgPath;

    public AddBook()
    {
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
                string[] authors = textBox_author.Text.Split(", ");
                string[] categories = textBox_category.Text.Split(", ");

                HandleQueries.InsertBook(textBox_isbn.Text, dropDown_publisher.Text, textBox_title.Text, textBox_pubYear.Text, authors, categories);
                MessageBox.Show("Book uploaded succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }

    // Returns true if everything is correct
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

        if (!Regex.IsMatch(textBox_pubYear.Text, "^[0-9]{4}$"))
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

        if (!Regex.IsMatch(textBox_isbn.Text, "^[0-9]{13}$"))
        {
            MessageBox.Show("ISBN number must be a 13 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void OpenChooseAuthor(object sender, EventArgs e)
    {
        List<string> selectedAuthors = textBox_author.Text.Split(", ").ToList();
        ChooseAuthor chooseAuthor = new(selectedAuthors);
        chooseAuthor.ShowDialog();

        textBox_author.Text = string.Join(", ", ChooseAuthor.SelectedAuthors);
    }

    private void OpenChooseCategory(object sender, EventArgs e)
    {
        List<string> selectedCategories = textBox_category.Text.Split(", ").ToList();
        ChooseCategories chooseCategory = new(selectedCategories);
        chooseCategory.ShowDialog();

        textBox_category.Text = string.Join(", ", ChooseCategories.SelectedCategories);
    }

    private void SelectImage(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new();
        if (fileDialog.ShowDialog() == DialogResult.OK && ValidateFile())
        {
            _originalImgPath = fileDialog.FileName;
            textBox_image.Text = fileDialog.FileName;
        }
        else
        {
            _originalImgPath = string.Empty;
            textBox_image.Text = string.Empty;
        }

        bool ValidateFile()
        {
            string originalImgPath = fileDialog.FileName;
            string extension = Path.GetExtension(originalImgPath);
            string[] allowedExtensions = [".jpg", ".jpeg", ".png"];
            if (!allowedExtensions.Contains(extension.ToLower()))
            {
                MessageBox.Show("File format must be jpg, jpeg or png!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FileInfo fileInfo = new(originalImgPath);
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