using System;

namespace MyApplication
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arrayA = { 3, 5, 8, 2, 6, 4 };
            Console.WriteLine("[Main] Before: arrayA[0] = " + arrayA[0]);
            TestArrayPassing(arrayA);
            Console.WriteLine("[Main] After: arrayA[0] = " + arrayA[0]);
            //also output 13, value has changed from 3 to 13
        }
        public static void TestArrayPassing(int[] arrayB)
        {
            Console.WriteLine("\t[TestArrayPassing] Before: arrayB[0] = " + arrayB[0]);
            arrayB[0] += 10;
            Console.WriteLine("\t[TestArrayPassing] After: arrayB[0] = " + arrayB[0]);
            //output 13
        }
    }
}

