namespace Library_Management_System.Classes
{
    internal class BorderPaint
    {
        private readonly Form _form;

        public BorderPaint(Form form)
        {
            _form = form;

            form.Paint += Border_Paint;
        }

        public static void Handle(Form form)
        {
            _ = new BorderPaint(form);
        }

        public void Border_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, _form.Width - 1, _form.Height - 1));
        }
    }
}
