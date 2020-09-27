using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution with do-while
            int sum1 = 0;
            int data1;
            do
            {
                // Read the data
                Console.WriteLine("Enter an integer (the input ends if it is 0): ");
                data1 = Convert.ToInt32(Console.ReadLine());
                sum1 += data1;
            } while (data1 != 0); // Keep reading data until the input is 0

            Console.WriteLine("The sum is " + sum1);
        }

    }
}
