using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _shortName = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 50;
        _status = false;
    }

    public SimpleGoal(string name, string description, int points, bool status)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        Console.Write($"[{statusSymbol}] {_shortName} ({_description})");
    }
    
    public override int CalculateAGP()
    {
        bool status = IsComplete();
        int aGP = 0;
        if (status == true) {
            aGP = _points;
        } else {
            aGP = 0;
        }
        return aGP;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_shortName},{_description}{_points},{IsComplete().ToString()}";
        return line;
    }
}