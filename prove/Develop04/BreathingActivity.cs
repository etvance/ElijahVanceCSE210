using System;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "The Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunBreathing()
    {
        Console.Clear();
        StartActivity();
        GetDuration();
        GetRedy();
        int x = 0;
        while (x <= _duration)
        {
            System.Console.Write("Breath in...");
            DisplayCountDown(4);
            System.Console.WriteLine();
            System.Console.Write("Breath out...");
            DisplayCountDown(6);
            System.Console.WriteLine("\n");
            x += 10;
        }
        DisplayWellDone();
    }
}