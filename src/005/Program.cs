/*
    Problem Statement:
        Given the radius and height of a cylinder (supplied by the user), calculate the volume and the surface area.
*/

Console.WriteLine("Cylinder Calculations");

// First, let's declare our variables
string temp;
double radius, height, volume, surfaceArea;

// Next, get the radius and the height from the user
Console.Write("Enter the radius: ");
temp = Console.ReadLine();
radius = double.Parse(temp);
Console.Write("Enter the height: ");
temp = Console.ReadLine();
height = double.Parse(temp);

// Calculate the other values
volume = Math.PI * radius * radius * height;
surfaceArea = 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;

// Output the results
Console.WriteLine($"The volume is {volume}.");
Console.WriteLine($"The surface area is {surfaceArea}.");
