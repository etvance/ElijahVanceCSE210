

public class ChecklistGoal: Goal
{
    private int _bonusPoints;
    private int _totalTimes;
    private int _actualTimes;
    private bool _done;
    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int totalTimes): base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalTimes = totalTimes;
        _actualTimes = 0;
        _done = false;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int totalTimes, int actualTimes, bool done): base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalTimes = totalTimes;
        _actualTimes = actualTimes;
        _done = done;
    }

    public override bool CheckCompletion()
    {
        return _done;
    }

    public override void DisplayGoal()
    {
        if (_done == true)
        {
            Console.WriteLine($"    [x] {_name} -- Currently Completed {_actualTimes}/{_totalTimes}");
        }
        else
        {
            Console.WriteLine($"    [ ] {_name} -- Currently Completed {_actualTimes}/{_totalTimes}");
        }
    }
        public override string GoalString()
    {
        return $"CheckListGoal:{_name},{_description},{_points},{_bonusPoints},{_totalTimes},{_actualTimes},{_done}";
    }
    public override int CompleteGoal()
    {
        _actualTimes = _actualTimes + 1;
        
        if (_actualTimes == _totalTimes)
        {
            _done = true;
            return _bonusPoints;
        }
        else
        {
            return 0;
        }
    }
}