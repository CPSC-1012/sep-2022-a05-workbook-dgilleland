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

// Let's do some collecting of numbers from the user
int[] numbers = new int[10]; // Make an array of 10 integers
int logicalSize = 0; // There are zero "valid" numbers in the array
while(logicalSize < numbers.Length) // while there is room in the array....
{
    numbers[logicalSize] = PromptWholeNumber();
    logicalSize++;
}

int sum = 0;
for(int subscript = 0; subscript < logicalSize; subscript ++)
    sum += numbers[subscript];
WriteLine($"The total is {sum}.");


// Methods
static int PromptWholeNumber()
{
    int value;
    Write("Enter a whole number: ");
    while(!int.TryParse(ReadLine(), out value))
        Write(" Try again: \nEnter a whole number: ");
    return value;
}

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
