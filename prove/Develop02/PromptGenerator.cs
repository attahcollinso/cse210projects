public class PromptGenerator
{

    public List<string> _promptText = new List<string>()
    {
        "Did you speak kindly to my children",
        "What was the best part of my day?",
        "How did I see the hand of the God in my life today?",
        "Did you achieve my goals today",
        "If you had one thing you could do over today, what would it be?",
        "Exciting things you experienced today.",
        "Describe someone you saw today who you found intriguing.",
        "Describe your spiritual moments today.",
        "Did you work on my temper today?",
        "What was the high point and the low point of your day?",
        "What is one thing you learned today?",
        "What are the things that made you smile today.",
        "Did anything unexpected happen today? If so, how did you respond?",
        "How did you make a positive impact today?",
        "Is there anything you wish you had done differently today?",
        "What are your expectations for tomorrow?",
        "Write about a moment when you felt grateful today.",
        "Where able to kkep to time? Why?"
        "Describe the trafic today and how it affected your journey.",
        "Did you share the gospel today?",
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptText.Count);
        return _promptText[index];
    }
}