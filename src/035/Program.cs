// See https://aka.ms/new-console-template for more information
using static System.Console; // Use the static members of the Console class
                             // without having to write Console.  every time

WriteLine("Hello, World!");
WriteLine("Let's build a room.");

Rectangle backWall, leftWall, rightWall, frontWall;
backWall = new(); // implicit
backWall.Height = 5;
backWall.Width = 10;

frontWall = new Rectangle(); // explicit
frontWall.Height = 5;
frontWall.Width = 20;

int paintableArea = backWall.Area
                  + frontWall.Area;
Rectangle door = new();
door.Height = 3;
door.Width = 1;
paintableArea = paintableArea - door.Area;

WriteLine($"My front and back walls take up {paintableArea} square meters, because I have a door.");

