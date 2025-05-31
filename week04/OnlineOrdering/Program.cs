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

        

        Console.WriteLine($"Total Order Cost: {order1.CalcOrderCost():0.00}");
        Console.WriteLine($"Pack label: {order1.GetPackingLabel()}");
        Console.WriteLine($"Ship label: {order1.GetShippingLabel()}");

    }
}