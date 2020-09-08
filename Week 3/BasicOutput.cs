using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////// Slide 13 ///////////

            bool myBool = true;
            int myInt = 5;
            long myLong = 2147483647432156;
            double myDouble = 5.25;

            Console.WriteLine("The answer to your first question is " + myBool);
            Console.WriteLine("You have " + myInt + " items in your cart.");
            Console.WriteLine("The number of stars in the selected space is: " + myLong);
            Console.WriteLine("Your minimum payment for this month is $" + myDouble + ", which is due in 2 days.");

        }
    }
}
