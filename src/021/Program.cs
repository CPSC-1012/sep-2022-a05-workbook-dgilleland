// See https://aka.ms/new-console-template for more information
using static System.Console;
WriteLine("Simple Looping Math");
WriteLine("===================\n");

// Methods
static double PromptForNumber()
{
    // With simple validation
    Write("Enter a number (leave empty to finish): ");
    double result;
    string userInput = ReadLine();
    while(!double.TryParse(userInput, out result) && !string.IsNullOrEmpty(userInput))
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine($"The value {userInput} is not a number. Try again.");
        ResetColor();
        Write("Enter a number: ");
        userInput = ReadLine();
    }
    return result;
}
