public class ApplicationModel
{
    public static bool gameStarted = false;
    public static int playerStart = 0;
    public static Difficulty difficulty = Difficulty.Easy;

    public enum Difficulty
    {
        Easy, Medium, Hard
    }

    public enum GameState
    {
        Win, Lose, Draw
    }

    public enum PlayerStartState
    {
        Unset, Start, Last
    }

    public enum TurnState
    {
        AI, PLAYER
    }

    public static string GetDifficultyLabel (int difficulty)
    {
        Difficulty difficultyLevel = (Difficulty)difficulty;
        return difficultyLevel.ToString();
    }

    public static string GetGameState (int state)
    {
        GameState gameState = (GameState)state;
        return gameState.ToString();
    }

    public static bool DeterminePlayerStartState(int playerState)
    {
        bool playerStart = true;
        switch (playerState)
        {
            case (int)ApplicationModel.PlayerStartState.Unset:
                playerStart = true;
                break;
            case (int)ApplicationModel.PlayerStartState.Start:
                playerStart = true;
                break;
            case (int)ApplicationModel.PlayerStartState.Last:
                playerStart = false;
                break;
            default:
                playerStart = true;
                break;
        }
        return playerStart;
    }
}
