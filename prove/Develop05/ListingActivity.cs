public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listening";
        _description =
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> result = GetListFromUser();
        Console.WriteLine($"You listed {result.Count()} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"   --- {_prompts[index]} ---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
            currentTime = DateTime.Now;
        }

        return responses;
    }
}