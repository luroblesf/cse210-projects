using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _target;
    private int _targetCounter;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int  target, int  targetCounter)
    {
        _shortName = name;
        _description = description;
        _points = goalPoints;
        _bonusPoints = bonusPoints;
        _target =  target;
         _targetCounter =  targetCounter;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistTarget = Console.ReadLine();
         _target = Convert.ToInt32(stringChecklistTarget);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        _targetCounter = 0;

    }

    public override bool IsComplete() 
    {
        if ( _targetCounter >=  _target) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _targetCounter ++;
    }

    public override int CalculateAGP()
    {
        int points = 0;

        points = _targetCounter * _points;

        bool status = IsComplete();

        if (status == true) {
            points += _bonusPoints;
        }

        return points;

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

        Console.Write($"[{statusSymbol}] {_shortName} ({_description}) -- Currently Completed {_targetCounter}/{_target}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _shortName + "," + _description + "," + _points.ToString() + "," + _bonusPoints.ToString() + "," +  _target.ToString() + "," + _targetCounter.ToString();
        return line;
    }

}