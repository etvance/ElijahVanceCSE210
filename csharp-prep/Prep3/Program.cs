using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain == true)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int guess = -1;
            while (guess != magicNumber )
            {
                Console.WriteLine("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNumber)
                {
                    System.Console.WriteLine("Lower");
                }else if (guess < magicNumber)
                {
                    System.Console.WriteLine("Higher");
                }else if (guess == magicNumber)
                {
                    System.Console.WriteLine("You guessed it");
                    System.Console.WriteLine("Would you like to play again?(y/n): " );
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        System.Console.WriteLine("Thanks for playing.");
                        playAgain = false;
                    }


                }else
                {
                    System.Console.WriteLine("Invalid Guess.");
                }

            }
        }
        

    
        

    }
}