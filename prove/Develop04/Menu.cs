using System;
public class Menu
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1) Start Breathing Activity");
        Console.WriteLine(" 2) Start Reflection Activity");
        Console.WriteLine(" 3) Start Listing Activity");
        Console.WriteLine(" 4) Quit");
        System.Console.WriteLine();
    }

    public void DisplayFinishMenu()
    {
        Console.Clear();
        Console.WriteLine("You have completed one of each activity today! Would you like to:");
        Console.WriteLine(" 1) Continue Participating in Activities\nor");
        Console.WriteLine(" 2) Quit");
    }
}