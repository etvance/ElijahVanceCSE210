

using System.Transactions;

public class Video
{
    private string _title;
    private string _publisher;
    private int _lengthInSecs;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string publisher, int length)
    {
        _title = title;
        _publisher = publisher;
        _lengthInSecs = length;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} \nPublisher: {_publisher} \nVideo Length: {_lengthInSecs} seconds\n");
    }

    public int CountComments()
    {

        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void ListComments()
    {
        foreach (Comment x in _comments)
        {
            x.DisplayComment();
        }
    }
}