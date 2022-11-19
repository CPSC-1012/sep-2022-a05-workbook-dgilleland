using static System.Console;

// 0) Title Screen
Title = "Array Snippets in C#";
Clear();
WriteLine(string.Empty.PadLeft(WindowWidth - 1, '='));
WriteRule("Array Snippets");
WriteLine(string.Empty.PadLeft(WindowWidth - 1, '='));
Pause();

/* **************************************** */

#region 1) Exploring the args variable
WriteRule("string[] args");
ForegroundColor = ConsoleColor.Cyan;
BackgroundColor = ConsoleColor.Black;
// The variable args is an array of strings, holding information that is passed into the program
// To try it out yourself, enter the following in a terminal inside this folder:
// dotnet run Arrays are one of the first "data structures"
WriteLine($"There are {args.Length} values passed into this program.");
ForegroundColor = ConsoleColor.Green;
WriteLine("Try the following code:\ndotnet run Arrays are one of the first \"data structures\"");
ResetColor();
Pause();
#endregion /* **************************************** */

#region 2) Array Initialization
WriteRule("Formatting a Tabular Result");
// The following two arrays demonstrate the concepts of
// - Array Initialization (by populating the array while declaring an array variable)
// - Corresponding Arrays - two or more separate arrays where the information in one array relates to information in another array at the same position of the first array
string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };  // 7 names
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };                              // 7 hours

WriteLine($"\t{"Name",-20} {"Hours",5}\n");
for (int position = 0; position < names.Length; position++)
    WriteLine($"\t{names[position],-20} {hours[position],5:N1}"); // Note the left/right alignment numbers

// Use the information in an array to perform a calculation
decimal total = 0, average;
for (int index = 0; index < hours.Length; index++)
    total += hours[index];
average = total / hours.Length;
WriteLine($"The average hours is {Math.Round(average, 1)}");
Pause();
#endregion /* **************************************** */

#region 3) Using the .Split() method of strings.
WriteRule("File/Folder Paths on Your Computer");
// List the various paths (in order) from the system
string[] filePaths = Environment.GetEnvironmentVariable("Path").Split(";"); // first set is System values, second set is User values
string description = @"\\_System Paths_//";
WriteLine(description);

for(int subscript = 0; subscript < filePaths.Length;subscript++)
{
    description = filePaths[subscript];
    if(string.IsNullOrWhiteSpace(description))
    {
        Pause(ConsoleColor.White);
        description = @"\\_User Paths_//";
    }
    WriteLine(description);
}
Pause();
#endregion /* **************************************** */

#region 4) Array Limits
WriteRule("Array Limits");
string[] words = new string[5];
int logicalSize = 0;
string input;
do
{
    input = Prompt($"{logicalSize}) Enter a word (blank to stop):");
    if(!string.IsNullOrWhiteSpace(input))
    {
        words[logicalSize] = input; // logicalSize is also the next available slot in the array
        logicalSize++;
    }
}while(logicalSize < words.Length && !string.IsNullOrWhiteSpace(input));

if(logicalSize == words.Length)
    WriteLine("You've entered as many words as the array allows");
else
    WriteLine($"You've entered {logicalSize} words.");
input = string.Join(", ", words); // assemble the array into a single string, comma delimited
WriteLine($"Here's what you entered: [{input}]");
input = Prompt("Do you want to try entering another item in the array (y/N)? ");
if(input.ToLower().StartsWith("y"))
{
    // This will cause the program to crash....
    input = Prompt("Enter another word and I'll try to put it in the array:");
    words[logicalSize] = input;
    input = string.Join(", ", words); // assemble the array into a single string, comma delimited
    WriteLine($"Here's the new contents of the array (as a joined string): [{input}]");
}
#endregion /* **************************************** */


#region Utility Methods
/* ================ Methods ==================== */
// Write a line of text filling the screen width and centering the text withing dashed lines.
void WriteRule(string text)
{
    text = $" {text} "; // Add a single space padding
    int len = WindowWidth - 1;
    len = len + text.Length;
    text = text.PadLeft(len / 2, '-');
    text = text.PadRight(WindowWidth - 1, '-');
    WriteLine(text);
}
// A method whose parameter has a default value
void Pause(ConsoleColor color = ConsoleColor.DarkYellow)
{
    ForegroundColor = color;
    Write("Press [Enter] to continue...");
    ResetColor();
    ReadLine();
    WriteLine();
}
string Prompt(string message)
{
    Write($"{message} ");
    return ReadLine();
}
#endregion
