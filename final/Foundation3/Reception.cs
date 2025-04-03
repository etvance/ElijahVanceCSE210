

public class Reception:Event
{
    private string _email;

    public Reception(string name, string description, string date, string time, Address address, string eventType, string email)
    {
        _email = email;
    }

    public void DisplayReceptionDetails()
    {
        Console.WriteLine($"Please RSVP at {_email}");
        Console.WriteLine($"This is a {_eventType}");
    }
}