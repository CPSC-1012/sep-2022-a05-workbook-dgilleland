using static System.Console;
using static Thermometer.Units;

WriteLine($"The lowest integer value is {int.MinValue}");
WriteLine($"The freezing point of water is {Thermometer.FreezingPointOfWater}");

Thermometer forMyDesk = new(); // Initialize our variable to a new object instance

// Display our thermometer
WriteLine($"My thermometer: {forMyDesk}");
Write("Enter a temperature: ");
forMyDesk.CurrentTemperature = double.Parse(ReadLine());
WriteLine($"You entered {forMyDesk.ToString()}");
WriteLine($"For you old people, that is {forMyDesk.ToString(Fahrenheit)}");
WriteLine($"For you sci-fi-folk, that is {forMyDesk.ToString(Kelvin)}");

