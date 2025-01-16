using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        int listSum = 0;
        int max = -10000;
        int min = 1000000;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int num in numbers)
        {
            listSum = listSum + num;
            if (num > max)
            {
                max = num;
            }
            if (num< min)
            {
                if (num > 0)
                {
                    min = num;
                }
            }
        }
        float average = ((float)listSum) / numbers.Count;
        numbers.Sort();

        System.Console.WriteLine($"The sum is: {listSum}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is: {max}");
        System.Console.WriteLine($"The smallest positive number is: {min}");
        System.Console.WriteLine("The sorted list is:");
        foreach (var x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}