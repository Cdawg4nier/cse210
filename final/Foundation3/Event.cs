public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;


    public Event (string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public virtual string StandardDetails()
    {
        string myString = "";
        myString += $"Event name: {_title}" +
        $"\nEvent Date and Time: {_date} @ {_time}" +
        $"\n{_address.FormattedAddress()}" +
        $"\n{_description}";
        return myString;
    }

    public abstract string FullDetails();

    public string ShortDetails()
    {
        string myString = "";
        myString += $"Event Type: {_eventType}" +
        $"\nEvent Name: {_title}" + 
        $"\nEvent Date and Time: {_date} @ {_time}";
        return myString;
    }

    public string GetEventType()
    {
        return _eventType;
    }
}