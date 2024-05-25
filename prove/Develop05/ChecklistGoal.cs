public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _currentCompletions;
    private int _maxCompletions;
    public ChecklistGoal (string goalName, string goalDetail, int pointValue, int maxCompletions, int bonusPoints) : base(goalName, goalDetail, pointValue, "checklist")
    {
        _bonusPoints = bonusPoints;
        _currentCompletions = 0;
        _maxCompletions = maxCompletions;
    }

    public override int RecordEvent()
    {
        if (IsComplete()) {return 0;}
        _currentCompletions += 1;
        if (_currentCompletions == _maxCompletions)
        {
            Complete();
            return GetPointValue() + _bonusPoints;
        }
        return GetPointValue();

    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $": Completions [{_currentCompletions} / {_maxCompletions}]";
    }
    public int AwardBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetCurrentCompletions(int i)
    {
        _currentCompletions = i;
    }
    public override string GetStringRepresentation()
    {
        string myString = base.GetStringRepresentation();
        myString += $",{_maxCompletions},{_bonusPoints},{_currentCompletions}";
        return myString;
    }
    // Checklist : (goal) (Small points every completion, and then a bonus for reaching the total amount)
}