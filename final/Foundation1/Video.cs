using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"\nVideo Title: {_title}");
        Console.WriteLine($"Creator: {_author}");
        Console.WriteLine($"Duration: {_length/60} minutes {_length%60} seconds.\nComments ({GetCommentCount()}) :");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}