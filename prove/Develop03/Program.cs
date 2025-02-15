using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        Reference _reference1 = new Reference("Proverbs",3,5,6);
        // Reference _reference2 = new Reference("Proverbs",3,5);
        Scripture scripture1 = new Scripture(_reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "In all thy ways acknowledge him, and he shall direct thy paths.");
        // Scripture scripture1 = new Scripture(_reference2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        Console.Clear();
        scripture1.BuildVerseList();
        scripture1.Display();
        Console.WriteLine("\nPress Enter to hide words, type Quit to exit.:");
        string _userInput = Console.ReadLine();
        
        while (done == false)
        {

            if (_userInput == "")
            {    
                Console.Clear();
                scripture1.HideRandom();
                // scripture1.BuildVerseList();
                scripture1.Display();
                Console.WriteLine("\nPress Enter to hide words or type Quit to exit.");
                _userInput = Console.ReadLine();
                if (scripture1.IsFinished() == true)
                {
                    done = true;
                }
                else
                {
                    done = false;
                }
            }
            else if(_userInput.ToUpper() == "QUIT")
            {
                done = true;
                System.Console.WriteLine("Thank you for memorizing!");
            }
            else
            {
                System.Console.WriteLine("Please press Enter to hide words or typr Quit to exit.");
            }
        }
    }
}