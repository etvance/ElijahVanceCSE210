

using System.ComponentModel;

public class Event
{
    private string _name;
    private string _description;
    private string _date;
    private string _time;
    protected string _eventType;
    private Address _address;

    public Event(string name, string description, string date, string time, Address address, string eventType)
    {
        _name = name;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }

    public Event()
    {}

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_name}: ");
        Console.WriteLine(_description);
        Console.WriteLine($"This event will take place {_date} at {_time}");
        Console.WriteLine($"The event will be located at {_address.AddressString()}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"This is a {_eventType}");
        Console.WriteLine($"{_name}, {_date}");
    }
}