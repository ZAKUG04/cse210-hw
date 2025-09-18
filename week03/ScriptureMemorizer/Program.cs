/*
Personal improv:
- User choose how many words hide each round
- Some messages not perfect grammar
- Keeps same logic as normal
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };

        Scripture current = scriptures[rand.Next(scriptures.Count)];

        Console.Write("How many word to hide per turn? ");
        int hideCount;
        if (!int.TryParse(Console.ReadLine(), out hideCount) || hideCount < 1)
        {
            hideCount = 2; // default
        }

        while (!current.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(current.GetTextDisplay());
            int visibleCount = current.VisibleWordsCount();
            Console.WriteLine($"\nWords still visible: {visibleCount}");

            Console.WriteLine("\nPress Enter for hide words or type 'quit'.");
            string user = Console.ReadLine();
            if (user.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Program finished by user.");
                break;
            }

            current.HideRandomWords(hideCount);
        }

        if (current.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(current.GetTextDisplay());

            
            string finishMsg = current.GetReferenceName().Contains("John") ?
                            "Congratulation! You memorized John passage!" :
                            "Great job! Scripture is all hide now!";
            Console.WriteLine("\n" + finishMsg);
        }
    }
}