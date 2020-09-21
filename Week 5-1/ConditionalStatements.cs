using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            double money = 745.50;

            if (age > 18)
            {
                if (money > 500)
                {
                    Console.WriteLine("Welcome!");
                }
            }

            if (age > 18 && money > 500)
            {
                Console.WriteLine("Welcome!");
            }

            if (age > 18 || money > 500)
            {
                Console.WriteLine("Welcome!");
            }

            if (!(age > 18))
            {
                Console.WriteLine("Too Young");
            }
            else
            {
                Console.WriteLine("Welcome");
            }

        }
    }
}
