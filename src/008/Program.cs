// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Math;
// double tuition = 5500;
// // string interpolation for my output
// WriteLine($"Basic tuition is {tuition:C}"); // format the tuition as Currency

// Demo some basic data types.
// char status = 'a'; // for "Armed"
// int statusValue = status; //btw, don't do this - treating chars as ints is poor programming....
// WriteLine($"The value of {status} is {statusValue}");

// // Integer division
// int firstNumber = 5, secondNumber = 3;
// WriteLine($" 5 / 3 is {firstNumber / secondNumber}"); // Notice the expression
// WriteLine($" 5 % 3 is {firstNumber % secondNumber}"); // Modulus

// firstNumber = firstNumber + 7; // Can you predict the result??
// WriteLine($"The new value for firstNumber is {firstNumber}");
// firstNumber += 9 * 2 + 1; // Can you predict the result??
// WriteLine($"Now the value of firstNumber is {firstNumber}");
// secondNumber++; // Increment the value of secondNumber by 1
// WriteLine($"The value of secondNumber is {secondNumber}");
// WriteLine($"What happens with post-fix increment? {secondNumber++}");
// WriteLine($"But the value actually is {secondNumber}");
// WriteLine($"Using prefix notation: {++secondNumber}");


WriteLine("===================");
int torpedoCount = 10;
bool hitTarget;
// Let's play with if statements
WriteLine("\nSubmarine Game\n");
WriteLine("A) Launch a torpedo");
WriteLine("B) Launch more than one torpedo");
Write("\n\tSelect an option: ");
string userInput = ReadLine().ToUpper();
//                 \ string /
//                  \  "a"   .ToUpper() /
//                   \      string     /
//                    \      "A"      /
//     userInput <= store a string
int chance = 10;
int count;
Random rnd = new Random(); // let's add some randomness to our program.. :)
if(userInput == "A")
{
    count = 1;
    torpedoCount--;
}
else // We are assuming the user entered "B"
{
    Write("How many torpeodoes (max 10)? ");
    count = int.Parse(ReadLine());
    //                \   1st  /
    //      \       2nd       /
    //   <== \      3rd      /
}


WriteLine($"\n+++++++++\n{torpedoCount} torpedoes left");

