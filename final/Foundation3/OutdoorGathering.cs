public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering (string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        string myString = StandardDetails();
        myString += $"\nEvent Type: {GetEventType()}" +
        $"\nExpected Weather: {_weather}";
        return myString;
    }
}