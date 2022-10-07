using static System.Console;
using static System.Math;
WriteLine("Potentially Useful Code");
WriteLine("=======================\n");

string shape;
double area;

WriteLine(@"Pick from the following shapes:

\tT) Triangle
\tS) Square
\tR) Rectangle");
// Laziness, thy name is Dan
Write("Choose a shape: ");
shape = ReadLine(); // We'll assume correct user input.
char choice = shape[0]; // Ohhh, a string is just an array of characters!!
choice = char.ToUpper(choice); // make it upper-case
switch(choice)
{
    case 'T':
        // TODO: Get the base and vertical height, then calculate the area
        break;
    case 'S':
        // TODO: Get the side length, then calculate the area
        break;
    case 'R':
        // TODO: Get the width and height, then calculate the area
        break;
    default:
        area = 0;
        break;
}

// Methods:
int Prompt(string message)
{
    Write(message);
    string userInput = ReadLine();
    int result;
    while(!int.TryParse(userInput, out result))
    {
        WriteLine("\tThat is not a whole number.");
        Write(message);
        userInput = ReadLine();
    }
    return result;
}
