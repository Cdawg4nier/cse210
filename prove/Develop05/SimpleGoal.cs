public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDetail, int pointValue) : base(goalName, goalDetail, pointValue, "simple")
    {

    }

    public override string GetDetailsString()
    {
        string addon = "";
        if (IsComplete())
        {
            addon = "[Completed]";
        }
        return base.GetDetailsString() + addon;
    }
    public override int RecordEvent()
    {
        if (IsComplete()) {return 0;}
        Complete();
        return GetPointValue();
    }
    // Simple : (goal) (one and done)
}