using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _status;

    public Goal() 
    {
        _shortName = "Test Name";
        _description = "Test Description";
        _points = 50;
        _status = false;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringPoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringPoints);

        _status = false;
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}