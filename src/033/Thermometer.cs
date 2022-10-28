public class Thermometer
{
    // An enumeration that only applies to temperatures
    public enum Units { Celsius, Fahrenheit, Kelvin }
    //                 \default/

    public const int FreezingPointOfWater = 0;
    public const double AbsoluteZero = -273.15;

    // Instance members of the class
    public double CurrentTemperature;


    // In the following method, I change the default way
    // my object instances get turned into "strings"
    public override string ToString()
    {
        return $"{CurrentTemperature}{'\u00B0'} {Units.Celsius}";
    }
}
