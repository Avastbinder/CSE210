abstract class Excercise
{
    string _date;
    double _time;
    string _type;
    public Excercise(string type, string date, double time)
    {
        _date = date;
        _time = time;
        _type = type;
    }

    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract double GetDistance();

    public string GetSummary()
    {
        return $"{_date} {_type} ({_time} min)\nDistance: {GetDistance()} miles\nSpeed: {GetSpeed()} mph\nPace: {GetPace()} min per mile";
    }
}