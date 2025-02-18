// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = _points;
        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
        }
        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Overridden to include progress details.
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal:Name,Description,Points,amountCompleted,target,bonus
        return $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
