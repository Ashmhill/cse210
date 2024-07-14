// Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "BC", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Widget", "W123", 2.50, 4);
        Product product2 = new Product("Gadget", "G456", 3.75, 2);
        Product product3 = new Product("Doodad", "D789", 1.25, 10);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.TotalCost():0.00}");
        Console.WriteLine();
    }
}
