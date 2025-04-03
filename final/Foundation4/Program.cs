using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycle = new Cycling(30,5);
        Running run = new Running(45,4);
        Swimming swim = new Swimming(20, 3);
        List<Activity> activities = new List<Activity>()
        {
            cycle,run,swim
        };

        foreach (Activity x in activities)
        {
            Console.WriteLine(x.GetSummary());
        }
    }
}