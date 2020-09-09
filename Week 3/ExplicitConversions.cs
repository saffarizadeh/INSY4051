using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////// Slide 10 ///////////

            double x = 1234.7;
            int a;
            // Cast double to int.
            a = (int)x;
            System.Console.WriteLine(a);

            ///////////////////////////////

            double myDouble = 9.78;
            // Manual casting: double to int
            int myInt = (int)myDouble;

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

        }
    }
}
