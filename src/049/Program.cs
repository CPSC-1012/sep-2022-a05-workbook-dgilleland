using static System.Console;

WriteLine("Hello, World!".Quack());

string command = "Fetch!";

WriteLine(command.Quack(5));

// Source: https://dzone.com/articles/best-programming-jokes-amp-quotes
string insight = "Code is like humor. When you have to explain it, it's bad.";
string author = "Cory House";

WriteLine($"{insight.AsQuotedString()} - {author}");
