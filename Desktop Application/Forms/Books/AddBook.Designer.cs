using Desktop_Application.Components;

namespace Desktop_Application.Forms.Books
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            close_btn = new RoundedButton();
            header = new Panel();
            title = new Label();
            textBox_pubYear = new TextBox();
            textBox_isbn = new TextBox();
            label_pubYear = new Label();
            label_isbn = new Label();
            label_category = new Label();
            label_author = new Label();
            label_publisher = new Label();
            textBox_title = new TextBox();
            label_title = new Label();
            dropDown_publisher = new ComboBox();
            textBox_author = new TextBox();
            textBox_category = new TextBox();
            chooseAuthor = new Button();
            chooseCategory = new Button();
            save = new RoundedButton();
            cancel = new RoundedButton();
            header.SuspendLayout();
            SuspendLayout();
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
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(568, 73);
            header.TabIndex = 41;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(225, 16);
            title.Name = "title";
            title.Size = new Size(136, 37);
            title.TabIndex = 2;
            title.Text = "Add Book";
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
            // textBox_isbn
            // 
            textBox_isbn.BackColor = Color.WhiteSmoke;
            textBox_isbn.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_isbn.Location = new Point(125, 348);
            textBox_isbn.Margin = new Padding(3, 4, 3, 4);
            textBox_isbn.MaxLength = 13;
            textBox_isbn.Name = "textBox_isbn";
            textBox_isbn.Size = new Size(173, 39);
            textBox_isbn.TabIndex = 6;
            // 
            // label_pubYear
            // 
            label_pubYear.AutoSize = true;
            label_pubYear.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_pubYear.Location = new Point(14, 148);
            label_pubYear.Name = "label_pubYear";
            label_pubYear.Size = new Size(189, 32);
            label_pubYear.TabIndex = 37;
            label_pubYear.Text = "Publication Year";
            // 
            // label_isbn
            // 
            label_isbn.AutoSize = true;
            label_isbn.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_isbn.Location = new Point(14, 352);
            label_isbn.Name = "label_isbn";
            label_isbn.Size = new Size(67, 32);
            label_isbn.TabIndex = 36;
            label_isbn.Text = "ISBN";
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_category.Location = new Point(14, 249);
            label_category.Name = "label_category";
            label_category.Size = new Size(113, 32);
            label_category.TabIndex = 35;
            label_category.Text = "Category";
            // 
            // label_author
            // 
            label_author.AutoSize = true;
            label_author.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_author.Location = new Point(14, 199);
            label_author.Name = "label_author";
            label_author.Size = new Size(90, 32);
            label_author.TabIndex = 33;
            label_author.Text = "Author";
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(14, 300);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(114, 32);
            label_publisher.TabIndex = 31;
            label_publisher.Text = "Publisher";
            // 
            // textBox_title
            // 
            textBox_title.BackColor = Color.WhiteSmoke;
            textBox_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_title.Location = new Point(125, 93);
            textBox_title.Margin = new Padding(3, 4, 3, 4);
            textBox_title.MaxLength = 255;
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(433, 39);
            textBox_title.TabIndex = 1;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_title.Location = new Point(14, 97);
            label_title.Name = "label_title";
            label_title.Size = new Size(61, 32);
            label_title.TabIndex = 29;
            label_title.Text = "Title";
            // 
            // dropDown_publisher
            // 
            dropDown_publisher.BackColor = Color.WhiteSmoke;
            dropDown_publisher.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDown_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            dropDown_publisher.FormattingEnabled = true;
            dropDown_publisher.Location = new Point(125, 296);
            dropDown_publisher.Margin = new Padding(3, 4, 3, 4);
            dropDown_publisher.MaxDropDownItems = 10;
            dropDown_publisher.Name = "dropDown_publisher";
            dropDown_publisher.Size = new Size(433, 39);
            dropDown_publisher.TabIndex = 5;
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
            textBox_author.TabIndex = 45;
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
            textBox_category.TabIndex = 46;
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
            // save
            // 
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
            save.Location = new Point(184, 426);
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
            cancel.BackColor = Color.WhiteSmoke;
            cancel.BackgroundColor = Color.WhiteSmoke;
            cancel.BorderColor = Color.FromArgb(80, 77, 180);
            cancel.BorderRadius = 5;
            cancel.BorderSize = 2;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Yu Gothic UI Semibold", 14F);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(287, 426);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 80;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 487);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(chooseCategory);
            Controls.Add(chooseAuthor);
            Controls.Add(textBox_category);
            Controls.Add(textBox_author);
            Controls.Add(dropDown_publisher);
            Controls.Add(header);
            Controls.Add(textBox_pubYear);
            Controls.Add(textBox_isbn);
            Controls.Add(label_pubYear);
            Controls.Add(label_isbn);
            Controls.Add(label_category);
            Controls.Add(label_author);
            Controls.Add(label_publisher);
            Controls.Add(textBox_title);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedButton close_btn;
        private Panel header;
        private Label title;
        private TextBox textBox_pubYear;
        private TextBox textBox_isbn;
        private Label label_pubYear;
        private Label label_isbn;
        private Label label_category;
        private Label label_author;
        private Label label_publisher;
        private TextBox textBox_title;
        private Label label_title;
        private ComboBox dropDown_publisher;
        private TextBox textBox_author;
        private TextBox textBox_category;
        private Button chooseAuthor;
        private Button chooseCategory;
        private RoundedButton save;
        private RoundedButton cancel;
    }
}