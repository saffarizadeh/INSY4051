using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////// Slide 9 ///////////

            // Implicit conversion. A long can
            // hold any value an int can hold, and more!
            int num = 2147483647;
            long bigNum = num;

            int myInt = 9;

            // Automatic casting: int to double
            double myDouble1 = myInt;

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble1);   // Outputs 9

        }
    }
}
