using static System.Console;
using System.IO;
Clear();
string title = "Objective: Display a list of files in a directory and determine whether or not a file exists.";

WriteLine(title);
WriteLine("".PadRight(title.Length, '-'));

string path = Directory.GetCurrentDirectory();
WriteLine($"The current directory is {path}");
string[] parts = path.Split("\\"); // You might need to "escape" the backslash
for(int index = 0; index < parts.Length; index++)
    WriteLine($"\t{parts[index]}");
string reassembled = string.Join("\\", parts); // give me the same path
// imagine instead, I decided to loop to re-assemble the string
reassembled = "";
for(int index = 0; index < parts.Length - 1; index++)
    reassembled += parts[index] + "\\";

// There is also a class called Path that is used to create paths
string parentFolder = Path.Combine(path, "..");
WriteLine($"The parent of {path} is \n\t{parentFolder}");


path = Directory.GetDirectoryRoot(path);
WriteLine($"The directory root is {path}");

string[] folders = Directory.GetDirectories(Directory.GetCurrentDirectory());
WriteLine($"The following folders exist in the current directory:");
for(int index = 0; index < folders.Length; index++)
    WriteLine($"{index + 1})\t{folders[index]}");

string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
WriteLine($"The following files exist in the current directory:");
for(int index = 0; index < files.Length; index++)
    WriteLine($"{index + 1})\t{files[index]}");

string filePath = "Answers.log";
if(File.Exists(filePath))
    WriteLine($"Place your answer to the question on the board in the \"{filePath}\" file and copy to the next demo folder.");
else
    File.Create(filePath);
