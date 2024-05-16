public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready... ");

        ShowCountDown(3);

        while (duration > 0)
        {
            Console.Write("\nBreathe in... 1");
            Thread.Sleep(1000);
            Console.Write("\b \b2");
            Thread.Sleep(1000);
            Console.Write("\b \b3");
            Thread.Sleep(1000);
            Console.Write("\b \b4");
            Thread.Sleep(1000);
            Console.Write("\b \b5");
            Thread.Sleep(1000);
            Console.Write("\b \b6");

            Thread.Sleep(1000);

            Console.Write("\nBreathe out... 1");
            Thread.Sleep(1000);
            Console.Write("\b \b2");
            Thread.Sleep(1000);
            Console.Write("\b \b3");
            Thread.Sleep(1000);
            Console.Write("\b \b4");
            Thread.Sleep(1000);
            Console.Write("\b \b5");
            Thread.Sleep(1000);
            Console.Write("\b \b6");

            Thread.Sleep(1000);

            duration -= 12;
            
        }
        Console.Clear();
    }
}