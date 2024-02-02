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
    public string Type { get; set; }
}
