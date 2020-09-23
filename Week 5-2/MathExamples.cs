using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: "
                    + Math.Ceiling(2.75)); //3


            Console.WriteLine("Floor: "
                                + Math.Floor(2.75)); //2


            Console.WriteLine("Round: "
                                + Math.Round(2.75)); //3
            Console.WriteLine("Round: "
                                + Math.Round(2.5)); //2
            Console.WriteLine("Round: "
                                + Math.Round(3.5)); //4


            Console.WriteLine("Min of 2 and 4: "
                    + Math.Min(2, 4)); //2


            Console.WriteLine("Max of 2 and 4: "
                                + Math.Max(2, 4)); //4


            Console.WriteLine("Abs of -2.5: "
                                + Math.Abs(-2.5)); //2.5

            Console.WriteLine("3 to the power of 2: "
                    + Math.Pow(3, 2)); //9


            Console.WriteLine("Square root of 4: "
                                + Math.Sqrt(4)); //2

        }
    }
}
