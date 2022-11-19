// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Formatting!");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Black;
// The variable args is an array of strings, holding information that is passed into the program
// To try it out yourself, enter the following in a terminal inside this folder:
// dotnet run Arrays are one of the first "data structures"
Console.WriteLine($"There are {args.Length} values passed into this program.");
Console.ResetColor();

// Arrays
// The following two arrays demonstrate the concepts of
// - Array Initialization (by populating the array while declaring an array variable)
// - Corresponding Arrays - two or more separate arrays where the information in one array relates to information in another array at the same position of the first array
string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };  // 7 names
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };                              // 7 hours

Console.WriteLine($"\t{"Name",-20} {"Hours",5}\n");
for (int position = 0; position < names.Length; position++)
    Console.WriteLine($"\t{names[position],-20} {hours[position],5:N1}");

// Use the information in an array to perform a calculation
decimal total = 0, average;
for (int index = 0; index < hours.Length; index++)
    total += hours[index];
average = total / hours.Length;
Console.WriteLine($"The average hours is {Math.Round(average, 1)}");
