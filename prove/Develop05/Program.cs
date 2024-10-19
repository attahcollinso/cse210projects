// To show creativity and exceed requirement, I made the questions in the reflecting activity not to repeat untill all the questions have been taken.

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit"); 
            Console.Write("Select a choice from menu ");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    BreathingActivity br = new BreathingActivity();
                    br.Run();
                    break;
                case 2:
                    ReflectingActivity re = new ReflectingActivity();
                    re.Run();
                    break;
                case 3:
                    ListingActivity la = new ListingActivity();
                    la.Run();
                    break;
            }
        }
    }
}