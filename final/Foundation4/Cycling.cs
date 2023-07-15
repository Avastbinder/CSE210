class Cycling : Excercise
{
    double _speed;
    double _time;
    public Cycling(string type, string date, double time, double speed) : base(type, date, time)
    {
        _speed = speed;
        _time = time;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed*(_time/60), 2);
    }

    public override double GetPace()
    {
        return Math.Round(_time/(_speed*(_time/60)), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
}