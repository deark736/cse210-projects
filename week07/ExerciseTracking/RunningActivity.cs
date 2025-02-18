public class RunningActivity : Activity
{
    // Additional attribute: distance (in miles)
    private double _distance;

    public RunningActivity(DateTime date, double duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / _duration) * 60; // mph

    public override double GetPace() => _duration / _distance; // minutes per mile
}
