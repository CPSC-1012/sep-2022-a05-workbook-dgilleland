using static System.Console;
Clear();
WriteLine("Learn Math\n");
Write("   *");
for(int column = 1; column <= 5; column++)
    WriteColor(column);
WriteLine();
for(int row = 1; row <= 5; row++)
{
    WriteColor(row);
    for(int column = 1; column <=5; column++)
    {
        int product = row * column;
        string text = product.ToString(); // convert the number to a string
        text = text.PadLeft(4);
        Write(text);
    }
    WriteLine();
}

void WriteColor(int number)
{
    ForegroundColor = ConsoleColor.DarkCyan;
    string text = number.ToString().PadLeft(4);
    Write(text);
    ResetColor();
}