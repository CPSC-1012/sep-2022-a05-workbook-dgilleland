// See https://aka.ms/new-console-template for more information

string message = @$"Hello, World!

This is a good day to (do a lab).
Today is {DateTime.Today.ToLongDateString()}.
";
File.WriteAllText("AdHoc.log", message);

File.AppendAllText("AdHoc.log", "Here are the words in the string:\n");
string[] words = message.Split(" ");
File.AppendAllLines("AdHoc.log", words);