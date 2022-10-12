using static System.Console;

Clear(); // Start with a clean terminal
WriteLine("Simple Grid");
WriteLine("\n\tA Box\n");
int maxColumn = 10, maxRow = 5;
for(int row = 0; row < maxRow; row++)
{
    for(int column = 0; column < maxColumn; column++)
    {
        if(row == 0    || row == maxRow - 1       || 
           column == 0 || column == maxColumn - 1)
            Write("X");
        else
            Write(" ");
    }
    WriteLine(); // blank line
}
WriteLine("\n\tBack-slash\n");
for(int row = 0; row < maxRow; row++)
{
    for(int column = 0; column < maxColumn; column++)
    {
        if(row == column)
            Write("X");
        else
            Write(" ");
    }
    WriteLine(); // blank line
}
WriteLine("\n\tForward-slash\n");
// TODO:
WriteLine("Available in the pro version for a low price of $5.95");