public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string describe, int points, int target, int bonus) 
        : base(name, describe, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountComplete()
    {
        return _amountComplete;
    }

    public void SetAmountComplete(int value)
    {
        _amountComplete = value;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountComplete = _amountComplete + 1;
        }


    }

    public override bool IsComplete()
    {
        if (_amountComplete >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        string checkbox = "[ ]";
        if (IsComplete() == true)
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {GetName()} - {GetDescription()} - currently conpleted: ({_amountComplete}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}- {GetDescription()} - {GetPoints()} - {_bonus} - {_target} - ({_amountComplete})";
    }
}