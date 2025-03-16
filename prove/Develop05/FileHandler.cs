public class FileHandler
{
    private List<Goal> _goals = new List<Goal>();
    private int _scoreLoad;

    public FileHandler()
    {

    }

    public int GetScoreLoad()
    {
        return _scoreLoad;
    }
    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public void ListGoals()
    {
        Console.WriteLine("Here are your current goals: ");
        Console.WriteLine();

        foreach (Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
        
    }

    public Goal GetGoal(int index)
    {
        return _goals[index - 1];
    }
    public void SaveFiles(string fileName, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string scoreString = $"{score}";
            foreach (Goal goal in _goals)
            {
                string goalstring = goal.GoalString();
                outputFile.WriteLine($"{scoreString} {goalstring}");
            }
        }
    }

    public void LoadFiles(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string[] smallerParts = parts[1].Split(",");
            string[] scoreOnly = parts[0].Split(" ");
            string className = scoreOnly[1];
            string name = smallerParts[0];
            string description = smallerParts[1];

            _scoreLoad = int.Parse(scoreOnly[0]);
                        
            int pointAmount = int.Parse(smallerParts[2]);

                if (className == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(smallerParts[3]);
                    SimpleGoal s = new SimpleGoal(name, description, pointAmount, isComplete);
                    _goals.Add(s);

                }
                else if (className == "EternalGoal")
                {
                    EternalGoal e = new EternalGoal(name, description, pointAmount);
                    _goals.Add(e);
                }
                else if (className == "CheckListGoal")
                {
                    int  bonusPoints = int.Parse(smallerParts[3]);
                    int totalTimes = int.Parse(smallerParts[4]);
                    int actualTimes = int.Parse(smallerParts[5]);
                    bool checkedOff = bool.Parse(smallerParts[6]);

                    ChecklistGoal cl = new ChecklistGoal(name, description, pointAmount, bonusPoints, totalTimes, actualTimes, checkedOff);
                    _goals.Add(cl);
                }

            

        }
    }
}