using System;

namespace MyApplication
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = CopyArray(array1);
        }

        public static int[] CopyArray(int[] arrayA)
        {
            //creates new array, sets it to size of passed array
            // populates new array with values of passed array and returns
            int[] arrayB = new int[arrayA.Length];

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayB[i] = arrayA[i];
            }

            return arrayB;
        }
    }
}

