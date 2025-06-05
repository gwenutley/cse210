public class Product 
{
    private string _name;
    private string _product_id;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _product_id = productID;
        _price = price;
        _quantity = quantity;
    }

    public void SetProductID(string productId)
    {
        _product_id = productId;
    }

    public string GetProductID()
    {
        return _product_id;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetPrice(float price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double CalcTotalCost()
    {
        return _price * _quantity;
    }
    
}