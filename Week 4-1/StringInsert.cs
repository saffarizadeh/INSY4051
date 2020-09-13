using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string original = "This is a serious problem.";
            Console.WriteLine("The original string: '{0}'", original);
            string modified = original.Insert(5, "not ");
            Console.WriteLine("The modified string: '{0}'", modified);

        }
    }
}
