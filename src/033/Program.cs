using static System.Console;

WriteLine($"The lowest integer value is {int.MinValue}");
WriteLine($"The freezing point of water is {Thermometer.FreezingPointOfWater}");

Thermometer forMyDesk = new(); // Initialize our variable to a new object instance

// Display our thermometer
WriteLine($"My thermometer: {forMyDesk}");


