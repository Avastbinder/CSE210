class EternalGoal : Goal
{
    public EternalGoal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete) : base(goalType, goalName, goalDesc, pointWorth, isComplete)
    {

    }

    public override void Completed()
    {
        throw new NotImplementedException();
    }

    public override string GetListEnding()
    {
        return "";
    }
}