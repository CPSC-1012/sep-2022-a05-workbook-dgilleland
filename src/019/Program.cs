using static System.Console;

string crewPrompt = "How many people on this submarine? ";
int crewCount = PromptInt(crewPrompt); // this will call/use the method
int torpedoCount = PromptInt("How many torpedoes to load? ");
crewPrompt = "What is the minimum number of crew to man this vessel? ";
int minCrewCount = PromptInt(crewPrompt);

if(minCrewCount <= crewCount)
{
    ForegroundColor = ConsoleColor.DarkGreen;
    WriteLine($"You can sail with {crewCount} crew and {torpedoCount} torpedoes.");
    double longitude = PromptDouble("Enter the destination longitude: ");
    double latitude = PromptDouble("Enter the destination latitude: ");
    WriteLine($"\nSetting sail for");
    // Every object has a .ToString() method that converts its content to text
    WriteLabel("\tLatitude:  ", latitude.ToString());
    WriteLabel("\tLongitude: ", longitude.ToString());
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.DarkRed;
    WriteLine($"You cannot set sail! You are missing {crewCount - minCrewCount} sailors!");
    ResetColor();
}

// ---- The following are reusable methods ---
static void WriteLabel(string label, string value)
{
    ForegroundColor = ConsoleColor.Cyan;
    Write(label);
    ForegroundColor = ConsoleColor.DarkYellow;
    WriteLine(value);
    ResetColor();
}

static int PromptInt(string message)
{
    // these are the steps that will execute/run when the method is called
    // Asking the user for a number
    string userInput;
    int value;
    // Prompt
    Write(message);
    userInput = ReadLine();
    // Now we want to validate the input
    while(! int.TryParse(userInput, out value))
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("\tThat is  not a whole number. Try again.");
        ResetColor();
        Write(message);
        userInput = ReadLine();
    }
    return value;
}

static double PromptDouble(string message)
{
    // these are the steps that will execute/run when the method is called
    // Asking the user for a number
    string userInput;
    double value;
    // Prompt
    Write(message);
    userInput = ReadLine();
    // Now we want to validate the input
    while(! double.TryParse(userInput, out value))
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("\tThat is not a real number. Try again.");
        ResetColor();
        Write(message);
        userInput = ReadLine();
    }
    return value;
}
