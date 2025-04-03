

public class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string name, string description, string date, string time, Address address, string eventType, string speaker, int capacity) :base(name, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureDetails()
    {
        Console.WriteLine($"This event will feature {_speaker}");
        Console.WriteLine($"There will be {_capacity} seats");
        Console.WriteLine($"This is a {_eventType}");
    }
}