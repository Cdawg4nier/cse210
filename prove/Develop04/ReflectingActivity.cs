public class ReflectingActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowCountDown(3);
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("You are now going to get a series of questions. Think about these questions in relation to this prompt.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        int duration = GetDuration();
        while (duration > 0)
        {
            DisplayQuestions();
            ShowSpinner(10);

            duration -= 10;
        }
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int randomIndex = rng.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random rng = new Random();
        int randomIndex = rng.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }

}