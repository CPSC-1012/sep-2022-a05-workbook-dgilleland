public class Thermometer
{
    // An enumeration that only applies to temperatures
    public enum Units { Celsius, Fahrenheit, Kelvin }
    //                 \default/

    public const int FreezingPointOfWater = 0;
    public const double AbsoluteZero = -273.15;

    // Instance members of the class
    private double _CurrentTemperature; // This field is our "backing store"
    public double CurrentTemperature
    {
        get
        {
            return _CurrentTemperature; // Return the value from our backing store
        }
        set
        {
            // Here is a good place to VALIDATE the information coming in
            if(value < AbsoluteZero)
                throw new Exception($"Impossible temperature: {value} is less than absolute zero {AbsoluteZero}");
            _CurrentTemperature = value; // Store the incoming value in our field
        }
    }

    // Method to adjust the temperature
    public void Adjust(double amount)
    {
        // Notice how our property is accessible to all methods of our class
        CurrentTemperature += amount;
    }

    // In the following method, I change the default way
    // my object instances get turned into "strings"
    public override string ToString()
    {
        return $"{CurrentTemperature}{'\u00B0'} {Units.Celsius}";
    }

    public string ToString(Units targetUnit)
    {
        string result = "";
        double temp;
        switch(targetUnit)
        {
            case Units.Celsius:
                temp = CurrentTemperature;
                break;
            case Units.Fahrenheit:
                temp = ToFahrenheit();
                break;
            case Units.Kelvin:
                temp = ToKelvin();
                break;
            default:
                temp = 0;
                break;
        }
        result = $"{temp}{'\u00B0'} {targetUnit}";
        return result;
    }
    public double ToKelvin()
    {
        return CurrentTemperature + (-1 * AbsoluteZero);
    }
    public double ToFahrenheit()
    {
        double result;
        result = (CurrentTemperature * 9.0/5.0) + 32;
        return result;
    }
}
