using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++); //Logic Error
            {
                Console.WriteLine("i is " + i);
            }

            int j = 0;
            while (j < 10) ; //Logic Error
            {
                Console.WriteLine("i is " + j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine("i is " + k);
                k++;
            } while (k < 10); // Correct

        }

    }
}
