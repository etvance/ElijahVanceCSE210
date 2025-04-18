using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentname, string topic, string title) : base(studentname, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentname = GetStudentName();
        string _writingInfo = $"{_title} - {studentname}";
        return _writingInfo;
    }
}