using Desktop_Application.Components;

namespace Desktop_Application.Forms.Users
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            save = new RoundedButton();
            cancel = new RoundedButton();
            label_publisher = new Label();
            header = new Panel();
            title = new Label();
            close_btn = new RoundedButton();
            label2 = new Label();
            textBox_lastName = new TextBox();
            textBox_firstName = new TextBox();
            textBox_email = new TextBox();
            label1 = new Label();
            textBox_address = new TextBox();
            label3 = new Label();
            textBox_username = new TextBox();
            label4 = new Label();
            header.SuspendLayout();
            SuspendLayout();
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
            save.Location = new Point(196, 355);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 6;
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
            cancel.Location = new Point(299, 355);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(12, 101);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(128, 32);
            label_publisher.TabIndex = 90;
            label_publisher.Text = "First name";
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(592, 73);
            header.TabIndex = 87;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(235, 15);
            title.Name = "title";
            title.Size = new Size(126, 37);
            title.TabIndex = 2;
            title.Text = "Edit User";
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
            close_btn.Location = new Point(538, 13);
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
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 86;
            label2.Text = "Last name";
            // 
            // textBox_lastName
            // 
            textBox_lastName.BackColor = Color.WhiteSmoke;
            textBox_lastName.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_lastName.Location = new Point(144, 148);
            textBox_lastName.Margin = new Padding(3, 4, 3, 4);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(436, 39);
            textBox_lastName.TabIndex = 2;
            // 
            // textBox_firstName
            // 
            textBox_firstName.BackColor = Color.WhiteSmoke;
            textBox_firstName.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_firstName.Location = new Point(144, 101);
            textBox_firstName.Margin = new Padding(3, 4, 3, 4);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(436, 39);
            textBox_firstName.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.WhiteSmoke;
            textBox_email.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_email.Location = new Point(144, 242);
            textBox_email.Margin = new Padding(3, 4, 3, 4);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(436, 39);
            textBox_email.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14F);
            label1.Location = new Point(12, 245);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 97;
            label1.Text = "Email";
            // 
            // textBox_address
            // 
            textBox_address.BackColor = Color.WhiteSmoke;
            textBox_address.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_address.Location = new Point(144, 289);
            textBox_address.Margin = new Padding(3, 4, 3, 4);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(436, 39);
            textBox_address.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(12, 292);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 99;
            label3.Text = "Address";
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.WhiteSmoke;
            textBox_username.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_username.Location = new Point(144, 195);
            textBox_username.Margin = new Padding(3, 4, 3, 4);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(436, 39);
            textBox_username.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14F);
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 101;
            label4.Text = "Username";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(594, 416);
            Controls.Add(textBox_username);
            Controls.Add(label4);
            Controls.Add(textBox_address);
            Controls.Add(label3);
            Controls.Add(textBox_email);
            Controls.Add(label1);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_lastName);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(label_publisher);
            Controls.Add(header);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditUser";
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
        private TextBox textBox_lastName;
        private TextBox textBox_firstName;
        private TextBox textBox_email;
        private Label label1;
        private TextBox textBox_address;
        private Label label3;
        private TextBox textBox_username;
        private Label label4;
    }
}