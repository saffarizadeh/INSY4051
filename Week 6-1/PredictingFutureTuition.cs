using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 30000;   // Year 0

            int year = 0;

            while (tuition < 60000)
            {
                tuition = tuition * 1.07;
                year++;
            }

            Console.WriteLine("Tuition will be doubled in {0} years", year);
            Console.WriteLine("Tuition will be {0:F2} in {1} years", tuition, year);
        }

    }
}
