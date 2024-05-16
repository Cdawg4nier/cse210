using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!\n{_description}\nHow long (in seconds) would you like your activity to be? ");
        string userResponse = Console.ReadLine();
        _duration = int.Parse(userResponse);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("-");
            Thread.Sleep(333);
            Console.Write("\b ");
            Console.Write(@"\");
            Thread.Sleep(333);
            Console.Write("\b ");
            Console.Write("/");
            Thread.Sleep(333);
            Console.Write("\b ");

            seconds -= 1;
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds -= 1;
        }
    }
}