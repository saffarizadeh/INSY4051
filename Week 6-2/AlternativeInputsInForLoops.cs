using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++, Console.WriteLine(i));


            for (int i = 0, j = 0; (i + j < 10); i++, j++)
            {
                Console.WriteLine("{0} + {1} = {2}", i, j, i + j);
            }
        }

    }
}
