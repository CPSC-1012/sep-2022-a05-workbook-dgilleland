// New way to declare a namespace for the following types/classes, called "file-scoped namespace declaration".
namespace Games;

public record DropDeadTurnResult(string PlayerName, int CurrentScore, TurnStatus TurnStatus, int[] DieRolls);

public enum TurnStatus { Unknown, Finished, Waiting,
    InProcess
}
