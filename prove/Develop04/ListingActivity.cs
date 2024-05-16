public class ListeningActivity : Activity
{
    private List<String> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public ListeningActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowCountDown(3);
        Console.Clear();
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        List<string> userList = GetListFromUser();
        Console.WriteLine($"Very well done! You listed {userList.Count} items!");
    }

    public void GetRandomPrompt()
    {
        Random rng = new Random();
        int randomIndex = rng.Next(_prompts.Count);
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[randomIndex]} --- ");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;

        while (true)
        {
            Console.Write("> ");
            string userLine = Console.ReadLine();
            userList.Add(userLine);
            TimeSpan elapsedTime = DateTime.Now - startTime;
            if (elapsedTime.TotalSeconds > duration) {break;}
        }

        return userList;
        
    }
}