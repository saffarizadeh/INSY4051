using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            if (age <= 0)
            {
                Console.WriteLine("Error");
            }
            else if (age <= 16)
            {
                Console.WriteLine("Too Young");
            }
            else if (age < 100)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Really?");
            } //Outputs "Welcome!"
        }
    }
}
