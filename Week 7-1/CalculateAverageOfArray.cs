using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 12, 67, 98, 23, 56, 21 };

            // Loop through the array to compute the
            // total and display the array elements
            int total = 0;
            Console.Write("The array contains: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                total += numbers[i];
                //0+23; 23+12; 35+67;…
                // total = total + numbers[i]
            }

            // compute the average & display the results
            double average = total / numbers.Length;
            Console.WriteLine();
            Console.WriteLine("Total is {0} and average is {1}", total, average);
        }
    }
}
