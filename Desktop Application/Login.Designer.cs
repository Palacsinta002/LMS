namespace Desktop_Application
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_btn = new Button();
            login_title = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            username_label = new Label();
            password_label = new Label();
            close_btn = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            login_btn.Location = new Point(182, 249);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 33);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += LoginCheck;
            // 
            // login_title
            // 
            login_title.AutoSize = true;
            login_title.Font = new Font("Yu Gothic UI Semibold", 24F);
            login_title.ImeMode = ImeMode.NoControl;
            login_title.Location = new Point(91, 46);
            login_title.Name = "login_title";
            login_title.Size = new Size(101, 45);
            login_title.TabIndex = 1;
            login_title.Text = "Login";
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(22, 135);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(235, 23);
            username_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(22, 198);
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '●';
            password_textBox.Size = new Size(235, 23);
            password_textBox.TabIndex = 1;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Yu Gothic UI Semibold", 12F);
            username_label.Location = new Point(22, 111);
            username_label.Name = "username_label";
            username_label.Size = new Size(83, 21);
            username_label.TabIndex = 4;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Yu Gothic UI Semibold", 12F);
            password_label.Location = new Point(22, 174);
            password_label.Name = "password_label";
            password_label.Size = new Size(79, 21);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // close_btn
            // 
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            close_btn.Location = new Point(253, 11);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(20, 21);
            close_btn.TabIndex = 6;
            close_btn.Text = "X";
            close_btn.Click += CloseWindow;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 311);
            Controls.Add(close_btn);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(login_title);
            Controls.Add(login_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += Login_MouseDown;
            MouseMove += Login_MouseMove;
            MouseUp += Login_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private Label login_title;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label username_label;
        private Label password_label;
        private Label close_btn;
    }
}
