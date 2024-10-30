using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[] 
        {
            new Running(DateTime.Now, 30, 4.8),
            new Cycling(DateTime.Now, 30, 9.7),
            new Swimming(DateTime.Now, 30, 60)
        };

        foreach (Activity activity in activities) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}