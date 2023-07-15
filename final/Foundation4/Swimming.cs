class Swimming : Excercise
{
    double _laps;
    double _time;
    public Swimming(string type, string date, double time, double laps) : base(type, date, time)
    {
        _laps = laps;
        _time = time;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps*50/1000*0.62, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_time/(_laps*50/1000*0.62), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(60/(_time/(_laps*50/1000*0.62)), 2);
    }
}