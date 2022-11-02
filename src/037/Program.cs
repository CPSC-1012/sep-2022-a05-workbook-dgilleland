using static System.Console;
using System.IO;
Clear();

WriteLine("Objective: Display a list of files in a directory and determine whether or not a file exists.\n");

string path = Directory.GetCurrentDirectory();
WriteLine($"The current directory is {path}");

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
