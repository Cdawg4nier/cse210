using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Maple Way", "Funkytown", "Colorado", "USA");
        Customer customer1 = new Customer("Martha", address1);
        List<Product> products1 = new List<Product>();
        Product product1a = new Product("Syrup", "11374265", 5.99, 4);
        Product product1b = new Product("Peanut Butter", "11487123", 4.99, 1);
        Product product1c = new Product("Fruit Snacks", "11111111", 2.99, 18);
        products1.Add(product1a);
        products1.Add(product1b);
        products1.Add(product1c);
        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.CalculateCost());

        Console.WriteLine("\n\n\n");

        Address address2 = new Address("9231 Blue Mesa Valley", "Univercity", "Lunaria", "Lunar Colony Alpha 1");
        Customer customer2 = new Customer("Carolina C. Armstrong", address2);
        List<Product> products2 = new List<Product>();
        Product product2a = new Product("Space Suit", "1254981", 500.00, 2);
        Product product2b = new Product("Helmet Cover: Dark Blue", "456183", 49.99, 1);
        Product product2c = new Product("Fruit Snacks", "11111111", 2.99, 180);
        products2.Add(product2a);
        products2.Add(product2b);
        products2.Add(product2c);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.CalculateCost());
    }
}