using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number to be guessed
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(0, 101);

            int guess = -1;

            Console.WriteLine("Guess a magic number between 0 and 100");

            while (guess != randomNumber)
            {
                // Prompt the user to guess the number
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                guess = Convert.ToInt32(userInput);

                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else {
                    Console.WriteLine("Congrats! You've done it! The number was {0}", randomNumber);
                }
            }  // End of loop

        }
    }
}
