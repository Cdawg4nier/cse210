using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    private int _shippingCost;

    public string CalculateCost()
    {
        //add in $5 for US, $35 for non-us
        return "";
    }

    public string PackingLabel()
    {
        //name and product ID of every item in order
        return "";
    }

    public string ShippingLabel()
    {
        //name and address of customer
        return "";
    }
}