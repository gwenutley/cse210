public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

        public double CalcOrderCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalcTotalCost();
        }

        if (_customer.IsUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += ($"Product: {product.GetName()}, ID: {product.GetProductID()} \n"); 
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return ($"{_customer.GetCustomerName()}, {_customer.GetCustomerAddress()}");
    }
}
