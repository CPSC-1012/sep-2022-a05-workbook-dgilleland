// See https://aka.ms/new-console-template for more information
using static System.Console;

int base10Number, quotient, remainderBase10;
char remainderBase16;
const int DIVISOR = 16;

// Pretend this was user input
base10Number = 4329;
quotient = base10Number / DIVISOR;
WriteLine($"The quotient is {quotient}");
remainderBase10 = base10Number % DIVISOR; // Modulus
WriteLine($"The remainder is {remainderBase10}");

//  METHODS
char GetHexDigit(int base10Digit)
{
    char result;
    switch(base10Digit)
    {
        case 0:
            result = '0';
            break;
        case 1:
            result = '1';
            break;
        case 2:
            result = '2';
            break;
        case 3:
            result = '3';
            break;
        case 4:
            result = '4';
            break;
        case 5:
            result = '5';
            break;
        case 6:
            result = '6';
            break;
        case 7:
            result = '7';
            break;
        case 8:
            result = '8';
            break;
        case 9:
            result = '9';
            break;
        case 10:
            result = 'A';
            break;
        case 11:
            result = 'B';
            break;
        case 12:
            result = 'C';
            break;
        case 13:
            result = 'D';
            break;
        case 14:
            result = 'E';
            break;
        case 15:
            result = 'F';
            break;
        default:
            result = default(char);
            break;
    }
    return result;
}