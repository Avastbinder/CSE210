class Outdoor : Event
{
    string _weather;
    public Outdoor(string weather, string title, string desc, string date, string time, string type) : base(title, desc, date, time, type)
    {
        _weather = weather;
    }

    public override string GetFullDesc()
    {
        return $"Weather: {_weather}\n\n{base.GetStandardDesc()}";
    }
}