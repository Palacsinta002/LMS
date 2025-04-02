namespace Desktop_Application.Classes;

class HandleKeys
{
    private readonly Form _form;
    private readonly Keys[] _keys;
    private readonly Action<object, EventArgs> _function;

    public HandleKeys(Form form, Keys[] keys, Action<object, EventArgs> function)
    {
        _form = form;
        _keys = keys;
        _function = function;

        _form.KeyDown += RunFunction;
    }

    public static void Handle(Form form, Keys key, Action<object, EventArgs> function)
    {
        _ = new HandleKeys(form, [key], function);
    }

    public static void Handle(Form form, Keys[] keys, Action<object, EventArgs> function)
    {
        _ = new HandleKeys(form, keys, function);
    }

    private void RunFunction(object sender, KeyEventArgs e)
    {
        foreach (Keys key in _keys)
        {
            if (key == e.KeyCode) _function(sender, e);
        }
    }
}