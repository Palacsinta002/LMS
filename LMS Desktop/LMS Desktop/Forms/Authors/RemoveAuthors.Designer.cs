﻿namespace Desktop_Application.Forms.Authors
{
    partial class RemoveAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAuthors));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            label_title = new Label();
            yes = new Desktop_Application.Components.RoundedButton();
            no = new Desktop_Application.Components.RoundedButton();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(361, 55);
            header.TabIndex = 27;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(82, 12);
            title.Name = "title";
            title.Size = new Size(170, 30);
            title.TabIndex = 2;
            title.Text = "Remove Author";
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
            close_btn.Location = new Point(315, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            label_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_title.Location = new Point(12, 73);
            label_title.Name = "label_title";
            label_title.Size = new Size(339, 103);
            label_title.TabIndex = 28;
            label_title.Text = "Are you sure you want to remove the selected authors? All related books, borrowings and reservations will be also removed!";
            // 
            // yes
            // 
            yes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            yes.BackColor = Color.WhiteSmoke;
            yes.BackgroundColor = Color.WhiteSmoke;
            yes.BorderColor = Color.FromArgb(80, 77, 180);
            yes.BorderRadius = 5;
            yes.BorderSize = 2;
            yes.FlatAppearance.BorderSize = 0;
            yes.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            yes.FlatStyle = FlatStyle.Flat;
            yes.Font = new Font("Yu Gothic UI Semibold", 14F);
            yes.ForeColor = Color.Black;
            yes.Location = new Point(179, 183);
            yes.Name = "yes";
            yes.Size = new Size(80, 36);
            yes.TabIndex = 30;
            yes.TabStop = false;
            yes.Text = "Yes";
            yes.TextColor = Color.Black;
            yes.UseVisualStyleBackColor = false;
            yes.Click += Remove;
            // 
            // no
            // 
            no.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            no.BackColor = Color.FromArgb(80, 77, 180);
            no.BackgroundColor = Color.FromArgb(80, 77, 180);
            no.BorderColor = Color.Transparent;
            no.BorderRadius = 5;
            no.BorderSize = 0;
            no.FlatAppearance.BorderSize = 0;
            no.FlatStyle = FlatStyle.Flat;
            no.Font = new Font("Yu Gothic UI Semibold", 14F);
            no.ForeColor = Color.White;
            no.Location = new Point(265, 183);
            no.Name = "no";
            no.Size = new Size(80, 36);
            no.TabIndex = 29;
            no.TabStop = false;
            no.Text = "No";
            no.TextColor = Color.White;
            no.UseVisualStyleBackColor = false;
            // 
            // RemoveAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 231);
            Controls.Add(yes);
            Controls.Add(no);
            Controls.Add(label_title);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RemoveAuthors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveBookConfirmation";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private Label label_title;
        private Components.RoundedButton yes;
        private Components.RoundedButton no;
    }
}