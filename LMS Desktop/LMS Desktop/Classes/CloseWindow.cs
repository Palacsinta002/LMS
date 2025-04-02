using Desktop_Application.Components;

namespace Desktop_Application.Classes;

internal class CloseWindow
{
    private readonly Form _form;

    public CloseWindow(Form form, RoundedButton roundedButton)
    {
        _form = form;

        roundedButton.Click += WindowClose;
    }

    public static void Handle(Form form, RoundedButton roundedButton)
    {
        _ = new CloseWindow(form, roundedButton);
    }

    public void WindowClose(object sender, EventArgs e)
    {
        _form.Close();
    }
}