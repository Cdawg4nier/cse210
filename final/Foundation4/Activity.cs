using System.Runtime;

public abstract class Activity
{
    private string _date;
    private double _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract string GetPace();
    public abstract string Summary();
}