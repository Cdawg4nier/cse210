public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUs()
    {
        return _address.IsInUs();
    }

    public string GetFormattedAddress()
    {
        return _address.FormattedAddress();
    }
    public string GetName()
    {
        return _name;
    }
}