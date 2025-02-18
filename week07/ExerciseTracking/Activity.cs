using System;

public abstract class Activity
{
    // Shared attributes for all activities.
    protected DateTime _date;
    protected double _duration; // in minutes

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    // Abstract methods to be overridden.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method to produce a summary string.
    public virtual string GetSummary()
    {
        // Summary format: "03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile"
        string summary = $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min)- " +
                         $"Distance {GetDistance():0.0} miles, " +
                         $"Speed {GetSpeed():0.0} mph, " +
                         $"Pace: {GetPace():0.0} min per mile";
        return summary;
    }
}
