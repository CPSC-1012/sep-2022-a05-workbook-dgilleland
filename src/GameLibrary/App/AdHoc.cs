using Games;
using Games.CommonObjects;
using static System.Console;
public class AdHoc
{
    public static void RunManualTests()
    {
        WriteLine("!! Ad-hoc testing of DropDeadGame !!");

        // Make a bunch of dice
        Die[] testDie = new Die[5];
        // Create each die object in the array
        for (int index = 0; index < testDie.Length; index++)
            testDie[index] = new Die();

        // Try out my DropDeadGame
        string[] players = new string[] { "Dan", "Bob" };
        DropDeadGame myGame = new DropDeadGame(players);

        WriteLine("Before the call, I have:");
        ShowDie(testDie);
        int score = myGame.RollDie(testDie);
        WriteLine($"The score was {score}");
        ShowDie(testDie);
        WriteLine($"I can roll {myGame.CheckRemainingDie(testDie)}");


    }


    // ====== Methods =====
    private static void ShowDie(Die[] theDice)
    {
        // for(int index = 0; index < theDice.Length; index++)
        // {
        //     Die item = theDice[index];
        //     Write($"{item.FaceValue, 4}");
        // }
        foreach (Die item in theDice)
            Write($"{item.FaceValue,4}");
        WriteLine();
    }
}