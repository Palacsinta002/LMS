using Desktop_Application.Classes;
using System.Net;
using System.Text.RegularExpressions;

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
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        var result = HandleQueries.SelectFromFile("SelectPublisher");
        HandleGrids.Fill(dropDown_publisher, result);
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            save.Enabled = false;

            HandleQueries.InsertBook(textBox_isbn.Text, dropDown_publisher.Text, textBox_title.Text, textBox_pubYear.Text, textBox_author.Text, textBox_category.Text);

            if (_originalImgPath != string.Empty)
            {
                string extension = Path.GetExtension(_originalImgPath);
                string newName = textBox_isbn.Text + extension;
                string tempPath = Path.Combine(Path.GetTempPath(), newName);
                UploadImage(_originalImgPath, tempPath);
            }

            save.Enabled = true;
            this.Close();
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
        if(fileDialog.ShowDialog() == DialogResult.OK)
        {
            _originalImgPath = fileDialog.FileName;
            textBox_image.Text = _originalImgPath;
        }
        else
        {
            _originalImgPath = string.Empty;
            textBox_image.Text = string.Empty;
        }
    }

    private static void UploadImage(string originalPath, string tempPath)
    {
        try
        {
            File.Copy(originalPath, tempPath, true);
            WebClient webClient = new();
            webClient.UploadFile("http://localhost:8000/api/uploadimage", "POST", tempPath);
            MessageBox.Show("Book uploaded succesfully to the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("The book is uploaded to the database but something went wrong during file upload! Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (File.Exists(tempPath)) File.Delete(tempPath);
        }
    }
}