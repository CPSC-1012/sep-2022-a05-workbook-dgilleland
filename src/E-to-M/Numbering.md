# Numbering

The samples shown here represent an evolution of a set of classes that relate to creating custom numeric types.

## Evolution of the Fraction Class

The `Fraction` class illustrates the idea of representing some numeric type/concept not natively built into the C# language.

> ***Also illustrate a TDD approach to this***

- V.1.0 - Basics of Classes
  - Numerator/Denominator properties
  - Constructor
  - .ToString()
- V.1.1 - Calculations
  - .ToDouble
  - .ToDecimal
  - .ToInt (*warning - should result in potential data loss, because it reflects integer division rules*)
  - Reciprocal
- V.1.2 - Decisions (`if`)
  - throw exception on zero denominator
  - Handle negative sign properly (on numerator)
  - .IsProper
- V.1.3 - Methods (+ `out` parameter)
  - .Parse and .TryParse
- V.1.4 - Mutation methods (changes state of object)
  - .Add/.Subtract/.MultiplyBy/.DivideBy
  - *Can be debated whether this is good or bad.*
- V.1.5 - Looping
  - GreatestCommonDenominator
- V.1.6
  - Operator overloading (non-mutating operations)
