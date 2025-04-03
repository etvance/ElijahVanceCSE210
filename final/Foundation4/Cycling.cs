

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
        return (_speed / 60) * _length;
    }

    public override double CalcPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling({_length})- Distance: {Math.Round(CalcDistance(), 2)} miles, Speed: {_speed} mph, Pace: {Math.Round(CalcPace(), 2)} min/mile";
    }
}