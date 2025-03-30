

public class Product
{
    private string _name;
    private string _id;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string ID, double price, int quantity)
    {
        _name = name;
        _id = ID;
        _unitPrice = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _id;
    }

    public double CalculateProductPrice()
    {
        double productPrice = _unitPrice * _quantity;
        return productPrice;
    }
}