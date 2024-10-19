public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like " +
                      $"for your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
        Console.Clear();
        Console.WriteLine($"Starting the {_name} Activity...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds" +
                          $" of the {_name} Activity");
        ShowSpinner(4);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinner = new char[] { '|', '/', '-', '\\' };
        int spinCounter = 0;

        for (int i = 0; i < seconds * 2; i++)
        {
            spinCounter++;
            if (spinCounter > 3) spinCounter = 0;
            Console.Write("\r" + spinner[spinCounter].ToString());
            Thread.Sleep(500);
        }
        Console.Write("\r");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}