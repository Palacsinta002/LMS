namespace Desktop_Application.Classes;

class HandleKeys
{
    private readonly Form _form;
    private readonly Keys _key;
    private readonly Action<object, EventArgs> _function;

    public HandleKeys(Form form, Keys key, Action<object, EventArgs> function)
    {
        _form = form;
        _key = key;
        _function = function;

        _form.KeyDown += RunFunction;
    }

    public static void Handle(Form form, Keys key, Action<object, EventArgs> function)
    {
        _ = new HandleKeys(form, key, function);
    }

    private void RunFunction(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == _key) _function(sender, e);
    }
}