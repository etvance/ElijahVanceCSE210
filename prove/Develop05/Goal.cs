
using System.Xml.Serialization;

public abstract class  Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal()
    {

    }
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract bool CheckCompletion();

    public virtual int GetPoints()
    {
        return _points;
    }
    public abstract void DisplayGoal();

    public virtual string GoalString()
    {
        return $"Goal:{_name},{_description},{_points}";
    }

    public virtual int CompleteGoal()
    {
        return 0;
    }
}


