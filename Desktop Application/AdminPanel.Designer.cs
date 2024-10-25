namespace Desktop_Application
{
    partial class adminPanel
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
            panel1 = new Panel();
            close_btn = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 77, 180);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(200, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 561);
            panel1.TabIndex = 9;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            close_btn.Location = new Point(952, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(20, 21);
            close_btn.TabIndex = 10;
            close_btn.Text = "X";
            close_btn.Click += CloseWindow;
            // 
            // button1
            // 
            button1.Location = new Point(0, 146);
            button1.Name = "button1";
            button1.Size = new Size(260, 61);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(close_btn);
            Controls.Add(panel1);
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label close_btn;
        private Button button1;
    }
}