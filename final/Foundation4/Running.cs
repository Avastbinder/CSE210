class Running : Excercise
{
    double _distance;
    double _time;
    public Running(string type, string date, double time, double distance) : base(type, date, time)
    {
        _distance = distance;
        _time = time;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_time/_distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(60/(_time/_distance), 2);
    }
}