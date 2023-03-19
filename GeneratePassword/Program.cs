namespace GeneratePassword;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var password = new PasswordGenerator()
            .Generate();

        Clipboard.SetText(password);
    }

    // Uncommment for tests
    //public static void Main()
    //{
    //    var passwordGenerator = new PasswordGenerator();

    //    for (var i = 0; i < 20; i++)
    //        Console.WriteLine(passwordGenerator.Generate());
    //}
}
