// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Fibonacci");
WriteLine("=========\n");

int position = PromptForIndexPosition();


// Methods
static int PromptForIndexPosition()
{
    int position;
    Write("How many positions in the sequence? ");
    while(!int.TryParse(ReadLine(), out position) && position <= 0)
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("Invalid position! Must be 1 or greater.");
        ResetColor();
        Write("How many positions in the sequence? ");
    }
    return position;
}
