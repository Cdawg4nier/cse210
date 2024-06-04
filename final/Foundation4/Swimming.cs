public class Swimming : Activity
{
    private int _laps;

    public Swimming (string date, double duration, int laps) : base (date, duration, "Swimming")
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps*50/1000*.62;
    }

    public override double GetSpeed()
    {
        return ( GetDistance() / GetDuration() ) * 60;
    }

    public override string GetPace()
    {
        return $"{60/GetSpeed():F2}";
    }
}