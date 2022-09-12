// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello my students!");
int age;    // A variable declaration statement
age = 23;   // An assignment statement
Console.WriteLine(age); // Write the value stored in age onto the console window
Console.WriteLine("I remember when I was " + age); // String Concatenation

// Let's talk to the user.
Console.WriteLine();    // With nothing sent into the WriteLine() method, it just makes a blank line
Console.Write("What is your name? ");   // The Write() method does not produce a "new line"
string name;    // Declare a variable
name = Console.ReadLine();  // Get input from the user (who must press [ENTER]) and store it in name
Console.WriteLine("Hello " + name);

