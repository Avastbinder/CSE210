using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Order order1 = new Order("James", "2524 Oakbank Ct", "Saint Cloud", "Florida", "United States of America");
        Order order2 = new Order("Aidan", "440 S 2nd W", "Rexburg", "Idaho", "United States of America");
        Order order3 = new Order("Jonah", "2249 S King George Way", "London", "England", "United Kingdom");
        
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        Product USBconverter = new Product("USBconverter", "5743796", 13.49, 2);
        Product LunchBox = new Product("lunch box", "754008", 20.99, 1);
        Product PhoneStand = new Product("Phone Stand", "183790", 8.78, 1);
        Product FidgetToy = new Product("Fidget toy", "5433567", 4.99, 3);

        order1.AddItem(USBconverter);
        order1.AddItem(FidgetToy);
        order2.AddItem(FidgetToy);
        order2.AddItem(LunchBox);
        order3.AddItem(PhoneStand);
        order3.AddItem(USBconverter);
        order3.AddItem(LunchBox);

        Console.Clear();
        Console.WriteLine("Orders:\n\n-------------");

        foreach(Order order in orders)
        {
            Console.Write("Packing Label:\n");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:\n");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("\nTotal Price:");
            Console.WriteLine(order.GetTotal());
            Console.WriteLine("-------------");
        }
    }
}