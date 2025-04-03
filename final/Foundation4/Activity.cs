

public class Activity
{
    protected int _length;
    protected string _date = DateTime.Now.ToShortDateString();

    public Activity(int length)
    {
        _length = length;
    }

    public virtual double CalcSpeed()
    {
        return 0;
    }

    public virtual double CalcDistance()
    {
        return 0;
    }

    public virtual double CalcPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}