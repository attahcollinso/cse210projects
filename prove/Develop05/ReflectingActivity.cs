public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _question;

    public ReflectingActivity(List<string> prompts, List<string> question): Base()
    {
        _prompts = prompts;
        _question = question;
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return ""
    }

    public string GetRandomQuestion()
    {
        return ""
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}