using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[5];
            string[] arrayTwo = new string[5];
            bool[] arrayThree = new bool[5];
            Console.WriteLine("Default value for an empty int array element: '{0}'", arrayOne[0]);
            Console.WriteLine("Default value for an empty string array element: '{0}'", arrayTwo[0]);
            Console.WriteLine("Default value for an empty bool array element: '{0}'", arrayThree[0]);
        }
    }
}
