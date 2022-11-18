using static System.Console;

public class ConsoleIO
{
    public static string Prompt(string message)
    {
        Write($"{message} ");
        return ReadLine();
    }

    public static void WriteRule(string text)
    {
        int len = WindowWidth - 1;
        text = $" {text} ";
        text = text.PadLeft(len / 2, '-');
        text = text.PadRight(len, '-');
        WriteLine(text);
    }
}
