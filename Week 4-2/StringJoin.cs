using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";

            // Don't worry! We will cover arrays soon!
            string[] words = s1.Split(" ");

            string newString = String.Join(", ", words);
            Console.WriteLine(newString);

        }
    }
}
