using static System.Console;
WriteLine("Factorial");
// Get the user to enter a number
string promptMessage = "Enter a positive whole number to find the factorial of that number: ";
Write(promptMessage);
string temp = ReadLine();
int number;
if(!int.TryParse(temp, out number) || number <= 0)
{
    // Reprompt
    WriteLine("That was not a positive whole number. Try again");
    Write(promptMessage);
    temp = ReadLine();
}

// Calculate the factorial

