namespace Demo_045;
// Keep all your console I/O operations for this file only
// That's why I've included the using static statements below
using static System.Console;
using static ConsoleHelper;

public class MyDriver
{
    #region Fields / Properties
    // TODO: Add as you see ncecessary
    #endregion

    #region Constructor(s)
    public MyDriver() // Add any parameters you think necessary
    {
        // Whatever "setup" needed for field/property values
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

        // App Plan
        /*
            - Open a file
            - Read contents into a collection of rooms
              - Rooms should be able to calculate their own area
            - Output the results of the areas of each room
              - Maybe to a file, maybe to screen...
        */
    }

    // TODO: Add private helper methods as needed to modularize
    // your Run() method's code

    private void WelcomeMessage()
    {
        Clear();
        WriteLine("| Welcome to my \"Don't Crash\" Program Demo |");
        WriteLine("|--------------------------------------------|");
    }
    #endregion
}