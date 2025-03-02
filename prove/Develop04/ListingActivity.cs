using System;
using System.Data;
using System.Runtime.InteropServices;
// no interuption when time runs out, let user finish item

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        _name = "The Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunListing()
    {
        Console.Clear();
        StartActivity();
        GetDuration();
        GetRedy();
        int x = 0;
        int count = 0;
        while (x <= _duration)
        {
            string g = GetRandomPrompt();
            System.Console.WriteLine(g);
            DateTime startTime = DateTime.Now;
            Console.ReadLine();
            DateTime endTime = DateTime.Now;
            var _diffInTime = endTime.Subtract(startTime);
            int y = _diffInTime.Seconds;
            x += y;
            count ++;
        }
        System.Console.WriteLine($"You listed {count} things!");
        Thread.Sleep(2000);
        DisplayWellDone();

    }

    public string GetRandomPrompt()
    {
    int count = _prompts.Count();
    Random rand = new Random();
    int index = rand.Next(0, count);
    return _prompts[index];
    }
}