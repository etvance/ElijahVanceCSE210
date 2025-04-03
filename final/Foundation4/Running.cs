

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
        double speed = (_distance / _length) * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _length / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} Running({_length})- Distance: {_distance} miles, Speed: {Math.Round(CalcSpeed(), 2)} mph, Pace: {Math.Round(CalcPace(), 2)} min/mile";
        return summary;
    }
}