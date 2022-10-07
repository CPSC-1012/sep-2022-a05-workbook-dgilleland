// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Labelled Console I/O");
WriteLine("====================");

WriteLabelLine("PI", Math.PI);
WriteLabelLine("User Name", Environment.UserName);
WriteLabelLine("Computer Name", Environment.MachineName);
WriteLabelLine("Current Directory", Environment.CurrentDirectory);



// Methods -------------

void WriteLabelLine(string label, object value)
{
    Write($"{label}: ");    // Note the colon and the trailing space
    WriteLine(value);       // Whatever the value is, output it as text
}