// To show creativity and exceed requirments, I added user class that keeps score in filesystem depending on username

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}