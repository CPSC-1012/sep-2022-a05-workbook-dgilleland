using static System.Console;
using static System.Math;
WriteLine("Potentially Useful Code");
WriteLine("=======================\n");

string shape;
double area;

WriteLine(@"Pick from the following shapes:

    T) Triangle
    S) Square
    R) Rectangle");
// Laziness, thy name is Dan
Write("Choose a shape: ");
shape = ReadLine(); // We'll assume correct user input.
char choice = shape[0]; // Ohhh, a string is just an array of characters!!
choice = char.ToUpper(choice); // make it upper-case
switch(choice)
{
    case 'T':
        // TODO: Get the base and vertical height, then calculate the area
        area = 0.5 * Prompt("Enter the base length") * Prompt("Enter the height of the triangle");
        break;
    case 'S':
        // TODO: Get the side length, then calculate the area
        int length = Prompt("Enter the side length of the square");
        area = length * length;
        break;
    case 'R':
        // TODO: Get the width and height, then calculate the area
        area = Prompt("Enter the width") * Prompt("Enter the height");
        break;
    default:
        area = 0;
        break;
}
if(area == 0)
    WriteLine("\nNo area for the shape");
else
    WriteLine($"Area: {area}");



// Methods:
int Prompt(string message)
{
    Write($"{message}: ");
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
