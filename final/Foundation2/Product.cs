public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _amount;
    
    public Product(string name, string productID, double price, int amount)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _amount = amount;
    }

    public double CalculatePrice()
    {
        double result = _price * _amount;
        return Math.Round(result, 2);
    }

    public void Display()
    {
        Console.WriteLine($"{_name} ({_productID}): {_price} * {_amount} = {CalculatePrice()}");
    }

    public string GetLabelData()
    {
        return $"{_amount} {_name} ({_productID}) : ${_price}";
    }
}