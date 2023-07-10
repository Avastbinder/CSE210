class Order
{
    Customer customer = new Customer();
    private List<Product> products = new List<Product>();
    public Order(string name, string street, string city, string state, string country)
    {
        customer.SetName(name);
        customer.SetAddressInfo(street, city, state, country);
    }

    public void AddItem(Product product)
    {
        products.Add(product);
    }

    public double GetTotal()
    {
        double total = 5;
        foreach (Product product in products)
        {
            total += product.GetPrice();
        }

        if (customer.IsUSA() == false)
        {
            total += 30;
        }

        return Math.Round(total, 2);;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProdID()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddressInfo()}";
    }
}