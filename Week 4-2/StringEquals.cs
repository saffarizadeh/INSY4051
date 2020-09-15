using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "qwerty";
            string b = "asdfg";
            string c = "qwerty";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b.Equals(a));
            Console.WriteLine(String.Equals(a, b));
            Console.WriteLine(a.Equals(c));

        }
    }
}
