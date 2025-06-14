public class Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;

    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailString()
    {
        return $"[ ] {_goalName} - {_description} - {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_goalName} - {_description} - {_points}";
    }
}