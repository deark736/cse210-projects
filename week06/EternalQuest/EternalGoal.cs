// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete.
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Format: EternalGoal:Name,Description,Points
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
