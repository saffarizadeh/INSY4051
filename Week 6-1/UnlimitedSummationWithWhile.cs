using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution with while
            int sum2 = 0;
            int data2;

            // Read an initial data
            Console.WriteLine("Enter an integer (the input ends if it is 0): ");
            data2 = Convert.ToInt32(Console.ReadLine());

            // Keep reading data until the input is 0
            while (data2 != 0)
            {
                sum2 += data2;
                // Read the next data
                Console.WriteLine("Enter an integer (the input ends if it is 0): ");
                data2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The sum is " + sum2);
        }

    }
}
