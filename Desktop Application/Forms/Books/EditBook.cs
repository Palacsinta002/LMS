using Desktop_Application.Classes;
using Desktop_Application.Forms.Books;
using Desktop_Application.Forms.Books.ConfirmationDialogues;

namespace Desktop_Application
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);
        }

        private void Save(object sender, EventArgs e)
        {
            if(textBox_title.Text == "a") // If publisher does not exist
            {
                PublisherDoesNotExist publisherDoesNotExist = new PublisherDoesNotExist();
                publisherDoesNotExist.ShowDialog();
                if (publisherDoesNotExist.DialogResult != DialogResult.OK) return;
            }

            if(dropDown_publisher.Text == "a") // If the author does not exist
            {
                AuthorDoesNotExist authorDoesNotExist = new AuthorDoesNotExist();
                authorDoesNotExist.ShowDialog();
                if (authorDoesNotExist.DialogResult != DialogResult.OK) return;
            }

            if(textBox_title.Text == string.Empty || dropDown_publisher.Text == string.Empty) // Here we will have to validate the input
            {
                MessageBox.Show("Title and publisher is required!");
            }
            else
            {
                // Upload everything to database
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
