public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public string StandardDetails()
    {
        return "";
    }

    public abstract string FullDetails();

    public string ShortDetails()
    {
        return "";
    }
}