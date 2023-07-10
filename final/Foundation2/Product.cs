class Product
{
    private string _name;
    private string _prodID;
    private double _price;
    private int _quantity;
    public Product(string name, string prodID, double price, int quantity)
    {
        _name = name;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProdID()
    {
        return _prodID;
    }
}