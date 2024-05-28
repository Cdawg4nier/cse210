public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private List<string> StatesInUS;

    private bool IsInUs(string location)
    {
        return false;
    }

    private string FormattedAddress()
    {
        return "";
    }
}