using System;

public class Job 
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}


// Responsibilities:
//      Keeps track of the company, job title, start year, and end year.
// Behaviors:
//      Displays the job information in the format "Job Title (Company) StartYear-EndYear", 
//      for example: "Software Engineer (Microsoft) 2019-2022".