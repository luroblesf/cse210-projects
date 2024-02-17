using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("10441 Caminito Mayten", "San Diego", "CA 91932", "USA");
        Customer customer1 = new Customer("Alice Thompson", address1);
        List<Product> productsList1 = new List<Product>();

        Product p101 = new Product("Notebook", "A105C", 1.99, 2);
        Product p102 = new Product("Math Book", "H201A", 13.50, 1);
        Product p103 = new Product("Crayons", "LK562", 0.99, 6);

        productsList1.Add(p101);
        productsList1.Add(p102);
        productsList1.Add(p103);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        Address address2 = new Address("75 South 200 East", "Provo", "UT 84606", "USA");
        Customer customer2 = new Customer("Matt Henderson", address2);
        List<Product> productsList2 = new List<Product>();

        Product p201 = new Product("Chocolate M&M", "C501L", 4.99, 2);
        Product p202 = new Product("Pepsi Can", "PS5268", 0.75, 6);
        Product p203 = new Product("Apples", "A100P", 3.00, 4);

        productsList2.Add(p201);
        productsList2.Add(p202);
        productsList2.Add(p203);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        
        Address address3 = new Address("2010 W 500 S", "Salt Lake", "UT 84104", "USA");
        Customer customer3 = new Customer("Dario G. Mostacero", address3);
        List<Product> productsList3 = new List<Product>();

        Product p301 = new Product("Miracle Gro", "F993W", 16.50, 1);
        Product p302 = new Product("Dollhouse Toys", "H579AE", 29.97, 1);
        Product p303 = new Product("Milk Gallon ", "743EBT", 3.44, 2);

        productsList3.Add(p301);
        productsList3.Add(p302);
        productsList3.Add(p303);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
