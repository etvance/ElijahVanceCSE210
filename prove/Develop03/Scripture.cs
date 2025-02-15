using System;

public class Scripture
{
    private Reference _reference;
    private List<Verse> _scripture = new List<Verse>();
    private bool done;
    private string _verse1;  // ?
    private string _verse2;  // ? 

    // Console.WriteLine(reference.GetReferenceString());
    public Scripture(Reference reference, string verse1)
    {
        _reference = reference;
        // _scripture.Add(verse1);
        _verse1 = verse1;
    }

    public Scripture(Reference reference, string verse1, string verse2)
    {
        _reference = reference;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    public void BuildVerseList()
    {
        Verse verse1 = new Verse(_verse1);
        Verse verse2 = new Verse(_verse2);
        verse1.BuildWordList();
        verse2.BuildWordList();
        _scripture.Add(verse1);
        _scripture.Add(verse2);
    }
    public void Display()
    {
        _reference.DisplayReference();

        foreach (Verse verse in _scripture)
        {
            verse.DisplayVerse();
        }
    }
    public void HideRandom()
    {
        foreach (Verse verse in _scripture)
        {
            verse.HideWord();
        }
    }
    public bool IsFinished()
    {
        int hiddenVerse = 0;
        int totalVerse = 0;
        foreach (Verse verse in _scripture)
        {
            if (verse.IsFinished() == true)
            {
                hiddenVerse = hiddenVerse + 1;
                totalVerse = totalVerse + 1;
            }
            else
            {
                totalVerse = totalVerse + 1;
            }

        }
        if (totalVerse == hiddenVerse)
        {
            done = true;
        }
        else
        {
            done = false;
        }
        return done;
    }
}