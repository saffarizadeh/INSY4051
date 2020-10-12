using System;

namespace MyApplication
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum from 1 to 10 is " + Sum(1, 10));
            Console.WriteLine("Sum from 20 to 30 is " + Sum(20, 30));
            Console.WriteLine("Sum from 35 to 45 is " + Sum(35, 45));
        }

    }
}
