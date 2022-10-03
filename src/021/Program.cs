// See https://aka.ms/new-console-template for more information
using static System.Console;

// Main Method body
WriteLine("Simple Looping Math");
WriteLine("===================\n");

double total = 0;
int count = 0;
double value;
do
{
    value = PromptForNumber();
    total += value;
    count++;
}while(value != 0);

// QnD output
WriteLine($"The count is {count} and the total is {total}");

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
