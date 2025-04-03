

using System.Diagnostics;

public class Cycling:Activity
{
    private double _speed;

    public Cycling(int length, double speed):base(length)
    {
        _speed = speed;
    }

    public override double CalcDistance()
    {
        double distance = (_speed / 60) * _length;
        return distance;
    }

    public override double CalcPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} Cycling({_length})- Distance: {Math.Round(CalcDistance(), 2)} miles, Speed: {_speed} mph, Pace: {Math.Round(CalcPace(), 2)} min/mile";
        return summary;
    }
}