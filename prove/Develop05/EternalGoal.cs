public class EternalGoal : Goal
{

    private int _streak;
    private int _bonusPoints;
    public EternalGoal (string goalName, string goalDetail, int pointValue, int bonusPoints) : base (goalName, goalDetail, pointValue, "eternal")
    {
        _bonusPoints = bonusPoints;
        _streak = 0;
    }

    public override int RecordEvent()
    {
        _streak += 1;
        return GetPointValue() + (_streak * _bonusPoints);
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $": Streak: {_streak} * {_bonusPoints} XP";
    }
    public int AwardBonusPoints()
    {
        return _bonusPoints * _streak;
    }

    public void SetStreak(int i)
    {
        _streak = i;
    }
    public override string GetStringRepresentation()
    {
        string myString = base.GetStringRepresentation();
        myString += $",{_bonusPoints},{_streak}";
        return myString;
    }
}