using System;
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    } 

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }


    public string GetSummary()
    {
        string _summary = $"{_studentName} - {_topic}";
        return _summary;
    }
}