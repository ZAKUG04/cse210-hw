using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int NumberMagic = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;
            while (guess != NumberMagic)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (NumberMagic > guess)
                {
                    Console.WriteLine("Geater");
                }
                else if (NumberMagic < guess)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}