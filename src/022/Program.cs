// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Fibonacci");
WriteLine("=========\n");

int position = PromptForIndexPosition();
WriteLine($"Position: {position}"); // QnD

// Display sequence
int current = 1, previous = 1, beforePrevious = 0;
Write($"{current}, ");
if(position > 1)
{
    Write($"{current}, ");
    for (int counter = 3; counter <= position; counter++)
    {
        beforePrevious = previous;
        previous = current;
        current = beforePrevious + previous;
        Write($"{current}, ");
    }
}

// Methods
static int PromptForIndexPosition()
{
    int position;
    Write("How many positions in the sequence? ");
    while(!int.TryParse(ReadLine(), out position) || position <= 0)
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("Invalid position! Must be 1 or greater.");
        ResetColor();
        Write("How many positions in the sequence? ");
    }
    return position;
}
