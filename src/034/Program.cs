using static System.Console;
WriteLine("This is what was passed in:");
Display(args); // our string[] args
WriteLine();
Write("Tell me a story! ");
string story = ReadLine();
string[] words = story.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Display(words);

string[] someWords = {}; // Here I have initialized an empty array
Display(someWords);
someWords = new string[] {"To", "be", "or", "not", "2 bee"};
// When I declare a string array with a set { } of values, the physical size will match the number of items in the set.
Display(someWords);

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
