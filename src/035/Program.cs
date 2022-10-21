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

