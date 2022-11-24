namespace Demo_045;
// Keep all your console I/O operations for this file only
// That's why I've included the using static statements below
using static System.Console;
using static ConsoleHelper;

public class MyDriver
{
    #region Fields / Properties
    // TODO: Add as you see necessary
    private readonly Dictionary<string, Room> Rooms;
    #endregion

    #region Constructor(s)
    public MyDriver() // Add any parameters you think necessary
    {
        // Whatever "setup" needed for field/property values
        Rooms = new(); // Setup an empty dictionary of rooms
    }
    #endregion

    #region Methods
    public void Run()
    {
        WelcomeMessage();
        // This is the "heart" of your driver.
        // It's where your program is "kept alive"
        // Consider putting a try block with 
        // as many catch blocks as needed 
        // and/or a finally block for any cleanup
        // Focus here on recoverable exceptions, and plan how you will "recover"

        // TODO: Can you refactor the program by making steps A, B, and C into private methods?
        // A) Open a file
        string fileName = Prompt("Enter a file path (e.g.: Building.dat):");
        string[] lines = File.ReadAllLines(fileName);
        // B) Process each line in the file
        foreach(string lineOfData in lines)
        {
            // Expect each line of data to follow this kind of format:
            // Room:Living Room, 10.5, 12.5, 4.2
            // Opening:Living Room, 1.4, 2.4

            // TODO: Play the role of the computer:
            //       Can you see what numeric values get generated as each line is processed?
            //          1. Get a piece of paper,
            //          2. Examine the sample data in Building.dat
            //          3. Calculate the values of the next 5 variables for each line in the data file
            //             Remember that a string is an array of characters. That fact will have
            //             meaning in terms of the results of the .IndexOf() and .Substring() methods.
            int startPosition = lineOfData.IndexOf(':') + 1;
            int endPosition = lineOfData.IndexOf(',');
            int textLength = endPosition - startPosition;
            string roomName = lineOfData.Substring(startPosition, textLength);
            string dimensionData = lineOfData.Substring(endPosition + 1);

            if(lineOfData.StartsWith("Room"))
            {
                Room place = Room.Parse(dimensionData);
                Rooms.Add(roomName, place);
            }
            if(lineOfData.StartsWith("Opening"))
            {
                Opening gap = Opening.Parse(dimensionData);
                Room found = Rooms[roomName];
                found.AddOpening(gap);
            }
        }

        // C) Display the area of each room
        WriteLine($"There are {Rooms.Count} rooms.");
        double totalArea = 0;
        foreach(var location in Rooms)
        {
            WriteLine($"\t{location.Key}: {location.Value}");
            totalArea += location.Value.Area;
        }
        WriteLine();
        WriteLine($"The total paintable area is {totalArea} square meters");
    }

    // TODO: Add private helper methods below as needed to modularize your Run() method's code
    private void WelcomeMessage()
    {
        Clear();
        WriteLine("| Welcome to my \"Don't Crash\" Program Demo |");
        WriteLine("|--------------------------------------------|");
    }
    #endregion
}