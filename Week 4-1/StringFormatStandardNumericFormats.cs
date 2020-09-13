using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfProducts = 3121325;
            int fewProducts = 3;
            string productName = "Chips";
            double unitPrice = 2.475;
            double Apr = 0.1799434;
            double revenue = 3476380.8765;
            double regressionWeight = 0.0000008765345;

            Console.WriteLine(String.Format("The number of products is {0:N0}.", numberOfProducts));
            Console.WriteLine(String.Format("The number of products is {0:D2}.", fewProducts));
            Console.WriteLine(String.Format("The unit price for {0} is {1:C2}", productName, unitPrice));
            Console.WriteLine(String.Format("Your APR is {0:P2}", Apr));
            Console.WriteLine(String.Format("Our revenue this year was {0:C2}", revenue));
            Console.WriteLine(String.Format("{0:E4} is the regression weight after the new epoch.", regressionWeight));

        }
    }
}
