

public class Comment
{
    private string _user;
    private string _comment;

    public Comment(string user, string comment)
    {
        _user = user;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_user}:\n{_comment}\n");
    }
    
}