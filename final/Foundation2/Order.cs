using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int _shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public string CalculateCost()
    {
        double totalPrice = 0.0;
        string myString = "";
        foreach (Product product in _products)
        {
            totalPrice += product.CalculatePrice();
        }
        myString += $"The cost for all of your products is: ${totalPrice:F2}";
        if (_customer.LivesInUs()) 
        {
            totalPrice += 5.0;
            myString += "\nYou have a one time Shipping Fee of $5 for a US delivery.";
        }
        else 
        {
            totalPrice += 35.0;
            myString += "\nYou have a one time Shipping Fee of $35 for a non US Delivery.";
        }
        myString += $"\nThe total price for the order is: ${totalPrice:F2}";
        return myString;
    }

    public string PackingLabel()
    {
        string myString = "The packing label for your order: \n";
        foreach (Product product in _products)
        {
            myString += product.GetLabelData() + "\n";
        }
        return myString;
    }

    public string ShippingLabel()
    {
        string myString = "The shipping label for your order: \n";
        myString += $"{_customer.GetName()}\n";
        myString += _customer.GetFormattedAddress() + "\n";
        return myString;
    }
}