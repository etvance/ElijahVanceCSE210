using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradePrecentText = Console.ReadLine();
        int gradePercent = int.Parse(gradePrecentText);
        Math.DivRem(gradePercent, 10, out int remainder);

        string gradeLetter = "";

        if (gradePercent > 90)
        {
            if (remainder >= 3)
            {
                gradeLetter = "A";
            }
            else if (remainder < 3)
            {
                gradeLetter = "A-";
            }
        }
        else if (gradePercent >= 80)
        {
            if (remainder >= 7)
            {
                gradeLetter = "B+";
            }
            else if (remainder >= 3)
            {
                gradeLetter = "B";
            }
            else if (remainder < 3)
            {
                gradeLetter = "B-";
            }
        }
        else if (gradePercent >= 70)
        {
            if (remainder >= 7)
            {
                gradeLetter = "C+";
            }
            else if (remainder >= 3)
            {
                gradeLetter = "C";
            }
            else if (remainder < 3)
            {
                gradeLetter = "C-";
            }        }
        else if (gradePercent >= 60)
        {
            if (remainder >= 7)
            {
                gradeLetter = "D+";
            }
            else if (remainder >= 3)
            {
                gradeLetter = "D";
            }
            else if (remainder < 3)
            {
                gradeLetter = "D-";
            }
        }
        else
        {
            gradeLetter = "F";
        }

        System.Console.WriteLine($"Your letter grade is {gradeLetter}.");
        if (gradePercent >= 70)
        {
            System.Console.WriteLine("Congradulations on passing the course.");
        }
        else
        {
            System.Console.WriteLine("Due to your Grade you did not pass. Try better next time!");
        }
    }
}