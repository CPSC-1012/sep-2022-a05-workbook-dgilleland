using static System.Console;

WriteLine("Exploring...");
int width = WindowWidth;
int height = WindowHeight;
WriteLine($"The window's size is {width} characters wide and {height} characters tall.");
Write("The cursor's position is ");
var position = GetCursorPosition();
WriteLine(position);
Write("Press [enter] to continue.");
ReadLine(); // get the user input and toss it away...
Clear(); // Clear the screen
position = GetCursorPosition();
WriteLine($"The position is now {position}.");
SetCursorPosition(7, 2);
BackgroundColor = ConsoleColor.Gray;
ForegroundColor = ConsoleColor.DarkGreen;
Write("Where is this text??");
ResetColor();

WriteLine($" Cursor visible: {CursorVisible}");

ForegroundColor = ConsoleColor.DarkYellow;
Write("Press [enter] to finish the program.");
ResetColor();
ReadLine();