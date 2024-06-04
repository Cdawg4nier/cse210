using System.Runtime;

public abstract class Activity
{
    private string _date;
    private double _duration;
    private string _activityType;

    public Activity(string date, double duration, string activityType)
    {
        _date = date;
        _duration = duration;
        _activityType = activityType;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract string GetPace();

    public double GetDuration()
    {
        return _duration;
    }
    public virtual string Summary()
    {
        return $"{_date} {_activityType} ({_duration} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}