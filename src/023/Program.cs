using static System.Console;
WriteLine("Factorial");
// Get the user to enter a number
string promptMessage = "Enter a positive whole number to find the factorial of that number: ";
Write(promptMessage);
string temp = ReadLine();
int number;
while(!int.TryParse(temp, out number) || number <= 0)
{
    // Reprompt
    WriteLine("That was not a positive whole number. Try again");
    Write(promptMessage);
    temp = ReadLine();
}

// Calculate the factorial
int result = 1;
for(int count = 1; count <= number; count++)
    result = result * count;

WriteLine($"The result of {number}! is {result}");
WriteLine($"By the way, the maximum integer value is {int.MaxValue}");