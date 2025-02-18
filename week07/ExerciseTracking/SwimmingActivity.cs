public class SwimmingActivity : Activity
{
    // Additional attribute: number of laps (each lap is 50 meters)
    private int _laps;

    public SwimmingActivity(DateTime date, double duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    // Calculate distance in miles using the conversion:
    // Distance (miles) = laps * 50 / 1000 * 0.62
    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62;

    public override double GetSpeed() => (GetDistance() / _duration) * 60;

    public override double GetPace() => _duration / GetDistance();
}
