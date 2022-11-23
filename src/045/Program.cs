using Demo_045;
using static System.Console;


try
{
    MyDriver driver = new();
    driver.Run();
}
catch (System.Exception ex)
{
    ForegroundColor = ConsoleColor.DarkRed;
    WriteLine("Looks like there's a problem my program wasn't expecting. Time for me to exit");
    WriteLine(ex.Message); // Good for ad-hoc diagnostics, but not for production!
}
finally
{
    ResetColor();
}
