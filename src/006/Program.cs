/*
    Problem Statement:
        Given the radius and height of a cone (supplied by the user), calculate the volume and the surface area.
*/

Console.WriteLine("Cone Calculations");

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
volume = 1 / 3.0 * Math.PI * radius * radius * height;
surfaceArea = Math.PI * radius * (radius + Math.Sqrt( height * height + radius * radius));

// Output the results
Console.WriteLine($"The volume is {volume}.");
Console.WriteLine($"The surface area is {surfaceArea}.");
