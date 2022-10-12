using static System.Console;

Clear(); // Start with a clean terminal
WriteLine("Simple Grid");
WriteLine("\n\tA Box");
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
WriteLine("\n\tBack-slash");
// TODO:
WriteLine("\n\tForward-slash");
// TODO:
