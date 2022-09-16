using static System.Console;
using static System.Math;

Console.WriteLine("Calculate a Quadratic Equation");

// 0) Declare variables
int a, b, c; // I can declare multiple variables
double upperValue, lowerValue;
string userInput;

// 1) Prompt for a
Write("Enter the value for a: ");
userInput = ReadLine();
a = int.Parse(userInput);

// 2) Prompt for b
Write("Enter the value for b: ");
userInput = ReadLine();
b = int.Parse(userInput);

// 3) Prompt for c
Write("Enter the value for c: ");
userInput = ReadLine();
c = int.Parse(userInput);

// 4) Calculate the upper value
upperValue = (-b + Sqrt(b * b - 4 * a * c)) / (2 * a);

// 5) Calculate the lower value
lowerValue = (-b - Sqrt(b * b - 4 * a * c)) / (2 * a);

// 6) Display the results
// rounding
upperValue = Round(upperValue, 5);
lowerValue = Round(lowerValue, 5);


WriteLine($"The upper value is {upperValue} and the lower value is {lowerValue}");
