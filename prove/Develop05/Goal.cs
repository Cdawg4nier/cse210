public abstract class Goal
{
    private string _goalName;
    private string _goalDetails;
    private int _pointValue;
    private string _goalType;

    private bool _isComplete;

    public Goal(string goalName, string goalDetail, int pointValue, string goalType)
    {
        _goalName = goalName;
        _goalDetails = goalDetail;
        _pointValue = pointValue;
        _isComplete = false;
        _goalType = goalType;
    }
    public virtual string GetDetailsString()
    {
        return $"{_goalName}: {_goalDetails} ({_pointValue} XP)";
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public int AwardPoints()
    {
        return _pointValue;
    }

    public abstract int RecordEvent();

    public bool IsComplete()
    {
        return _isComplete;
    }

    public void Complete()
    {
        _isComplete = true;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }
    public virtual string GetStringRepresentation()
    {
        string myString = $"{_goalType},{_goalName},{_goalDetails},{_pointValue},{_isComplete}";
        return myString;
    }
}