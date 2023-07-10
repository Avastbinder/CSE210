class Customer
{
    private string _name;
    Address address = new Address();

    public Customer()
    {}

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddressInfo(string street, string city, string state, string country)
    {
        address.SetAddressInfo(street, city, state, country);
    }

    public string GetAddressInfo()
    {
        return address.GetAddressInfo();
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsUSA()
    {
        return address.IsUSA();
    }
}