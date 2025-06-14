using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string describe, int points) 
        : base(name, describe, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        string checkbox = "[ ]";
        if (_isComplete == true)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} - {GetName()} - {GetDescription()} - {GetPoints()}";
    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal - {GetName()} - {GetDescription()} - {GetPoints()}";
    }
    

}