using static System.Console;

Clear(); // Start with a clean terminal
WriteLine("Simple Grid");

for(int row = 0; row < 5; row++)
{
    for(int column = 0; column < 5; column++)
    {
        if(row == 0 || row == 4 || column == 0 || column == 4)
            Write("X");
        else
            Write(".");
    }
    WriteLine(); // blank line
}
