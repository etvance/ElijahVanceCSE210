using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Verse
{
    private bool done;
    private string _fullVerse;
    private List<Word> _words = new List<Word>();


    public Verse()
    {

    }
    public Verse(string fullVerse)
    {
        _fullVerse = fullVerse;
    }

    public void BuildWordList()
    {
        string[] wordArray = _fullVerse.Split(' ');
        foreach (string word in wordArray)
        {
            Word _word = new Word(word);
            _words.Add(_word);
        }
    }

    public void DisplayVerse()
    {
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }

    public void HideWord()
    {
        Random random = new Random();
        int _hideQuant = random.Next(1, 4);
        int count = 0;
        int _verseCount = _words.Count();

        while (count <= _hideQuant - 1)
        {
            Random select = new Random();
            int _hideInt = select.Next(_verseCount);
            bool hidden =_words[_hideInt].CheckHidden();
            if (hidden == false)
            {
                _words[_hideInt].HideWord();
                count ++;
            }
        }
    }

    public bool IsFinished()
    {
        int hiddenNum = 0;
        int totalNum = 0;
        foreach (Word word in _words)
        {
            if (word.CheckHidden() == true)
            {
                hiddenNum = hiddenNum + 1;
                totalNum = totalNum + 1;
            }
            else
            {
                totalNum = totalNum + 1;
            }

        }
        if (totalNum == hiddenNum)
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