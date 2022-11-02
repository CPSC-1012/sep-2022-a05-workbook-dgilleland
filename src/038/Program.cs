using static System.Console;
using static System.ConsoleColor;
using System.IO;

Clear();
WriteLine("Going Meta!");

Write("\nEnter A to read the text as a single string, any other key to read the lines one by one.\n");
if(ReadLine().ToUpper() == "A")
{
    string allLines = File.ReadAllText("Program.cs");
    Display(allLines.Split(Environment.NewLine));
}
else
{
    Display(File.ReadAllLines("Program.cs"));
}
WriteLine();

void Display(string[] lines)
{
    int maxWidth = WindowWidth;
    BackgroundColor = DarkGreen;
    ForegroundColor = Black;
    foreach(var line in lines)
        WriteLine(line.PadRight(maxWidth - 1));
    ResetColor();
}