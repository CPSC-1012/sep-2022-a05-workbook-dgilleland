// See https://aka.ms/new-console-template for more information
using static System.Console;

// Let's make some constants
const int FINISHED = 0;
const int BAD_MENU_CHOICE = 1;
const int NUMBER_TOO_LOW = 2;
const int NUMBER_TOO_HIGH = 3;
const int NOT_A_NUMBER = 4;

WriteLine("===================");
int torpedoCount = 10;
bool hitTarget;
// Let's play with if statements
WriteLine("\nSubmarine Game\n");
WriteLine("A) Launch a torpedo");
WriteLine("B) Launch more than one torpedo");
WriteLine("C) Run and hide");

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

switch(userInput)
{
    case "A":
        count = 1;
        torpedoCount--;
        break;
    case "B":
        Write("How many torpeodoes (max 10)? ");
        count = int.Parse(ReadLine());
        //                \   1st  /
        //      \       2nd       /
        //   <== \      3rd      /
        if(count < 1)
        {
            Error.WriteLine($"You cannot fire {count} torpedoes - pick a number above zero");
            return NUMBER_TOO_LOW;
        }
        if(count > torpedoCount)
        {
            Error.WriteLine($"Not enought torpedoes - cannot fire {count} torpedoes");
            return NUMBER_TOO_HIGH;
        }

        torpedoCount -= count;
        break;
    case "C":
        Write("\n\tDIVE, DIVE, DIVE");
        count = 0;
        break;
    default:
        // Tell the user about the problem
        Error.WriteLine($"\"{userInput}\" is not a valid menu choice");
        // Exit my program (because I haven't learned loops yet to get a better input)
        return BAD_MENU_CHOICE;
}
if(rnd.Next(1, 11) > chance - count)
    WriteLine("\tYou scored a HIT!");
else
    WriteLine("\tToo bad. Now they are hunting for you....");

WriteLine($"\n+++++++++\n{torpedoCount} torpedoes left");

return FINISHED;