// NegativeGoal.cs
public class NegativeGoal : Goal
{
    private bool _isTriggered;

    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isTriggered = false;
    }

    public override int RecordEvent()
    {
        if (!_isTriggered)
        {
            _isTriggered = true;
            // Subtract points (points are stored as positive but deducted when triggered)
            return -_points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        // Once triggered, the negative goal is considered "complete"
        return _isTriggered;
    }

    public override string GetStringRepresentation()
    {
        // Format: NegativeGoal:Name,Description,Points,isTriggered
        return $"NegativeGoal:{_name},{_description},{_points},{_isTriggered}";
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) [Loses {_points} points if triggered]";
    }
}
