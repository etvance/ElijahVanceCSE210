using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your fist Name?: ");
        string Name1 = Console.ReadLine();

        Console.Write("What is your last Name?: ");
        string Name2 = Console.ReadLine();

        Console.WriteLine($"Your name is {Name2}, {Name1} {Name2}.");
    }
}