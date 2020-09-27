using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = -1;
            // Generate a random number to be guessed
            Random random = new Random();
            int number = random.Next(0, 101);

            Console.WriteLine("Guess a magic number between 0 and 100");
            while (guess != number)
            {
                // Prompt the user to guess the number
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Yes, the number is " + number);
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }
            } // End of loop
        }

    }
}
