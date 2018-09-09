public class ApplicationModel
{
    public static bool gameStarted = false;
    public static bool playerStart = false;
    public static int difficultyLevel = 0;

    public enum DifficultyLabel
    {
        Easy, Medium, Hard
    }

    public enum GameState
    {
        Win, Lose, Draw
    }

    public static string GetDifficultyLabel (int difficulty)
    {
        DifficultyLabel difficultyLabel = (DifficultyLabel)difficulty;
        return difficultyLabel.ToString();
    }

    public static string GetGameState (int state)
    {
        GameState gameState = (GameState)state;
        return gameState.ToString();
    }
}
