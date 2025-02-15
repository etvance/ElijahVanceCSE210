using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private bool _multiVersed;

    public Reference()
    {

    }

    public Reference(string book, int chapter, int startverse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startverse;
        _multiVersed = false;
    }
    
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startverse;
        _verseEnd = endverse;
        _multiVersed = true;
    }

    public void DisplayReference()
    {
        if (_multiVersed == true)
        {
            System.Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
        else
        {
            System.Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        }
        
    }

}