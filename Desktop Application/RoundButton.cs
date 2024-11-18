using System.Drawing.Drawing2D;

namespace Desktop_Application
{
    class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // https://stackoverflow.com/questions/3708113/round-shaped-buttons
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(path);
            base.OnPaint(e);
        }
    }
}
