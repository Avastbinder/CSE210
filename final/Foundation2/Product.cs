class Product
{
    private string _name;
    private string _prodID;
    private float _price;
    private int _quantity;
    public Product(string name, string prodID, float price, int quantity)
    {
        _name = name;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
    }

    public double GetPrice()
    {
        return Math.Round((_price * _quantity), 2);
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