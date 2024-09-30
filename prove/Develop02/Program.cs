using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal proramm");
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3 Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Entry entry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    entry._promptText = PromptGenerator.GetRandomPrompt();
                    entry._date = theCurrentTime.ToShortDateString();
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Please enter filename");
                    journal.ReadFromFile(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("Please enter filename");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Exit selected. Goodbye!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}