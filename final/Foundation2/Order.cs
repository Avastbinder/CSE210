class Order
{
    private List<Product> products = new List<Product>();
    public Order()
    {}

    public void AddItem(Product product)
    {
        products.Add(product);
    }

    public void AddAddress(string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country);
    }
}