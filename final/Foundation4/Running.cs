

public class Running:Activity
{
    protected double _distance;

    public Running(int length, double distance):base(length)
    {
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double CalcPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running({_length})- Distance: {_distance} miles, Speed: {Math.Round(CalcSpeed(), 2)} mph, Pace: {Math.Round(CalcPace(), 2)} min/mile";
    }
}