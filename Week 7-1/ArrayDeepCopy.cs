using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[10];
            int[] arrayB = new int[10];
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayB[i] = arrayA[i];
            }
        }
    }
}
