using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string [] args)
    {
        // Journal
        // Menu
        // PromptMan
        Menu menu = new Menu();
        Journal journal = new Journal();
        
        List<string> dates  = [];
        List<string> prompts  = [];
        List<string> responses  = [];
        bool _quit = false;

        while (_quit != true)
        {
            menu.Display();
            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();
            int choiceInt = Convert.ToInt32(choice);

            if (choiceInt == 1)
            {
                journal.AddEntry();

            }
            else if (choiceInt == 2)
            {
                journal.Save();
            }
            else if (choiceInt == 3)
            {
                journal.Load();
            }
            else if (choiceInt == 4)
            {
                journal.Display();
            }
            else if (choiceInt == 5)
            {
                journal.Search();
            }
            else if (choiceInt == 6)
            {
                System.Console.WriteLine("Thanks for using the program."); 
                _quit = true;
            }

        }
        



 

    }



}