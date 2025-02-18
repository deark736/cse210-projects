// Goal.cs
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Each goal must implement how an event is recorded and how many points are awarded.
    public abstract int RecordEvent();
    
    // Tells whether the goal is complete. (For eternal goals this is always false.)
    public abstract bool IsComplete();
    
    // Returns a string representation for saving to file.
    public abstract string GetStringRepresentation();

    // Returns a display string. By default shows a checkbox based on completion status.
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description})";
    }
}
