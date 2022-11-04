using static System.Console;

WriteLine("Yadda Yahtzee!");
Die aDie = new();
int count = 0;
int targetRoll;
Write("What number (1-6) do you want to attempt to roll? ");
targetRoll = PromptNumber(1, 6);

WriteLine("\nAttempting up to 10 rolls to get that number...");
while(count >= 0 && count < 10 || targetRoll != aDie.FaceValue)
{
    WriteLine($"Attempt: {count} \t\t{aDie.FaceValue} != {targetRoll}");
    aDie.Roll();
    count++;
}

if(aDie.FaceValue == targetRoll)
    WriteLine($"You got the roll {targetRoll} in {count} attempts.");
else
    WriteLine("Sorry, you did not get the {targetRoll}");


// Methods
int PromptNumber(int min, int max)
{
    int roll = 0;
    while(!int.TryParse(ReadLine(), out roll) || roll < min || roll > max)
        Write("That was not a value between {min} and {max}. Try again: ");
    return roll;
}
