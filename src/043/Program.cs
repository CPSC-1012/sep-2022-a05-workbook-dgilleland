using static System.Console;
Clear();
WriteLine("Assorted Useful Things...\n");
WriteLine("=========================");

// Make use of my generic class Labeled Item
string fullName = "Dan Gilleland";
int yearsExperience = 40;
decimal salary = 110000m;
double savings = 10.95;
bool isMarried = true;

LabeledItem<string> displayName = new LabeledItem<string>("Full name", fullName);
LabeledItem<int> displayYears = new LabeledItem<int>("Years coding", yearsExperience);
WriteLine(displayName);
WriteLine(displayYears);
// The var keyword can be used when you initialize a variable as you declare it.
var displaySalary = new LabeledItem<decimal>("Yearly Salary", salary);
// Any idea what the nameof() function will do below??
var cashOnHand = new LabeledItem<double>(nameof(savings), savings);
LabeledItem<bool> maritalStatus = new("Happy", isMarried);
WriteLine(displaySalary);
WriteLine(cashOnHand);
WriteLine(maritalStatus);

WriteLine("=========================");
string[] languages = new string[] {"C#", "SQL", "HTML", "JavaScript", "CSS"};
// Traditional for loop to go through the array
for(int index = 0; index < languages.Length; index++)
{
    // Using a simple variable to reference one of the items in the array
    string programmingLanguage = languages[index];
    // do something with it...
    WriteLine($"I know {programmingLanguage.ToLower()}.");
}
// Looping using the foreach statement
foreach(string programmingLanguage in languages)
{
    // Each time through the loop, the value of programmingLanguage
    // will be the next string in the languages array
    // I can do whatever I want with that item in the array
    // (except replace that item with some other value)
    string inReverse = new string(programmingLanguage.Reverse().ToArray());
    WriteLine($"I know {inReverse} backwards!");
}
