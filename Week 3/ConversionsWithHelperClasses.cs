using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////// Slide 12 ///////////

            bool myBool = true;
            int myInt = 5;
            long myLong = 2147483647432156;
            double myDouble = 5.25;

            string myBoolString = "false";
            string myIntString = "34";
            string myLongString = "34477286474921466";
            string myDoubleString = "432.87";

            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToString(myInt));    // int to string
            Console.WriteLine(Convert.ToString(myLong));    // long to string

            Console.WriteLine(Convert.ToBoolean(myBoolString));    // string long to bool
            Console.WriteLine(Convert.ToInt32(myIntString));  // string to int
            Console.WriteLine(Convert.ToInt64(myLongString));  // string to long
            Console.WriteLine(Convert.ToDouble(myDoubleString));  // string to double

            Console.WriteLine(Convert.ToBoolean(myInt));  // int to bool
            Console.WriteLine(Convert.ToInt32(myDouble));  // double to int
            Console.WriteLine(Convert.ToInt64(myBool));  // bool to long
            Console.WriteLine(Convert.ToDouble(myInt));  // int to double

        }
    }
}
