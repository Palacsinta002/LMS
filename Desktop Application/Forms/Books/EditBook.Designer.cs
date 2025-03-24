using Desktop_Application.Components;
using Desktop_Application.Forms.Books;

namespace Desktop_Application.Forms.Books
{
    partial class EditBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            label_title = new Label();
            textBox_title = new TextBox();
            label_author = new Label();
            label_category = new Label();
            label_pubYear = new Label();
            textBox_pubYear = new TextBox();
            header = new Panel();
            title = new Label();
            close_btn = new RoundedButton();
            chooseCategory = new Button();
            chooseAuthor = new Button();
            textBox_category = new TextBox();
            textBox_author = new TextBox();
            save = new RoundedButton();
            cancel = new RoundedButton();
            label2 = new Label();
            button_chooseImage = new Button();
            textBox_image = new TextBox();
            label1 = new Label();
            dropDown_publisher = new ComboBox();
            textBox_isbn = new TextBox();
            label_isbn = new Label();
            label_publisher = new Label();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_title.Location = new Point(14, 97);
            label_title.Name = "label_title";
            label_title.Size = new Size(61, 32);
            label_title.TabIndex = 3;
            label_title.Text = "Title";
            // 
            // textBox_title
            // 
            textBox_title.BackColor = Color.WhiteSmoke;
            textBox_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_title.Location = new Point(125, 93);
            textBox_title.Margin = new Padding(3, 4, 3, 4);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(433, 39);
            textBox_title.TabIndex = 1;
            // 
            // label_author
            // 
            label_author.AutoSize = true;
            label_author.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_author.Location = new Point(14, 199);
            label_author.Name = "label_author";
            label_author.Size = new Size(90, 32);
            label_author.TabIndex = 12;
            label_author.Text = "Author";
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_category.Location = new Point(14, 249);
            label_category.Name = "label_category";
            label_category.Size = new Size(113, 32);
            label_category.TabIndex = 14;
            label_category.Text = "Category";
            // 
            // label_pubYear
            // 
            label_pubYear.AutoSize = true;
            label_pubYear.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_pubYear.Location = new Point(14, 148);
            label_pubYear.Name = "label_pubYear";
            label_pubYear.Size = new Size(189, 32);
            label_pubYear.TabIndex = 18;
            label_pubYear.Text = "Publication Year";
            // 
            // textBox_pubYear
            // 
            textBox_pubYear.BackColor = Color.WhiteSmoke;
            textBox_pubYear.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_pubYear.Location = new Point(209, 145);
            textBox_pubYear.Margin = new Padding(3, 4, 3, 4);
            textBox_pubYear.MaxLength = 4;
            textBox_pubYear.Name = "textBox_pubYear";
            textBox_pubYear.Size = new Size(63, 39);
            textBox_pubYear.TabIndex = 2;
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(2, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(568, 73);
            header.TabIndex = 46;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(216, 16);
            title.Name = "title";
            title.Size = new Size(133, 37);
            title.TabIndex = 2;
            title.Text = "Edit Book";
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.BackgroundColor = Color.Transparent;
            close_btn.BorderColor = Color.Transparent;
            close_btn.BorderRadius = 0;
            close_btn.BorderSize = 0;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            close_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            close_btn.ForeColor = Color.White;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(514, 15);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // chooseCategory
            // 
            chooseCategory.Location = new Point(515, 245);
            chooseCategory.Margin = new Padding(3, 4, 3, 4);
            chooseCategory.Name = "chooseCategory";
            chooseCategory.Size = new Size(42, 43);
            chooseCategory.TabIndex = 4;
            chooseCategory.Text = "...";
            chooseCategory.UseVisualStyleBackColor = true;
            chooseCategory.Click += OpenChooseCategory;
            // 
            // chooseAuthor
            // 
            chooseAuthor.Location = new Point(515, 195);
            chooseAuthor.Margin = new Padding(3, 4, 3, 4);
            chooseAuthor.Name = "chooseAuthor";
            chooseAuthor.Size = new Size(42, 43);
            chooseAuthor.TabIndex = 3;
            chooseAuthor.Text = "...";
            chooseAuthor.UseVisualStyleBackColor = true;
            chooseAuthor.Click += OpenChooseAuthor;
            // 
            // textBox_category
            // 
            textBox_category.BackColor = Color.WhiteSmoke;
            textBox_category.Enabled = false;
            textBox_category.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_category.Location = new Point(125, 245);
            textBox_category.Margin = new Padding(3, 4, 3, 4);
            textBox_category.Name = "textBox_category";
            textBox_category.Size = new Size(383, 39);
            textBox_category.TabIndex = 50;
            // 
            // textBox_author
            // 
            textBox_author.BackColor = Color.WhiteSmoke;
            textBox_author.Enabled = false;
            textBox_author.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_author.Location = new Point(125, 195);
            textBox_author.Margin = new Padding(3, 4, 3, 4);
            textBox_author.Name = "textBox_author";
            textBox_author.Size = new Size(383, 39);
            textBox_author.TabIndex = 49;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            save.BackColor = Color.FromArgb(80, 77, 180);
            save.BackgroundColor = Color.FromArgb(80, 77, 180);
            save.BorderColor = Color.Transparent;
            save.BorderRadius = 5;
            save.BorderSize = 0;
            save.FlatAppearance.BorderSize = 0;
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Yu Gothic UI Semibold", 14F);
            save.ForeColor = Color.White;
            save.Location = new Point(185, 450);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 79;
            save.TabStop = false;
            save.Text = "Save";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Save;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancel.BackColor = Color.WhiteSmoke;
            cancel.BackgroundColor = Color.WhiteSmoke;
            cancel.BorderColor = Color.FromArgb(80, 77, 180);
            cancel.BorderRadius = 5;
            cancel.BorderSize = 2;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Yu Gothic UI Semibold", 14F);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(288, 450);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 80;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(325, 296);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 92;
            label2.Text = "Add book pics";
            // 
            // button_chooseImage
            // 
            button_chooseImage.Location = new Point(515, 292);
            button_chooseImage.Margin = new Padding(3, 4, 3, 4);
            button_chooseImage.Name = "button_chooseImage";
            button_chooseImage.Size = new Size(42, 43);
            button_chooseImage.TabIndex = 85;
            button_chooseImage.Text = "...";
            button_chooseImage.UseVisualStyleBackColor = true;
            // 
            // textBox_image
            // 
            textBox_image.BackColor = Color.WhiteSmoke;
            textBox_image.Enabled = false;
            textBox_image.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_image.Location = new Point(125, 292);
            textBox_image.Margin = new Padding(3, 4, 3, 4);
            textBox_image.Name = "textBox_image";
            textBox_image.Size = new Size(383, 39);
            textBox_image.TabIndex = 91;
            textBox_image.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14F);
            label1.Location = new Point(14, 296);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 90;
            label1.Text = "Image";
            // 
            // dropDown_publisher
            // 
            dropDown_publisher.BackColor = Color.WhiteSmoke;
            dropDown_publisher.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDown_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            dropDown_publisher.FormattingEnabled = true;
            dropDown_publisher.Location = new Point(126, 339);
            dropDown_publisher.Margin = new Padding(3, 4, 3, 4);
            dropDown_publisher.MaxDropDownItems = 10;
            dropDown_publisher.Name = "dropDown_publisher";
            dropDown_publisher.Size = new Size(433, 39);
            dropDown_publisher.TabIndex = 86;
            // 
            // textBox_isbn
            // 
            textBox_isbn.BackColor = Color.WhiteSmoke;
            textBox_isbn.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_isbn.Location = new Point(126, 391);
            textBox_isbn.Margin = new Padding(3, 4, 3, 4);
            textBox_isbn.MaxLength = 13;
            textBox_isbn.Name = "textBox_isbn";
            textBox_isbn.Size = new Size(173, 39);
            textBox_isbn.TabIndex = 87;
            // 
            // label_isbn
            // 
            label_isbn.AutoSize = true;
            label_isbn.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_isbn.Location = new Point(15, 395);
            label_isbn.Name = "label_isbn";
            label_isbn.Size = new Size(67, 32);
            label_isbn.TabIndex = 89;
            label_isbn.Text = "ISBN";
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(15, 343);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(114, 32);
            label_publisher.TabIndex = 88;
            label_publisher.Text = "Publisher";
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 510);
            Controls.Add(label2);
            Controls.Add(button_chooseImage);
            Controls.Add(textBox_image);
            Controls.Add(label1);
            Controls.Add(dropDown_publisher);
            Controls.Add(textBox_isbn);
            Controls.Add(label_isbn);
            Controls.Add(label_publisher);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(chooseCategory);
            Controls.Add(chooseAuthor);
            Controls.Add(textBox_category);
            Controls.Add(textBox_author);
            Controls.Add(header);
            Controls.Add(textBox_pubYear);
            Controls.Add(label_pubYear);
            Controls.Add(label_category);
            Controls.Add(label_author);
            Controls.Add(textBox_title);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBook";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_title;
        private TextBox textBox_title;
        private Label label_author;
        private Label label_category;
        private Label label_pubYear;
        private TextBox textBox_pubYear;
        private Panel header;
        private Label title;
        private RoundedButton close_btn;
        private Button chooseCategory;
        private Button chooseAuthor;
        private TextBox textBox_category;
        private TextBox textBox_author;
        private RoundedButton save;
        private RoundedButton cancel;
        private Label label2;
        private Button button_chooseImage;
        private TextBox textBox_image;
        private Label label1;
        private ComboBox dropDown_publisher;
        private TextBox textBox_isbn;
        private Label label_isbn;
        private Label label_publisher;
    }
}