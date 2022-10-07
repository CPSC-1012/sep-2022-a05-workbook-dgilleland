// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Formatting!");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine($"There are {args.Length} values passed into this program.");
Console.ResetColor();

// Arrays
string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };

Console.WriteLine($"\t{"Name",-20} {"Hours",5}\n");
for (int ctr = 0; ctr < names.Length; ctr++)
    Console.WriteLine($"\t{names[ctr],-20} {hours[ctr],5:N1}");
