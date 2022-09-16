/*
    Problem Statement:
        Given the radius and height of a cylinder (supplied by the user), calculate the volume and the surface area.
*/
using static System.Console;

WriteLine("I learned about Omnisharp and Intellisense");
WriteLine(); // This displays a blank line
WriteLine("Cylinder Calculations");

// First, let's declare our variables
string temp;
double radius, height, volume, surfaceArea;

// Next, get the radius and the height from the user
Write("Enter the radius: ");
temp = ReadLine();
radius = double.Parse(temp);
Write("Enter the height: ");
temp = ReadLine();
height = double.Parse(temp);

// Calculate the other values
volume = Math.PI * radius * radius * height;
surfaceArea = 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;

// Output the results
WriteLine($"The volume is {volume}.");
WriteLine($"The surface area is {surfaceArea}.");
