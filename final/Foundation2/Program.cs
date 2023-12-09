using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        List<Product> products1 = new List<Product>
        {
            new Product("Product 1", 1, 10.0, 1),
            new Product("Product 2", 2, 20.0, 2),
            new Product("Product 3", 3, 30.0, 3)
        };
        Customer customer1 = new Customer("Customer 1", new Address("123 Main St", "New York", "NY", "USA", "USA"));
        Order order1 = new Order(products1, customer1);
        orders.Add(order1);

        List<Product> products2 = new List<Product>
        {
            new Product("Product 4", 4, 40.0, 1),
            new Product("Product 5", 5, 50.0, 2),
            new Product("Product 6", 6, 60.0, 3)
        };
        Customer customer2 = new Customer("Customer 2", new Address("456 Second St", "Toronto", "ON", "Canada", "CA"));
        Order order2 = new Order(products2, customer2);
        orders.Add(order2);

        foreach (var order in orders)
        {
            Console.WriteLine($"Packing Label: {order.PackingLabel()}");
            Console.WriteLine($"Shipping Label: {order.ShippingLabel()}");
            Console.WriteLine($"Total Price: ${order.TotalPrice()}");
        }
    }
}


