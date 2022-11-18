using static System.Console;

public class ConsoleIO
{
    public static string Prompt(string message)
    {
        Write($"{message}");
        return ReadLine();
    }
}
