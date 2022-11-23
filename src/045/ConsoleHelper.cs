namespace Demo_045;
using static System.Console;

// This is a static class because it only contains "utility" methods.
public static class ConsoleHelper
{
    // Add whatever static console I/O helper methods you might need here
    // But don't put in any throw statements

    /// <summary>Display a message and get the string input from the user</summary>
    public static string Prompt(string message)
    {
        Write($"{message} ");
        return ReadLine();
    }

    /// <summary>Write a line of text filling the screen width and centering the text withing dashed lines.</summary>
    public static void WriteRule(string text)
    {
        text = $" {text} "; // Add a single space padding
        int len = WindowWidth - 1;
        len = len + text.Length;
        text = text.PadLeft(len / 2, '-');
        text = text.PadRight(WindowWidth - 1, '-');
        WriteLine(text);
    }

    /// <summary>A method whose parameter has a default value</summary>
    public static void Pause(ConsoleColor color = ConsoleColor.DarkYellow)
    {
        ForegroundColor = color;
        Write("Press [Enter] to continue...");
        ResetColor();
        ReadLine();
        WriteLine();
    }

}