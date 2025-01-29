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
        
        bool changed = false;
        string _filename = "";
        List<string> dates  = [];
        List<string> prompts  = [];
        List<string> responses  = [];
        bool _quit = false;

        while (_quit != true)
        {
            menu.Display();
            Console.WriteLine("Enter Choice: ");
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
                journal.Load(dates, prompts, responses);
            }
            else if (choiceInt == 4)
            {
                journal.Display( changed,  _filename, dates, prompts, responses);
            }
            else if (choiceInt == 5)
            {
                _quit = true;
            }

        }
        

        // AddEntry()
        // Load()
            // -Prompt User for file name
        // Save()
            // -Prompt User for file name
            
        // Quit



 

    }



}