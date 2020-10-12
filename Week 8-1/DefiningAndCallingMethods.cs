using System;

namespace MyApplication
{
    class Program
    {
        public static int Max(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int i = 5;
            int j = 2;
            int k = Max(i, j);
            Console.WriteLine("Maximum between {0} and {1} is {2}", i, j, k);
        }

    }
}
