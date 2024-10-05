// In showing creativity and exceeding the requirement, I randomly select from only those words that are not already hidden.
// I also added a parameter on how many words to hide so that the program could adapt to user's ability to memorize.

using System;

class Program
{
    static void Main(string[] args)
    {
        int wordsToHide;
        string key = "";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("Enter the number of words to hide: ");
        int.TryParse(Console.ReadLine(), out wordsToHide);
        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        while (!scripture.IsCompletelyHidden())
        {
            key = Console.ReadLine();
            if (key.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(wordsToHide);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
            }
        }
    }
}