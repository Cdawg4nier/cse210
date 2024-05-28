public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($"\tUser: {_author}");
        Console.WriteLine($"\t\t{_text}");
    }
}