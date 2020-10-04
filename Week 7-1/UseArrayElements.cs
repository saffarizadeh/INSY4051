using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = { 6.0, 5.5, 4.2, 0.5, 8.5,
                     9.5, 3.0, 2.0, 7.2, 8.1 };
            int lastIndex = myArray.Length;
            double lastValue = myArray[myArray.Length - 1];

            double x = myArray[3];
            double y = myArray[5] + myArray[8];
        }
    }
}
