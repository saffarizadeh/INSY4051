using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            if (age > 0)
            {
                if (age > 16)
                {
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    Console.WriteLine("Too Young");
                }
            }
            else
            {
                Console.WriteLine("Error");
            } //Outputs "Welcome!"
        }
    }
}
