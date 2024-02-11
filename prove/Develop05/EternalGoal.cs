using System;

public class EternalGoal : Goal
{
    private int _targetCounter;

    public EternalGoal()
    {
        _shortName = "";
        _description = "";
        _points = 50;
        _targetCounter = 0;
    }
    public EternalGoal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _targetCounter = 0;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_shortName} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _shortName + "," + _description + "," + _points.ToString();
        return line;
    }

    public override void RecordEvent()
    {
         _targetCounter ++;
    }
    public override int CalculateAGP()
    {
        int points = _points;
        return points;
    }
}