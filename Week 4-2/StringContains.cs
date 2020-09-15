using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "fox";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                                s2, s1, b);

        }
    }
}
