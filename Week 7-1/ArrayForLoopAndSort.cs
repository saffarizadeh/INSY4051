using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 6.0, 4.4, 1.9, 2.9, 3.4, 3.5 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            char[] chars = { 'a', 'A', '4', 'F', 'D', 'P' };
            Array.Sort(chars);
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
