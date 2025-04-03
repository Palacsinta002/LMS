using Desktop_Application.Forms.Books;
using Desktop_Application.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Reservations
{
    partial class LendReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendReservation));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            label5 = new Label();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            comboBox_dueDate = new System.Windows.Forms.ComboBox();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(383, 55);
            header.TabIndex = 61;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(127, 11);
            title.Name = "title";
            title.Size = new Size(119, 30);
            title.TabIndex = 2;
            title.Text = "Lend book";
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
            close_btn.Location = new Point(336, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 14F);
            label5.Location = new Point(12, 72);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 68;
            label5.Text = "Due Time";
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
            save.Location = new Point(105, 119);
            save.Name = "save";
            save.Size = new Size(85, 36);
            save.TabIndex = 81;
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
            cancel.Location = new Point(195, 119);
            cancel.Name = "cancel";
            cancel.Size = new Size(85, 36);
            cancel.TabIndex = 82;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // comboBox_dueDate
            // 
            comboBox_dueDate.BackColor = Color.WhiteSmoke;
            comboBox_dueDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_dueDate.Font = new Font("Yu Gothic UI Semibold", 14F);
            comboBox_dueDate.FormattingEnabled = true;
            comboBox_dueDate.Items.AddRange(new object[] { "1 Month", "2 Months", "3 Months", "6 Months" });
            comboBox_dueDate.Location = new Point(112, 69);
            comboBox_dueDate.MaxDropDownItems = 10;
            comboBox_dueDate.Name = "comboBox_dueDate";
            comboBox_dueDate.Size = new Size(256, 33);
            comboBox_dueDate.TabIndex = 83;
            // 
            // LendReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(385, 165);
            Controls.Add(comboBox_dueDate);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(label5);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LendReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBorrowing";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private Label label5;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
        private System.Windows.Forms.ComboBox comboBox_dueDate;
    }
}