# Archived code

```csharp
using static System.Math;
double tuition = 5500;
// string interpolation for my output
WriteLine($"Basic tuition is {tuition:C}"); // format the tuition as Currency

Demo some basic data types.
char status = 'a'; // for "Armed"
int statusValue = status; //btw, don't do this - treating chars as ints is poor programming....
WriteLine($"The value of {status} is {statusValue}");

// Integer division
int firstNumber = 5, secondNumber = 3;
WriteLine($" 5 / 3 is {firstNumber / secondNumber}"); // Notice the expression
WriteLine($" 5 % 3 is {firstNumber % secondNumber}"); // Modulus

firstNumber = firstNumber + 7; // Can you predict the result??
WriteLine($"The new value for firstNumber is {firstNumber}");
firstNumber += 9 * 2 + 1; // Can you predict the result??
WriteLine($"Now the value of firstNumber is {firstNumber}");
secondNumber++; // Increment the value of secondNumber by 1
WriteLine($"The value of secondNumber is {secondNumber}");
WriteLine($"What happens with post-fix increment? {secondNumber++}");
WriteLine($"But the value actually is {secondNumber}");
WriteLine($"Using prefix notation: {++secondNumber}");
```
