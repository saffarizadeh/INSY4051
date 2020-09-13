using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int yearOne = 2015;
            int populationOne = 1575780;
            int yearTwo = 2016;
            int populationTwo = 1575330;
            int yearThree = 2017;
            int populationThree = 1575150;
            string header = String.Format("{0,-6} {1,-15}", "Year", "Population");
            string firstRow = String.Format("{0,-6} {1,-15:N0}", yearOne, populationOne);
            string secondRow = String.Format("{0,-6} {1,-15:N0}", yearTwo, populationTwo);
            string thridRow = String.Format("{0,-6} {1,-15:N0}", yearThree, populationThree);
            Console.WriteLine(header);
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(thridRow);

        }
    }
}
