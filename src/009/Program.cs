// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Simple Decisions");
WriteLine("================\n");

string userInput; // I'll be re-using this in a lot of places
Write("Do you have previous experience with computer programming (y/N)? ");
userInput = ReadLine();
userInput = userInput.ToUpper(); // make it upper case for easier comparisons later on.

// Our prompt indicated that N is a "default" answer if the user just presses [Enter]
if(userInput == "")
    userInput = "N";

string languages;
if(userInput == "Y")
{
    Write("What programming languages do you already know? ");
    languages = ReadLine();
    WriteLine("Soon you will be able to add C# to the list!");
}
else // Here, we are presuming that if userInput isn't "Y", then their answer is some form of "no"...
{
    // ... but be careful of presumptions
    WriteLine("In this course, we are learning C#.");
}

// The following line of code is commented out because there is a path of execution (the else side) where the value for languages is not set.
// WriteLine(languages);
// Q) How could we fix it so that we can use the line above?



