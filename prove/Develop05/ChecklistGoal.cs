class ChecklistGoal : Goal
{
    private int _doneTimes;
    private int _totalTimes;
    private int _bonus;

    public ChecklistGoal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete, int totalTimes, int bonus) : base(goalType, goalName, goalDesc, pointWorth, isComplete)
    {
        _doneTimes = 0;
        _totalTimes = totalTimes;
        _bonus = bonus;
    }

    public override void Completed()
    {
        throw new NotImplementedException();
    }

    public override string GetListEnding()
    {
        return $"-- Currently completed: {_doneTimes}/{_totalTimes}";
    }
}