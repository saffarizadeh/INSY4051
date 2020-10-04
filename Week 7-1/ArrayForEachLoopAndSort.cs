using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 6.0, 4.4, 1.9, 2.9, 3.4, 3.5 };
            Array.Sort(numbers);
            foreach (double number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            char[] chars = { 'a', 'A', '4', 'F', 'D', 'P' };
            Array.Sort(chars);
            foreach (char character in chars)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine();
        }
    }
}
