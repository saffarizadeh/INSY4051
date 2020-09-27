using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double item = 1;
            double sum = 0;
            while (item != 0)
            {
                // No guarantee item will
                // ever be precisely 0
                sum += item;
                item -= 0.1;
            }
            Console.WriteLine(sum);
        }

    }
}
