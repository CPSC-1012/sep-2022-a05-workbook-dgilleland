using static System.Console;
Clear();
WriteLine("Assorted Useful Things...\n");

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
    WriteLine($"I know {programmingLanguage.Reverse()} backwards!");
}
