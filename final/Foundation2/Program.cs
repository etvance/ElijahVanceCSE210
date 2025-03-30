using System;

class Program
{
    static void Main(string[] args)
    {
        Address jacobAddress = new Address("123 blooming Street", "Rexburg", "Idaho", "USA", true);
        Customer jacob = new Customer("Jacob Doolittle", jacobAddress);
        
        Address SpongeBobAddress = new Address ("124 Conch Street", "Bikini Bottom", "Bikini Atoll", "Pacific Ocean", false);
        Customer spongebob = new Customer ("SpongeBob Squarepants", SpongeBobAddress);

        Product item1 = new Product("3D printer", "5698Y3B", 734.00, 2);
        Product item2 = new Product("Settlers of Catan", "33M2PT3", 29.99, 5);
        Product item3 = new Product("Colt 45", "99220P1", 300.50, 1);
        Product item4 = new Product("Toilet Paper 6 Pack", "44H3DC1", 10.00, 13);
        Product item5 = new Product("Flat screen TV", "00RT541", 152.99, 3);
        Product item6 = new Product("Dog Coller", "21SSE32", 3.99, 2);

        Order jacobOrder = new Order(jacob);
        jacobOrder.AddProduct(item1);
        jacobOrder.AddProduct(item3);
        jacobOrder.AddProduct(item5);

        Order spongeBobOrder = new Order(spongebob);
        spongeBobOrder.AddProduct(item2);
        spongeBobOrder.AddProduct(item4);
        spongeBobOrder.AddProduct(item6);

        double totalPriceJacob = Math.Round(jacobOrder.OrderTotal(), 2);
        double totalPriceSpongeBob = Math.Round(spongeBobOrder.OrderTotal(), 2); 

        System.Console.WriteLine("---------------------------------------------");
        jacobOrder.DisplayShippingLabel();
        jacobOrder.DisplayPackingLabel();
        Console.WriteLine($"Your total comes to ${totalPriceJacob}.\n");
        System.Console.WriteLine("---------------------------------------------\n");

        System.Console.WriteLine("---------------------------------------------");
        spongeBobOrder.DisplayShippingLabel();
        spongeBobOrder.DisplayPackingLabel();
        Console.WriteLine($"Your total comes to ${totalPriceSpongeBob}.");
        System.Console.WriteLine("---------------------------------------------");
    }
}