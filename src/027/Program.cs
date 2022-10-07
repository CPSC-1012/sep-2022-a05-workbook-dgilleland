// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Labelled Console I/O");
WriteLine("====================");

WriteLabelLine("PI", Math.PI);  // Math.PI is a double
WriteLabelLine("User Name", Environment.UserName); // UserName is a string
WriteLabelLine("Computer Name", Environment.MachineName); // MachineName is a string
WriteLabelLine("Current Directory", Environment.CurrentDirectory); // CurrentDirectory is a string



// Methods -------------

void WriteLabelLine(string label, object value)
{
    Write($"{label}: ");    // Note the colon and the trailing space
    WriteLine(value);       // Whatever the value is, output it as text
}