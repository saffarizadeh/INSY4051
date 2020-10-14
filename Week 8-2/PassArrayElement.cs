using System;

namespace MyApplication
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arrayA = { 2, 3, 6, 1 };
            //  index values {0, 1, 2, 3}
            TestPassByValue(arrayA[1]);
            Console.WriteLine("arrayA[1] is " + arrayA[1]);
            // 3
        }
        public static void TestPassByValue(int x)
        {
            x += 10;
            Console.WriteLine("Inside the method, x is " + x);
            // will output x as 13
        }
    }
}

