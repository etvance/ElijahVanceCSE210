using System;
using System.Data.SqlTypes;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentname, string topic, string textbookSection, string problems) : base(studentname, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string HomeworkList = $"Sections {_textbookSection}- {_problems}";
        return HomeworkList;
    }
}