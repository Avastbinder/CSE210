abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDesc;
    private int _pointWorth;
    private bool _isComplete;

    public Goal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _pointWorth = pointWorth;
        _isComplete = isComplete;
    }

    public abstract void Completed();
    public abstract string GetListEnding();

    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetComplete()
    {
        if (_isComplete == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDesc()
    {
        return _goalDesc;
    }

    public void RewardPoints()
    {
        _pointWorth += totalPoints;
    }
    
}