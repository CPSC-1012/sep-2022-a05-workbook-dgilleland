using Demo_045;
using static System.Console;


try
{
    // The try block is where the code we plan on using
    // (and hope is working correctly) is executed.
    MyDriver driver = new();
    driver.Run();
}
// Catch blocks are where we can intercept a thrown exception (problem)
// and deal with appropriately
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
