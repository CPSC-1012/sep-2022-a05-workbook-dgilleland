using System.IO; // for file Input/Output classes
using static System.Console;
public class Driver
{
    internal void Run()
    {
        // A) List the contents of this directory
        string repoRoot = Path.Combine("..", "..");
        string[] folderContents = Directory.GetDirectories(repoRoot);
        WriteLine($"There are {folderContents.Length} directories in the current directory.");
        for(int index = 0; index < folderContents.Length; index ++)
        //      ^-start-^  ^--go until the end of array-^
        {
            // Get the item in the array
            string item = folderContents[index];
            //                          ^-pos-^
            // do something with it....
            string[] temp = Directory.GetDirectories(item);
            int count = temp.Length;
            WriteLine($"\t{count} items in the folder `{item}`");
        }
        // B) Open a file to read the contents
        // C) Output the contents to the console.
    }
}