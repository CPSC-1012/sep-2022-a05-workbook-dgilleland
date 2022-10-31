using static System.Console;
WriteLine("This is what was passed in:");
Display(args); // our string[] args
WriteLine();
Write("Tell me a story! ");
string story = ReadLine();
string[] words = story.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Display(words);

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
