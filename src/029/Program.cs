using static System.Console;
Clear();
WriteLine("Learn Math\n");

for(int row = 1; row <= 5; row++)
{
    for(int column = 1; column <=5; column++)
    {
        int product = row * column;
        string text = product.ToString(); // convert the number to a string
        text = text.PadLeft(4);
        Write(text);
    }
    WriteLine();
}
