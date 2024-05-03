public class PromptGenerator
{
    List<string> _prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What goal did I make progress towards today, and what was that progress?",
        "What memory did I create today?",
        "Did the day go as I had planned it? Why or why not?",
        "Was today a good day or a bad day? Explain.",
        "What was the worst part of your day? Why was it bad?"
    ];

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int randomIndex = rng.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}