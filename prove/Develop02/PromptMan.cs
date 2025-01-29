using System;

class PromptMan
{
    List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", 
        "How did I show gratitude today?", "What did I do to help others today?", 
        "What did I do today that made me proud of myself?"
        };

    public string GetRandomPrompt()
    {
        int _totalPrompts = 0;

        foreach (string prompt in _prompts )
        {
            _totalPrompts += 1;
        }
        Random random = new Random();

        int promptNumber = random.Next(_totalPrompts); // number between 0 and 99

        string _entryPrompt = _prompts[promptNumber];
        return _entryPrompt;
    }
}