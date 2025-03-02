using System;

public class ReflectionActivity : Activity
{
    private List<string> _initialPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _followUpPrompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity()
    {
        _name = "The Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    

    public void RunReflection()
    {
        Console.Clear();
        StartActivity();
        GetDuration();
        GetRedy();
        System.Console.WriteLine("Consider the Following Prompt:");
        Console.WriteLine($"---{GetRandomInitial()}---");
        DisplayAnimation(3);
        System.Console.WriteLine("Now ponder on each of these questions and how they related to this experience.");
        System.Console.WriteLine("You may begin in: ");
        DisplayCountDown(5);
        int x = 0;
        while (x <= _duration)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(GetRandomFollowUp());
            Console.ReadLine();
            DateTime endTime = DateTime.Now;
            var _diffInTime = endTime.Subtract(startTime);
            int y = _diffInTime.Seconds;
            x += y;
        }
        DisplayWellDone();
    }

    public string GetRandomInitial()
    {
    int count = _initialPrompts.Count();
    Random rand = new Random();
    int index = rand.Next(0, count);
    return _initialPrompts[index];
    }

    public string GetRandomFollowUp()
    {
    int count = _followUpPrompts.Count();
    Random rand = new Random();
    int index = rand.Next(0, count);
    return _followUpPrompts[index];
    }
}