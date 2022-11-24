using Demo_045;
using static System.Console;


try
{
    // The try block is where the code we plan on using
    // (and hope is working correctly) is executed.
    MyDriver driver = new();
    driver.Run();
    AdHoc();
}
// Catch blocks are where we can intercept a thrown exception (problem)
// and deal with appropriately.
// You should arrange your catch blocks from the more specific types
// of exceptions to the least-specific types of exceptions
// System.Exception is the most general (least-specific) type of exception.
catch (System.Exception ex) // I can have from zero to many catch blocks
{
    ForegroundColor = ConsoleColor.DarkRed;
    WriteLine("Looks like there's a problem my program wasn't expecting. Time for me to exit");
    WriteLine(ex.Message); // Good for ad-hoc diagnostics, but not for production!
}
finally
{
    // The finally block is where we can do some "clean-up" for our program.
    // The finally block will always run, whether or not there is an exception.
    ResetColor();
}


void AdHoc()
{
    // Create some rooms.
    string info = "10,12,4";
    Room myRoom;
    myRoom = Room.Parse(info);

    Opening opening = Opening.Parse("1.4,2.4");
    myRoom.AddOpening(opening);
    WriteLine(opening);
    opening = Opening.Parse("1.3, 1.1");
    myRoom.AddOpening(opening);
    WriteLine($"The area of my room is {myRoom.Area}. My room is {myRoom}");
}