using static System.Console;
Console.WriteLine("Hello, World!");


// Methods
static void Display(string[] info)
{
    if(info.Length > 0)
    {
        for(int index = 0; index < info.Length; index ++)
            WriteLine($"[{index}]  \"{info[index]}");
            // e.g.        [0]           "Text"
    }
    else
        WriteLine("The array is empty.");
}