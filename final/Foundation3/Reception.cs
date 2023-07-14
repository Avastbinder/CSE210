class Reception : Event
{
    string _RSVP;
    public Reception(string RSVP, string title, string desc, string date, string time, string type) : base(title, desc, date, time, type)
    {
        _RSVP = RSVP;
    }

    public override string GetFullDesc()
    {
        return $"{_RSVP}\n\n{base.GetStandardDesc()}";
    }
}