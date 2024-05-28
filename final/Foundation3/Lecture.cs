public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture (string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base (title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }
    public override string FullDetails()
    {
        string myString = StandardDetails();
        myString += $"\nEvent Type: {GetEventType()}" +
        $"\nSpeaker: {_speaker}" +
        $"\nMax Occupants: {_maxCapacity}";
        return myString;
    }
}