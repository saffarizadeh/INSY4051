using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double w = -7.5;
            int y;

            // If x > 0 then y = 1 else y = – 1
            y = (x > 0) ? 1 : -1;
            Console.WriteLine(y);

            // If x > 0 and w > 0 then y = x +1 elsey = x – 1;
            y = (x > 0 && w > 0) ? x + 1 : x - 1;
            Console.WriteLine(y);

            // To manually convert bool to int
            bool myBool = true;
            int myInt = myBool ? 1 : 0;
            Console.WriteLine("Converted {0} to {1}", myBool, myInt);
        }
    }
}
