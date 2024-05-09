public class Reference
{
    private string _book;
    private string _chapter;
    private string[] _verses;

    public Reference(string book, string chapter, string[] verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public string GetDisplayText()
    {
        string myString = $"{_book} {_chapter}:";
        foreach (string verse in _verses)
        {
            myString += $"{verse},";
        }

        myString = myString.Substring(0, myString.Length - 1);
        return myString;
    }
}