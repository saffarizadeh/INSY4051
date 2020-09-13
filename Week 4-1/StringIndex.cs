using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello World!";
            Console.WriteLine("{0,-5} {1,-5}", "Char", "Index");
            Console.WriteLine("{0,-5} {1,-5}", s1[0], 0);
            Console.WriteLine("{0,-5} {1,-5}", s1[3], 3);
            Console.WriteLine("{0,-5} {1,-5}", s1[5], 5);
            Console.WriteLine("{0,-5} {1,-5}", s1[11], 11);

        }
    }
}
