class Lecture : Event
{
    string _speaker;
    string _capacity;
    public Lecture(string speaker, string capacity, string title, string desc, string date, string time, string type) : base(title, desc, date, time, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDesc()
    {
        return $"Speaker: {_speaker}\n{_capacity} capacity\n\n{base.GetStandardDesc()}";
    }
}