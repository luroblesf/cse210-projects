using System;
public class Job
{
    public string _jobTitle;
    public string _nameCompany;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_nameCompany}) {_startYear}-{_endYear}");
    }
}