class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address()
    {
    }

    public string GetAddressInfo()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public void SetAddressInfo(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}