// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Math;
double tuition = 5500;
// string interpolation for my output
WriteLine($"Basic tuition is {tuition:C}"); // format the tuition as Currency

// Demo some basic data types.
int torpedoCount = 10;
char status = 'a'; // for "Armed"
bool hitTarget;
int statusValue = status; //btw, don't do this - treating chars as ints is poor programming....
WriteLine($"The value of {status} is {statusValue}");

