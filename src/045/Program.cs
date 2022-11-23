using Demo_045;
using static System.Console;


try
{
    MyDriver driver = new();
    driver.Run();
}
catch (System.Exception ex) // I can have from zero to many catch blocks
{
    ForegroundColor = ConsoleColor.DarkRed;
    WriteLine("Looks like there's a problem my program wasn't expecting. Time for me to exit");
    WriteLine(ex.Message); // Good for ad-hoc diagnostics, but not for production!
}
finally
{
    ResetColor();
}
