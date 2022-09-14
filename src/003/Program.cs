// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Create a program that will calculate the area and the perimeter of a square.
int sideLength; // declare a variable
sideLength = 2; // using a hard-coded value

int area, perimeter; // You can declare more than one variable of a given type
area = sideLength * sideLength;
perimeter = sideLength + sideLength + sideLength + sideLength; // sideLength * 4

// Example of string concatenation
Console.WriteLine("The area of a square with length of " + sideLength + " is " + area);
// Example of string interpolation
Console.WriteLine($"The perimeter of a square with length of {sideLength} is {perimeter}");


