using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;

public class Journal
{
    // vars
    // File name <string>
    // Entries: list<Entry>
    List<Entry> _entries = new List<Entry>();
    List<Entry> _loaded_entries = new List<Entry>();
    string _fileName = "";
    bool changed = false;
    bool loaded = false;


    
    // methods


    public bool AddEntry()
    {
        Entry newEntry = new Entry();

        PromptMan _entryPrompt = new PromptMan();
        
        string prompt = Convert.ToString(_entryPrompt);

        Console.WriteLine("Enter Date(mm/dd/yyyy): ");
        string date = Console.ReadLine();
        newEntry._date = date;

        Console.WriteLine("Here is todays prompt:");
        prompt = _entryPrompt.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        newEntry._prompt = prompt;

        System.Console.WriteLine("Journal Entry: ");
        string response = Console.ReadLine();
        newEntry._response = response;
        System.Console.WriteLine();


        _entries.Add(newEntry);
        changed = true;
        return changed;
    }
    //Write AddEntry
        // -Get prompt
        // -Display Prompt
        // -Get Date
        // -Get Response
        // -Create Entry
        // -Save to list in journal

    public void Save()
    {
        if (changed == true)
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
        Entry loadedEntry = new Entry();
        System.Console.Write("Where do you want to load the journal from?(____.txt): ");
        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
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
        if (changed == true && loaded == true)
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
        else if (changed == true && loaded == false)
        {
            foreach (Entry entry in _entries)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{entry._date}:\n{entry._prompt}\n  --{entry._response}\n\n");
                }
        }
        else if (changed == false && loaded == true)
        {

            foreach (Entry entry in _loaded_entries)
            {
                System.Console.WriteLine();
                Console.Write($"{entry._date}: {entry._prompt}\n  --{entry._response}\n\n");
            }
        }
        
        

    }
    public void Search()
    {
        if (loaded == true || changed == true)
        {
            Console.Write("What date would you like to look for?(mm/dd/yyyy): ");
            string search_date = Console.ReadLine();
            foreach (Entry entry in _loaded_entries)
            {
                string date = entry._date;
                System.Console.WriteLine($"---------{date}---------");
                if ( entry._date == search_date)
                {
                    Console.Write($"{entry._date}: {entry._prompt}\n  --{entry._response}\n\n");
                    Console.WriteLine();
                } 

            }
            foreach (Entry entry in _entries)
            {
                string date = entry._date;
                System.Console.WriteLine($"---------{date}---------");
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