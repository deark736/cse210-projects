using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Step 1: Generate a random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0; // Initialize guess
            int attempts = 0; // Track the number of attempts

            Console.WriteLine("Welcome to the Guess My Number game!");

            // Step 2: Start guessing loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Step 3: Inform the user of the number of attempts
            Console.WriteLine($"It took you {attempts} guesses to find the magic number.");

            // Step 4: Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
