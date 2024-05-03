public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public Entry()
    {

    }

    public List<String> getData()
    {
        List<String> myData = [_date, _promptText, _entryText];
        return myData;
    }
    public string Display()
    {
        return $"{_date} - {_promptText}\n{_entryText}";
    }
}