using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 20;
            int y = 40;
            bool isEqual = (x == y);
            bool notEqual = (x != y);
            Console.WriteLine(isEqual);
            Console.WriteLine(notEqual);

            int w = 20;
            int z = 40;
            Console.WriteLine("Is x equal to y? " + (w == z));
            Console.WriteLine("Is x not equal to y? " + (w != z));
        }
    }
}
