class SimpleGoal : Goal
{
    public SimpleGoal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete) : base(goalType, goalName, goalDesc, pointWorth, isComplete)
    {
    }

    public override void Completed()
    {
        _isComplete = true;
    }

    public override string GetListEnding()
    {
        return "";
    }

    
}