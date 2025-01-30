using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;

class Journal
{
    // vars
    // File name <string>
    // Entries: list<Entry>
    List<Entry> _entries = new List<Entry>();
    string _fileName = "";
    bool changed = false;
    bool loaded = false;
    List<string> dates  = [];
    List<string> prompts  = [];
    List<string> responses  = [];


    
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
    public List<string> Load(List<string> dates, List<string> prompts, List<string> responses)
    {
        System.Console.Write("Where do you want to load the journal from?(____.txt): ");
        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":---");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            dates.Add(date);
            prompts.Add(prompt);
            responses.Add(response);
        }
        loaded = true;
        return dates;
        
        
    }
    public void Display(bool changed, string _filename, List<string> dates, List<string> prompts, List<string> responses)
    {
        if (changed == false && loaded == false)
        {
            Console.WriteLine("There is nothing to Display.\n");
        }
        else if (changed == false && loaded == true)
        {

            int z = 0;
            foreach (string date in dates)
            {
                System.Console.WriteLine();
                Console.Write($"{dates[z]}: {prompts[z]}\n  --{responses[z]}\n\n");
                z += 1;
            }
        }
        else if (changed == true)
        {
            foreach (Entry entry in _entries)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{entry._date}:\n{entry._prompt}\n  --{entry._response}\n\n");
                }
        }

    }

    
    // Save(File Name)
    // Load(File Name)


    

}