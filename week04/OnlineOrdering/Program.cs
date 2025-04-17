using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("13 Adeola Odeku St", "Victoria Island", "Lagos", "Nigeria");
        Address address2 = new Address("456 Ring Road", "Ibadan", "Oyo", "Nigeria");
        Address address3 = new Address("14 Ibara Housing", "Abeokuta", "Ogun", "Nigeria");

        Customer customer1 = new Customer("Caleb Kelikume", address1);
        Customer customer2 = new Customer("Azeez Babajide", address2);
        Customer customer3 = new Customer("Tolani Yusuf", address3);

        // Create products
        Product product1 = new Product("Soundbar", "G2", 71.00, 3);
        Product product2 = new Product("Phone", "D35", 26.50, 3);
        Product product3 = new Product("Router", "B42", 76.50, 3);
        Product product4 = new Product("Lamp", "A6", 119.50, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product2);
        
        Order order3 = new Order(customer3);
        order3.AddProduct(product4);
        order3.AddProduct(product2);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost()}");

    }
    
}
