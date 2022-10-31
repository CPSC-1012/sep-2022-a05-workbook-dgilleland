using static System.Console;
Console.WriteLine("This is what was passed in:");
Display(args); // our string[] args


// Methods
static void Display(string[] info)
{
    if(info.Length > 0)
    {
        for(int index = 0; index < info.Length; index ++)
            WriteLine($"[{index}]  \"{info[index]}\"");
            // e.g.        [0]           "Text"
    }
    else
        WriteLine("The array is empty.");
}
