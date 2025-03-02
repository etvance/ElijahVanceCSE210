using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _animation = new List<string>()
    {
    "/",
    "-",
    "\\",
    "-"
    };

    public Activity()
    {

    }

    public void StartActivity()
    {
        DisplayAnimation(2);
        System.Console.WriteLine($"Welcome to {_name}. \n\n{_description}\n");
        
    }

    public int GetDuration()
    {
        System.Console.WriteLine("How long you you like the Activity to run for?(In seconds): ");
        string _stringduration = System.Console.ReadLine();
        _duration = int.Parse(_stringduration);
        return _duration;
    }

    public void GetRedy()
    {
        System.Console.WriteLine("Get Ready");
        DisplayAnimation(1);
        DisplayCountDown(3);
        System.Console.WriteLine("Go");
    }
    
    public void DisplayCountDown(int timer)
    {
        // Console.WriteLine("Display count is called");
        for (int i=timer; i > 0; i--)
        {
            // System.Console.WriteLine("Loop is running");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

    public void DisplayWellDone()
    {
        System.Console.WriteLine("Well Done!");
        Thread.Sleep(700);
        System.Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        DisplayAnimation(4);

    }

    public void DisplayAnimation(int dur)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(dur);
        while (DateTime.Now < endTime)
        {
            foreach (string x in _animation)
            {
                Console.Write(x);
                Thread.Sleep(400);
                Console.Write("\b");
            }
        } 
    }
}