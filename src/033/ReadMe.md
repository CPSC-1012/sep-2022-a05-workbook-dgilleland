## Designing Classes

The following are some ideas for data types representing the ability to measure items.

## Thermometer

- Another class example
- `enum` types
- constants in classes (like `int.MaxValue`)

```csharp
public class Thermometer
{
    public enum Units { Celsius, Farenheit, Kelvin }
    public const int FreezingPointOfWater = 0;
    public const double AbsoluteZero = -273.15;

    public double CurrentTemperature;
    /// <summary>Adjusts the current temperature to match the supplied temperature.</summary>
    public void Record(double temperature)
    {
        // TODO: Exception if the temperature is too low
        CurrentTemperature = temperature;
    }
}
```

## Speedometer


## Odometer

