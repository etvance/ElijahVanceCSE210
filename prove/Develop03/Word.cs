using System;

public class Word
{
    private string _singleword;
    private bool _hidden;

    public Word()
    {

    } 
    public Word(string word)
    {
        _singleword = word;
        _hidden = false;
    }

    public bool CheckHidden()
    {
        return _hidden;
    }
    public void DisplayWord()
    {
        Console.Write($"{_singleword} ");
    }

    public void HideWord()
    {
        _hidden = true;
        _singleword = new string('_', _singleword.Length);

    }


}