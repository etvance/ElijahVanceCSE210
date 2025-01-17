using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int numberSquared = SquareNumber(favoriteNumber);
        DisplayResult(userName, numberSquared);
    }
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
        // Displays the message, "Welcome to the Program!"
    }
    
    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        // Asks for and returns the user's name (as a string)
    }
    static int PromptUserNumber()
    {
        System.Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
        // Asks for and returns the user's favorite number (as an integer)
    }
    static int SquareNumber(int favoriteNumber)
    { 
        int numberSquared = favoriteNumber * favoriteNumber;
        return numberSquared;
        // Accepts an integer as a parameter and returns that number squared (as an integer)
    }
    static void DisplayResult(string userName, int numberSquared)
    {
        System.Console.WriteLine($"{userName}, the square of your number is {numberSquared}");

        // Accepts the user's name and the squared number and displays them.
    }
}