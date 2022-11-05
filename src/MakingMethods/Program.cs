using static System.Console;
#region Problem Statement
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
#endregion

#region Body of Main Method
// TEMPORARY - Replace with Driver when I'm getting closer to the end
// Notice how I am "testing" my methods independent of each other.
WriteLine($"Area of circle is {CalculateArea("Square")}");

// WriteLine($"Testing: {GetDimension("Enter the radius")}");
// string firstShape, secondShape;
// firstShape = GetShapeType();
// secondShape = GetShapeType();
// WriteLine($"The two shapes to compare are {firstShape} and {secondShape}");
#endregion

#region Supporting Methods Begin Here
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

string GetShapeType()
{
    string shape;
    do
    {
        WriteLine("A) Circle");
        WriteLine("B) Square");
        WriteLine("C) Triangle");
        WriteLine("D) Rectangle");
        Write("\nSelect a shape (A through D only): ");
        shape = ReadLine().ToUpper();
    }while(shape != "A" && shape != "B" && shape != "C" && shape != "D");

    if(shape == "A")
        shape = "Circle";
    else if(shape == "B")
        shape = "Square";
    else if(shape == "C")
        shape = "Triangle";
    else if(shape == "D")
        shape = "Rectangle";

    return shape;
}

double CalculateArea(string shape)
{
    // This method depends on GetDimension, which interacts with the user.
    double area = 0;
    switch(shape)
    {
        case "Circle":
            double radius = GetDimension("Enter a radius: ");
            area = Math.PI * radius * radius;
            break;
        case "Square":
            break;
        case "Triangle":
            break;
        case "Rectangle":
            break;
    }
    return area;
}

string Compare(string shapeA, double areaA, string shapeB, double areaB)
{
    // This method does NOT have any user I/O - it just does comparisons.
    string bigger = "X";

    return bigger;
}
#endregion
