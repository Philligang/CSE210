using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public Goal() 
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What would you like to name your GOAL? ");
        _name = Console.ReadLine();
        
        Console.Write("Please provide a short description of your GOAL. ");
        _description = Console.ReadLine();
        
        Console.Write("What point value would you like to associate with this GOAL? ");
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);

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