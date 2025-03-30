

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double OrderTotal()
    {
        double totalprice = 0;
        foreach (Product p in _products)
        {
            double productPrice = p.CalculateProductPrice();
            totalprice += productPrice;
        }
        bool inUS = _customer.CheckLocation();
        if (inUS)
        {
            totalprice += 5.00;
        }
        else
        {
            totalprice += 35.00;
        }
        return totalprice;
    }
    public void DisplayPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"Product: {p.GetName()} \nProduct ID:{p.GetID()}\n");
        } 
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetName()} \nAddress: {_customer.GetAddress()}\n");
    }
}