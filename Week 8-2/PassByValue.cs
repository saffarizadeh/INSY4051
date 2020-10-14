using System;

namespace MyApplication
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Declare and initialize variables
            int num1 = 1;
            int num2 = 2;

            Console.WriteLine("Before invoking the swap method, num1 is {0} and num2 is {1}", num1, num2);

            // Invoke the swap method to attempt to swap two variables
            Swap(num1, num2);

            Console.WriteLine("After invoking the swap method, num1 is {0} and num2 is {1}", num1, num2);
        }
        /** Swap two variables */
        public static void Swap(int n1, int n2)
        {
            Console.WriteLine("\tInside the swap method");
            Console.WriteLine("\t\tBefore swapping, n1 is {0} and n2 is {1}", n1, n2);

            // Swap n1 with n2
            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("\t\tAfter swapping, n1 is {0} and n2 is {1}", n1, n2);
        }
    }
}

