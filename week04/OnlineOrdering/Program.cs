using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Apple", "A1234", 1.5, 10);
        Product product2 = new Product("Banana", "B1234", 0.25, 1);
        Product product3 = new Product("Cat", "C1234", 125, 1);
        Product product4 = new Product("Dog", "D1234", 5000, 1);
        Product product5 = new Product("Eggs", "E1234", 15.50, 6);
        Product product6 = new Product("Flute", "F1234", 50, 1);
        Product product7 = new Product("Gloves", "G1234", 6.75, 2);
        Product product8 = new Product("House", "H1234", 0.25, 1);

        Address address1 = new Address("123 South street", "Boise", "Idaho", "USA");
        Customer customer1 = new Customer("Jane", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine($"Total Order Cost: ${order1.CalcOrderCost():0.00}");
        Console.WriteLine($"Packing label: {order1.GetPackingLabel()}");
        Console.WriteLine($"Ship label: {order1.GetShippingLabel()}");
        Console.WriteLine();


        Address address2 = new Address("456 North street", "Guadalajara", "Jalisco", "Mexico");
        Customer customer2 = new Customer("Fabian", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);

        Console.WriteLine($"Total Order Cost: ${order2.CalcOrderCost():0.00}");
        Console.WriteLine($"Packing label: {order2.GetPackingLabel()}");
        Console.WriteLine($"Ship label: {order2.GetShippingLabel()}");
        Console.WriteLine();

    }
}