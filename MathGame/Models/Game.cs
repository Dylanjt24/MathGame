namespace MathGame.Models;

internal class Game
{
    /*private int _score;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }*/

    // Auto property - does the same thing as the code above with the backing field, just with fewer lines of code
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType Type { get; set; }
    public string Difficulty { get; set; }
}

// Create enumeration type to store game type played
internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}