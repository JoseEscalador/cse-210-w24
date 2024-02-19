using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Anytown", "Anystate", "USA");
        Address address2 = new Address("456 Random Street", "Anytown", "Anystate", "Brazil");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Diongleidson Pereira", address2);

        Product product1 = new Product("Refrigerator", 123, 800, 3);
        Product product2 = new Product("Washing Machine", 223, 600, 2);
        Product product3 = new Product("Microwave", 263, 150, 5);
        Product product4 = new Product("Dishwasher", 523, 700, 1);
        Product product5 = new Product("Steel Table", 714, 500, 1);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("\nOrder 1 Packing Label:\n");
        order1.PackingLabel();
        Console.WriteLine("\nOrder 1 Shipping Label:\n");
        order1.ShippingLabel();
        Console.WriteLine($"\nOrder 1 Total Cost: ${order1.totalCost().ToString("F2")}");

        Console.WriteLine("\n----------------------------");
        
        Console.WriteLine("\nOrder 2 Packing Label:\n");
        order2.PackingLabel();
        Console.WriteLine("\nOrder 2 Shipping Label:\n");
        order2.ShippingLabel();
        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.totalCost().ToString("F2")}");
    }
}