using Desktop_Application.Components;

namespace Desktop_Application.Classes;

internal class CloseThisWindow
{
    private readonly Form _form;

    public CloseThisWindow(Form form, RoundedButton roundedButton)
    {
        _form = form;

        roundedButton.Click += WindowClose;
    }

    public static void Handle(Form form, RoundedButton roundedButton)
    {
        _ = new CloseThisWindow(form, roundedButton);
    }

    public void WindowClose(object sender, EventArgs e)
    {
        _form.Close();
    }
}