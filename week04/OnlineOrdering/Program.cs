using System;

class Program
{
    static void Main(string[] args)
    {
        // Dirección y clientes
        Address addr1 = new Address("123 Spider St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Peter Parker", addr1);

        Address addr2 = new Address("456 Dragon Rd", "Tokyo", "Tokyo", "Japan");
        Customer cust2 = new Customer("Goku", addr2);

        // Productos
        Product prod1 = new Product("Spiderman Figure", "SP001", 15.99, 2);
        Product prod2 = new Product("PS5 Game: Spider-Man", "VG001", 69.99, 1);
        Product prod3 = new Product("Dragon Ball Manga Vol.1", "DB001", 9.99, 3);
        Product prod4 = new Product("Dragon Ball Action Figure", "DB002", 19.99, 1);
        Product prod5 = new Product("Nintendo Switch Game", "VG002", 59.99, 1);

        // Orden 1
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        // Orden 2
        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);

        // Mostrar resultados
        Console.WriteLine("=== Orden 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice():0.00}\n");

        Console.WriteLine("=== Orden 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice():0.00}");
    }
}