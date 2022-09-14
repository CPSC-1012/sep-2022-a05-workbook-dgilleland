// declare our variables
double radius, diameter, circumference, area;
// Let's get the diameter from the user
Console.Write("Enter a diameter: ");
string temp; // declare a string for user input
temp = Console.ReadLine(); // get a line of input from the user
diameter = double.Parse(temp); // convert the string to a number
// Radius = Diameter / 2
radius = diameter / 2;
Console.WriteLine($"A circle with that diameter will have a radius of {radius}.");
circumference = Math.PI * diameter;
Console.WriteLine($"The circumference is {circumference}");
// Area = PI x radius^2
