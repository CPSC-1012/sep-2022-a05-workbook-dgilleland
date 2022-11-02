using static System.Console;

WriteLine("Yadda Yahtzee!");

int count = 0;
int targetRoll;
Write("What number (1-6) do you want to attempt to roll? ");
targetRoll = PromptNumber(1, 6);

// use of = instead of ==
// Semicolon at end of if statement
// Semicolon at end of while
// Forgetting the $ on the string
// int roll = 0;
// while(roll > 0 && roll < max)

int PromptNumber(int min, int max)
{
    int roll = 0;
    while(!int.TryParse(ReadLine(), out roll) || roll < min || roll > max);
        Write("That was not a value between {min} and {max}. Try again: ");
    return roll;
}
