

public class Swimming:Activity
{
    private int _numOfLaps;

    public Swimming(int length, int numOfLaps):base(length)
    {
        _numOfLaps = numOfLaps;
    }

    public override double CalcDistance()
    {
        double distance = _numOfLaps * 50 /(1000 * 0.62);
        return distance; 
        //1 lap = 50m, converted to miles
    }

    public override double CalcSpeed()
    {
        double speed = CalcDistance() / _length * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _length / CalcDistance();
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} Swimming({_length})- Distance: {Math.Round(CalcDistance(), 2)} Miles, Speed: {Math.Round(CalcSpeed(), 2)} mph, Pace: {Math.Round(CalcPace(), 2)} min/mile";
        return summary;
    }
}