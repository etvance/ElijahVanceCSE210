using System;
using System.Reflection;

public class Program
{
    static void Main()
    {
        bool breath = false;
        bool reflect = false;
        bool list = false;
        bool ask = true;
        bool done = false;
        Menu menu = new Menu();

        while (done == false)
        {
            menu.DisplayMenu();
            System.Console.WriteLine("Select a choice from the menu: ");
            string _stringChoice = Console.ReadLine();
            int _choice = int.Parse(_stringChoice);
            // Console.WriteLine("Hello Develop04 World!");

            if (_choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathing();
                breath = true;
            }

            else if (_choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.RunReflection();
                reflect = true;
            }

            else if (_choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.RunListing();
                list = true;
            }

            else if (_choice == 4)
            {
                done = true;
            }

            if (breath == true && reflect == true && list == true && ask == true)
            {
                menu.DisplayFinishMenu();
                System.Console.WriteLine("What would you like to do?");
                string _stringsecondChoice = Console.ReadLine();
                int _secondchoice = int.Parse(_stringsecondChoice);

                if (_secondchoice == 1)
                {
                    ask = false;
                }
                else if ( _secondchoice == 2)
                {
                    done = true;
                }
            }

        }
        Console.Clear();
        System.Console.WriteLine("Thank you for being mindfull with us! Come back soon!");
    }
}