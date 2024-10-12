using System;

class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order(
            new Customer("Attah Collins", new Address("441 4th street", "NW City", "Washington State", "USA")),
            new List<Product>
            {
                new Product("Instrument", "1111", 19.99, 3),
                new Product("Tester", "1112", 29.99, 1),
            }
        );

        var order2 = new Order(
            new Customer("Eucharia Chi", new Address("No 1 Emmanuel Close Rumukwurusi Pipeline", "Port Harcourt", "Rivers", "Nigeria")),
            new List<Product>
            {
                new Product("Nozzles", "991", 39.99, 2),
                new Product("Kick", "992", 9.99, 5),
            }
        );

        Console.WriteLine("Order 1\n--------");

        Console.WriteLine($"Packing Label:\n{order1.PackingLabel()}");

        Console.WriteLine($"\nShipping Label:\n{order1.ShippingLabel()}");

        Console.WriteLine($"\nTotal Cost: ${order1.TotalCost():0.00}");

        Console.WriteLine("\nOrder 2\n--------");

        Console.WriteLine($"Packing Label:\n{order2.PackingLabel()}");

        Console.WriteLine($"\nShipping Label:\n{order2.ShippingLabel()}");

        Console.WriteLine($"\nTotal Cost: ${order2.TotalCost():0.00}");
    }
}