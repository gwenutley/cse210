public class EternalGoal : Goal
{
    public EternalGoal(string name, string describe, int point)
        : base(name, describe, point)
    {
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal - {GetName()} - {GetDescription()} - {GetPoints()}";
    }
}