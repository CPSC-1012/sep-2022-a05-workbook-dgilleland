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
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.DarkRed;
    WriteLine($"You cannot set sail! You are missing {crewCount - minCrewCount} sailors!");
    ResetColor();
}

// ---- The following are reusable methods ---
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
