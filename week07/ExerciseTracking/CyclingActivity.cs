public class CyclingActivity : Activity
{
    // Additional attribute: speed (in mph)
    private double _speed;

    public CyclingActivity(DateTime date, double duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    // For cycling, speed is provided.
    public override double GetSpeed() => _speed;

    // Calculate distance using: distance = speed (mph) * (duration in minutes / 60)
    public override double GetDistance() => _speed * (_duration / 60);

    public override double GetPace()
    {
        double distance = GetDistance();
        return _duration / distance;
    }
}
