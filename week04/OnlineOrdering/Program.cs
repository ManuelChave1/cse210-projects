using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

         Order order1 = new Order();
         order1.SetProduct(new List<Product>
        {
            new Product("LapTop", 123, 150.99, 3),
            new Product("Mouse", 456, 250.00, 2),
            new Product("Monitor", 678, 545.75, 5)
        });

        Order order2 = new Order();
        order2.SetProduct(new List<Product>
        {
            new Product("Cellphone",12345, 500,2),
            new Product("Tablet",67890, 650, 3),
            new Product("Keybord",23415, 870,4)
        });

        order1.SetCustomer(new Customer("Manuel Chave", "street 123", "Matola", "Maputo", "Mozambique"));
        order2.SetCustomer(new Customer("Waldyr Junior",  "123 Main Street", "Springfield", "Illinois", "USA"));


        Console.WriteLine("Order 1 Total Price: $" + order1.OrderTotalPrice());
        Console.WriteLine("Packing Label:\n" + order1.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.ShippingLabel());

        Console.WriteLine("\n\n");

        Console.WriteLine("Order 2 Total Price: $" + order2.OrderTotalPrice());
        Console.WriteLine("Packing Label:\n" + order2.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.ShippingLabel());


        Console.ReadKey();
        

        

    }
}