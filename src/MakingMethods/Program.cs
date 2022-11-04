using static System.Console;
// Let's create a program that will compare the areas of two shapes and identify which is bigger.
// - The user can identify which shape they want: Circle, Square, Triangle, or Rectangle
// - Formulas:
//      - Circle: Area = PI * r^2
//      - Square: Area = side ^ 2
//      - Triangle: Area = 1/2 * base * height
//      - Rectangle: Area = length * width
// - The user can repeat the action of comparing shapes, pressing "X" to exit
// - Validate all user input
// - Handle all dimensions as double data types



// Methods Begin Here:
double GetDimension(string promptMessage)
{
    Write(promptMessage);
    double result;
    while(! double.TryParse(ReadLine(), out result) || result <= 0)
    {
        WriteLine("\tThat was not a valid number. Enter a number larger than zero");
        Write(promptMessage);
    }
    return result; // A method can only explicitly return ONE thing.
}
