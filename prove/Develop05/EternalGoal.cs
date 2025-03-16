public class EternalGoal : Goal
{
    public EternalGoal()
    {

    }

    public EternalGoal(string name, string description, int points) :base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"    [∞] {_name}");
    }

        public override string GoalString()
    {
        return $"EternalGoal:{_name},{_description},{_points},";
    }

    public override bool CheckCompletion()
    {
        return false;
    }

}