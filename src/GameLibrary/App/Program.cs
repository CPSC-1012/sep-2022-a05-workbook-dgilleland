using static System.Console;
using Games; // DropDeadGame
using Games.CommonObjects; // Die

WriteLine("!! Ad-hoc testing of DropDeadGame !!");

// Make a bunch of dice
Die[] testDie = new Die[5];
// Create each die object in the array
for(int index = 0; index < testDie.Length; index ++)
    testDie[index] = new Die();

// Try out my DropDeadGame
string[] players = new string[] {"Dan", "Bob" };
DropDeadGame myGame = new DropDeadGame(players);

int score = myGame.RollDie(testDie);
WriteLine($"The score was {score}");

// ====== Methods =====
void ShowDie(Die[] theDice)
{
    foreach(Die item in theDice)
        Write($"{item.FaceValue, 4}");
    WriteLine();
}