using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<Entry> _loaded_entries = new List<Entry>();
    string _fileName = "";
    bool changed = false;
    bool loaded = false;

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        PromptMan _entryPrompt = new PromptMan();

        Console.WriteLine("Enter Date(mm/dd/yyyy): ");
        string date = Console.ReadLine();
        newEntry._date = date;

        Console.WriteLine("Here is todays prompt:");
        string prompt = _entryPrompt.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        newEntry._prompt = prompt;

        System.Console.WriteLine("Journal Entry: ");
        string response = Console.ReadLine();
        newEntry._response = response;
        System.Console.WriteLine();//for spacing

        _entries.Add(newEntry);
        changed = true;
    }

    public void Save()
    {
        if (changed == true)//actually stuff to save
        {
            System.Console.Write("Where do you want to save the journal?(____.txt): ");
            _fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_fileName, true))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}:---{entry._prompt}:---{entry._response}:");
                }
            }
        }
        else
        {
            System.Console.WriteLine("There aren't any changes to save.\n");
        }
    }
    public void Load()
    {
        
        System.Console.Write("Where do you want to load the journal from?(____.txt): ");
        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Entry loadedEntry = new Entry();
            string[] parts = line.Split(":---");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            
            loadedEntry._date = date;
            loadedEntry._prompt = prompt;
            loadedEntry._response = response;
            _loaded_entries.Add(loadedEntry);
        }
        loaded = true;
    }
    public void Display()
    {
        if (changed == true || loaded == true)
        {
            foreach (Entry entry in _loaded_entries)
            {
                System.Console.WriteLine();
                Console.Write($"{entry._date}: {entry._prompt}\n  --{entry._response}\n\n");
            }
            foreach (Entry entry in _entries)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"{entry._date}:\n{entry._prompt}\n  --{entry._response}\n\n");
            }
        }
        else if (changed == false && loaded == false)
        {
            Console.WriteLine("There is nothing to Display. Please Load a file or Add an Entry.\n");
        }   
    }
    public void Search()
    {
        if (loaded == true || changed == true)//Is there stuff to search though?
        {
            Console.Write("What date would you like to look for?(mm/dd/yyyy): ");
            string search_date = Console.ReadLine();
            foreach (Entry entry in _loaded_entries)
            {
                if (entry._date == search_date)
                {
                    Console.Write($"{entry._date}: {entry._prompt}\n  --{entry._response}\n\n");
                    Console.WriteLine();
                }
            }
            //Put the loaded Entries before the newly created entries
            foreach (Entry entry in _entries)
            {
                if ( entry._date == search_date)
                {
                    Console.Write($"{entry._date}: {entry._prompt}\n  --{entry._response}\n\n");
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("There is nothing to search. Please Load a file to try again.");
        }
    }
}