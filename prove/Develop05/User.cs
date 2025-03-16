public class User
{
    private int _score;

    public User()
    {

    }
    public User(int score)
    {
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void UpdateScore(int points)
    {
        _score = _score + points;
    }


}