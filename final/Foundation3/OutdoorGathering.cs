

using System.Reflection;

public class OutdoorGathering:Event
{
    private string _weather;

    public OutdoorGathering(string name, string description, string date, string time, Address address, string eventType, string weather):base(name, description, date, time, address, eventType)
    {
        _weather = weather;
    }

    public void DisplayWeatherDetails()
    {
        Console.WriteLine($"The weather for the event looks to be: {_weather}");
        Console.WriteLine($"This is a {_eventType}");
    }
}