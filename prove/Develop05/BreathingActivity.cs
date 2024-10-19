public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(6);
            Console.WriteLine(Environment.NewLine);
        }
        DisplayEndingMessage();
    }
}