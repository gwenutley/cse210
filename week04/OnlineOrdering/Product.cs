public class Products 
{
    private string _name;
    private string _product_id;
    private float _price;
    private int _quantity;

    public void SetName(string name) 
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public float CalcTotalCost()
    {
        //multiply the price by the quantity
    }
    
}