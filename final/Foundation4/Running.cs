public class Running : Activity
{
    private double _distance;

    public Running (string date, double duration, double distance) : base (date, duration, "Running")
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override string GetPace()
    {
        return $"{GetDuration()/_distance:F2}";
    }
}