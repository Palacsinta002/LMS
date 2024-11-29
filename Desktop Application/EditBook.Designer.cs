namespace Desktop_Application
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            roundedButton1 = new RoundedButton();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            books_edit_btn = new RoundedButton();
            close_btn = new RoundedButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 16F);
            label1.Location = new Point(126, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 2;
            label1.Text = "Edit Book";
            label1.MouseDown += EditBook_MouseDown;
            label1.MouseMove += EditBook_MouseMove;
            label1.MouseUp += EditBook_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox1.Location = new Point(109, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 32);
            textBox1.TabIndex = 9;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.WhiteSmoke;
            roundedButton1.BackgroundColor = Color.WhiteSmoke;
            roundedButton1.BorderColor = Color.FromArgb(80, 77, 180);
            roundedButton1.BorderRadius = 5;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(272, 312);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(80, 36);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "Cancel";
            roundedButton1.TextColor = Color.Black;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox2.Location = new Point(109, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 32);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 10;
            label3.Text = "Publisher";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox3.Location = new Point(109, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 32);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14F);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 12;
            label4.Text = "Author";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox4.Location = new Point(109, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 32);
            textBox4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 14F);
            label5.Location = new Point(12, 225);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 14;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Semibold", 14F);
            label6.Location = new Point(12, 263);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 16;
            label6.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 14F);
            label7.Location = new Point(12, 111);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 18;
            label7.Text = "Publication Year";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox5.Location = new Point(109, 260);
            textBox5.MaxLength = 13;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 32);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox6.Location = new Point(168, 108);
            textBox6.MaxLength = 4;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 32);
            textBox6.TabIndex = 20;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // books_edit_btn
            // 
            books_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_edit_btn.BorderColor = Color.Transparent;
            books_edit_btn.BorderRadius = 5;
            books_edit_btn.BorderSize = 0;
            books_edit_btn.FlatAppearance.BorderSize = 0;
            books_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_edit_btn.FlatStyle = FlatStyle.Flat;
            books_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_edit_btn.ForeColor = Color.White;
            books_edit_btn.Location = new Point(186, 312);
            books_edit_btn.Name = "books_edit_btn";
            books_edit_btn.Size = new Size(80, 36);
            books_edit_btn.TabIndex = 21;
            books_edit_btn.TabStop = false;
            books_edit_btn.Text = "Save";
            books_edit_btn.TextColor = Color.White;
            books_edit_btn.UseVisualStyleBackColor = false;
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
            close_btn.Location = new Point(315, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += CloseWindow;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close_btn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 55);
            panel1.TabIndex = 26;
            panel1.MouseDown += EditBook_MouseDown;
            panel1.MouseMove += EditBook_MouseMove;
            panel1.MouseUp += EditBook_MouseUp;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 365);
            Controls.Add(panel1);
            Controls.Add(books_edit_btn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(roundedButton1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RoundedButton roundedButton1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private RoundedButton books_edit_btn;
        private RoundedButton close_btn;
        private Panel panel1;
    }
}