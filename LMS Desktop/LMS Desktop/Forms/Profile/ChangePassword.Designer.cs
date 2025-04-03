using Desktop_Application.Components;

namespace Desktop_Application.Forms.Profile
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            save = new RoundedButton();
            cancel = new RoundedButton();
            label_publisher = new Label();
            header = new Panel();
            title = new Label();
            close_btn = new RoundedButton();
            label2 = new Label();
            textBox_newPassword = new TextBox();
            textBox_currentPassword = new TextBox();
            textBox_newPasswordAgain = new TextBox();
            label4 = new Label();
            button_showPassword = new Button();
            label3 = new Label();
            label_special = new Label();
            label_lower = new Label();
            label_upper = new Label();
            rButton_upper = new Button();
            rButton_lower = new Button();
            rButton_special = new Button();
            rButton_characterCount = new Button();
            label_characterCount = new Label();
            rButton_match = new Button();
            label_match = new Label();
            header.SuspendLayout();
            SuspendLayout();
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
            save.Location = new Point(197, 522);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 8;
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
            cancel.Location = new Point(299, 522);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 9;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(11, 101);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(206, 32);
            label_publisher.TabIndex = 90;
            label_publisher.Text = "Current Password";
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(481, 73);
            header.TabIndex = 87;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(104, 15);
            title.Name = "title";
            title.Size = new Size(232, 37);
            title.TabIndex = 2;
            title.Text = "Change Password";
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            close_btn.Location = new Point(427, 13);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(11, 151);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 86;
            label2.Text = "New Password";
            // 
            // textBox_newPassword
            // 
            textBox_newPassword.BackColor = Color.WhiteSmoke;
            textBox_newPassword.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_newPassword.Location = new Point(222, 148);
            textBox_newPassword.Margin = new Padding(3, 4, 3, 4);
            textBox_newPassword.MaxLength = 16;
            textBox_newPassword.Name = "textBox_newPassword";
            textBox_newPassword.PasswordChar = '*';
            textBox_newPassword.Size = new Size(247, 39);
            textBox_newPassword.TabIndex = 2;
            textBox_newPassword.TextChanged += OnPasswordChange;
            // 
            // textBox_currentPassword
            // 
            textBox_currentPassword.BackColor = Color.WhiteSmoke;
            textBox_currentPassword.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_currentPassword.Location = new Point(222, 101);
            textBox_currentPassword.Margin = new Padding(3, 4, 3, 4);
            textBox_currentPassword.MaxLength = 16;
            textBox_currentPassword.Name = "textBox_currentPassword";
            textBox_currentPassword.PasswordChar = '*';
            textBox_currentPassword.Size = new Size(247, 39);
            textBox_currentPassword.TabIndex = 1;
            // 
            // textBox_newPasswordAgain
            // 
            textBox_newPasswordAgain.BackColor = Color.WhiteSmoke;
            textBox_newPasswordAgain.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_newPasswordAgain.Location = new Point(222, 429);
            textBox_newPasswordAgain.Margin = new Padding(3, 4, 3, 4);
            textBox_newPasswordAgain.MaxLength = 16;
            textBox_newPasswordAgain.Name = "textBox_newPasswordAgain";
            textBox_newPasswordAgain.PasswordChar = '*';
            textBox_newPasswordAgain.Size = new Size(247, 39);
            textBox_newPasswordAgain.TabIndex = 3;
            textBox_newPasswordAgain.TextChanged += OnPasswordAgainChange;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14F);
            label4.Location = new Point(11, 431);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 101;
            label4.Text = "Password Again";
            // 
            // button_showPassword
            // 
            button_showPassword.BackColor = Color.WhiteSmoke;
            button_showPassword.Cursor = Cursors.Hand;
            button_showPassword.FlatAppearance.BorderSize = 0;
            button_showPassword.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button_showPassword.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            button_showPassword.FlatStyle = FlatStyle.Flat;
            button_showPassword.Image = (Image)resources.GetObject("button_showPassword.Image");
            button_showPassword.Location = new Point(431, 149);
            button_showPassword.Margin = new Padding(3, 4, 3, 4);
            button_showPassword.Name = "button_showPassword";
            button_showPassword.Size = new Size(37, 37);
            button_showPassword.TabIndex = 104;
            button_showPassword.UseVisualStyleBackColor = false;
            button_showPassword.Click += ShowPassword;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(222, 195);
            label3.Name = "label3";
            label3.Size = new Size(210, 40);
            label3.TabIndex = 108;
            label3.Text = "󠁏󠁏At least one...";
            // 
            // label_special
            // 
            label_special.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_special.ForeColor = Color.Red;
            label_special.Location = new Point(248, 353);
            label_special.Name = "label_special";
            label_special.Size = new Size(210, 72);
            label_special.TabIndex = 107;
            label_special.Text = "Special character\r\nor number";
            // 
            // label_lower
            // 
            label_lower.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_lower.ForeColor = Color.Red;
            label_lower.Location = new Point(248, 313);
            label_lower.Name = "label_lower";
            label_lower.Size = new Size(209, 40);
            label_lower.TabIndex = 106;
            label_lower.Text = "Lower case letter";
            // 
            // label_upper
            // 
            label_upper.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_upper.ForeColor = Color.Red;
            label_upper.Location = new Point(248, 273);
            label_upper.Name = "label_upper";
            label_upper.Size = new Size(209, 40);
            label_upper.TabIndex = 105;
            label_upper.Text = "Upper case letter";
            // 
            // rButton_upper
            // 
            rButton_upper.BackColor = Color.White;
            rButton_upper.FlatAppearance.BorderSize = 0;
            rButton_upper.FlatAppearance.MouseDownBackColor = Color.White;
            rButton_upper.FlatAppearance.MouseOverBackColor = Color.White;
            rButton_upper.FlatStyle = FlatStyle.Flat;
            rButton_upper.Image = (Image)resources.GetObject("rButton_upper.Image");
            rButton_upper.Location = new Point(219, 269);
            rButton_upper.Margin = new Padding(3, 4, 3, 4);
            rButton_upper.Name = "rButton_upper";
            rButton_upper.Size = new Size(33, 40);
            rButton_upper.TabIndex = 109;
            rButton_upper.TabStop = false;
            rButton_upper.UseVisualStyleBackColor = false;
            // 
            // rButton_lower
            // 
            rButton_lower.BackColor = Color.White;
            rButton_lower.FlatAppearance.BorderSize = 0;
            rButton_lower.FlatAppearance.MouseDownBackColor = Color.White;
            rButton_lower.FlatAppearance.MouseOverBackColor = Color.White;
            rButton_lower.FlatStyle = FlatStyle.Flat;
            rButton_lower.Image = (Image)resources.GetObject("rButton_lower.Image");
            rButton_lower.Location = new Point(219, 309);
            rButton_lower.Margin = new Padding(3, 4, 3, 4);
            rButton_lower.Name = "rButton_lower";
            rButton_lower.Size = new Size(33, 40);
            rButton_lower.TabIndex = 110;
            rButton_lower.TabStop = false;
            rButton_lower.UseVisualStyleBackColor = false;
            // 
            // rButton_special
            // 
            rButton_special.BackColor = Color.White;
            rButton_special.FlatAppearance.BorderSize = 0;
            rButton_special.FlatAppearance.MouseDownBackColor = Color.White;
            rButton_special.FlatAppearance.MouseOverBackColor = Color.White;
            rButton_special.FlatStyle = FlatStyle.Flat;
            rButton_special.Image = (Image)resources.GetObject("rButton_special.Image");
            rButton_special.Location = new Point(219, 351);
            rButton_special.Margin = new Padding(3, 4, 3, 4);
            rButton_special.Name = "rButton_special";
            rButton_special.Size = new Size(33, 40);
            rButton_special.TabIndex = 111;
            rButton_special.TabStop = false;
            rButton_special.UseVisualStyleBackColor = false;
            // 
            // rButton_characterCount
            // 
            rButton_characterCount.BackColor = Color.White;
            rButton_characterCount.FlatAppearance.BorderSize = 0;
            rButton_characterCount.FlatAppearance.MouseDownBackColor = Color.White;
            rButton_characterCount.FlatAppearance.MouseOverBackColor = Color.White;
            rButton_characterCount.FlatStyle = FlatStyle.Flat;
            rButton_characterCount.Image = (Image)resources.GetObject("rButton_characterCount.Image");
            rButton_characterCount.Location = new Point(219, 232);
            rButton_characterCount.Margin = new Padding(3, 4, 3, 4);
            rButton_characterCount.Name = "rButton_characterCount";
            rButton_characterCount.Size = new Size(33, 40);
            rButton_characterCount.TabIndex = 113;
            rButton_characterCount.TabStop = false;
            rButton_characterCount.UseVisualStyleBackColor = false;
            // 
            // label_characterCount
            // 
            label_characterCount.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_characterCount.ForeColor = Color.Red;
            label_characterCount.Location = new Point(248, 235);
            label_characterCount.Name = "label_characterCount";
            label_characterCount.Size = new Size(210, 39);
            label_characterCount.TabIndex = 112;
            label_characterCount.Text = "8-16 characters";
            // 
            // rButton_match
            // 
            rButton_match.BackColor = Color.White;
            rButton_match.FlatAppearance.BorderSize = 0;
            rButton_match.FlatAppearance.MouseDownBackColor = Color.White;
            rButton_match.FlatAppearance.MouseOverBackColor = Color.White;
            rButton_match.FlatStyle = FlatStyle.Flat;
            rButton_match.Image = (Image)resources.GetObject("rButton_match.Image");
            rButton_match.Location = new Point(217, 473);
            rButton_match.Margin = new Padding(3, 4, 3, 4);
            rButton_match.Name = "rButton_match";
            rButton_match.Size = new Size(33, 40);
            rButton_match.TabIndex = 117;
            rButton_match.TabStop = false;
            rButton_match.UseVisualStyleBackColor = false;
            // 
            // label_match
            // 
            label_match.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_match.ForeColor = Color.Green;
            label_match.Location = new Point(246, 475);
            label_match.Name = "label_match";
            label_match.Size = new Size(210, 37);
            label_match.TabIndex = 116;
            label_match.Text = "Passwords match";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(483, 583);
            Controls.Add(rButton_match);
            Controls.Add(label_match);
            Controls.Add(rButton_characterCount);
            Controls.Add(label_characterCount);
            Controls.Add(rButton_special);
            Controls.Add(rButton_lower);
            Controls.Add(label_upper);
            Controls.Add(rButton_upper);
            Controls.Add(label3);
            Controls.Add(label_special);
            Controls.Add(label_lower);
            Controls.Add(button_showPassword);
            Controls.Add(textBox_newPasswordAgain);
            Controls.Add(label4);
            Controls.Add(textBox_currentPassword);
            Controls.Add(textBox_newPassword);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(label_publisher);
            Controls.Add(header);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton save;
        private RoundedButton cancel;
        private Label label_publisher;
        private Panel header;
        private Label title;
        private RoundedButton close_btn;
        private Label label2;
        private TextBox textBox_newPassword;
        private TextBox textBox_currentPassword;
        private TextBox textBox_newPasswordAgain;
        private Label label4;
        private Button button_showPassword;
        private Label label3;
        private Label label_special;
        private Label label_lower;
        private Label label_upper;
        private Button rButton_upper;
        private Button rButton_lower;
        private Button rButton_special;
        private Button rButton_characterCount;
        private Label label_characterCount;
        private Button rButton_allowed;
        private Label label_allowed;
        private Button rButton_match;
        private Label label_match;
    }
}