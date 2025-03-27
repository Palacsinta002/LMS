namespace Desktop_Application.Classes;

class GeneratePassword
{
    internal static string Generate(string chars, int length)
    {
        Random random = new();
        string randomPassword = "";
        while (0 < length--)
        {
            randomPassword += chars[random.Next(chars.Length)];
        }
        return randomPassword;
    }
}