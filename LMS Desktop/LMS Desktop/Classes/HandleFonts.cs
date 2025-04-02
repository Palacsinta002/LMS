namespace Desktop_Application.Classes;

class HandleFonts
{
    internal static void Set(Control control)
    {
        foreach (Control childControl in control.Controls)
        {
            Font currentFont = childControl.Font;
            Font newFont = new("Segoe UI Semibold", currentFont.Size);
            childControl.Font = newFont;
            // If it has a childern it will recursively call itself
            if (childControl.HasChildren)
            {
                Set(childControl);
            }
        }
    }
}