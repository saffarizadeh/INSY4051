using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "We went to a bookstore, ";
            string s2 = "a movie, ";
            string s3 = "and a restaurant.";

            string s4 = String.Concat(s1, s2, s3);
            Console.WriteLine(s4);

            // Similar to:
            string s5 = s1 + s2 + s3;
            Console.WriteLine(s5);

        }
    }
}
