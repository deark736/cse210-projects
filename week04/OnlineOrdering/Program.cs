using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products for Order 1.
            Product prod1 = new Product("Laptop", "LP1001", 999.99, 1);
            Product prod2 = new Product("Wireless Mouse", "WM2002", 25.50, 2);
            Product prod3 = new Product("Keyboard", "KB3003", 45.00, 1);

            // Create a customer with a USA address.
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("Alice Johnson", address1);

            // Create Order 1 and add products.
            Order order1 = new Order(customer1);
            order1.AddProduct(prod1);
            order1.AddProduct(prod2);
            order1.AddProduct(prod3);

            // Create products for Order 2.
            Product prod4 = new Product("Smartphone", "SP4004", 799.99, 1);
            Product prod5 = new Product("Headphones", "HP5005", 99.99, 1);

            // Create a customer with an international address.
            Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
            Customer customer2 = new Customer("Bob Smith", address2);

            // Create Order 2 and add products.
            Order order2 = new Order(customer2);
            order2.AddProduct(prod4);
            order2.AddProduct(prod5);

            // Add both orders to a list.
            List<Order> orders = new List<Order> { order1, order2 };

            // Display the packing label, shipping label, and total cost for each order.
            foreach (Order order in orders)
            {
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
