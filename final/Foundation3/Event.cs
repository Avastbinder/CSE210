abstract class Event
{
    Address address = new Address();
    string _title;
    string _desc;
    string _date;
    string _time;
    string _type;

    public Event(string title, string desc, string date, string time, string type)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _type = type;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        address.SetAddress(street, city, state, country);
    }

    public abstract string GetFullDesc();
    public string GetShortDesc()
    {
        return $"{_type}\n{_title}\n{_date}";
    }

    public string GetStandardDesc()
    {
        return $"{_title}\n{_desc}\n{_date}\n{_time}\n\n{address.GetAddress()}";
    }

    public string GetTitleDate()
    {
        return $"{_title}\n{_date}";
    }
    
    public string GetEventType()
    {
        return _type;
    }
    
}