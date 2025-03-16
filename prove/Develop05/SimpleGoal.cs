
using System.Drawing;

public class SimpleGoal:Goal
{
    private bool _done;

    public SimpleGoal()
    {

    }

    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _done = false;
    }

    public SimpleGoal(string name, string description, int points, bool done): base(name, description, points)
    {
        _done = done;
    }

    public override bool CheckCompletion()
    {
        return _done;
    }

    public override void DisplayGoal()
    {
        if (_done == false)
        {
            System.Console.WriteLine($"    [ ] {_name}: {_points} Points");
        }
        else
        {
            System.Console.WriteLine($"    [X] {_name}: {_points} Points");
        }
    }

    public override string GoalString()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_done}";
    }

    public override int CompleteGoal()
    {
        _done = true;
        return 0;
    }
}