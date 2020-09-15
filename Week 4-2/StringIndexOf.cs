using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Now is the time for all good men to come to the aid of their country.";
            int position = str.IndexOf("he", 0, 10);
            Console.WriteLine(position);
            Console.WriteLine("{0}{1}", str[position], str[position + 1]);
            Console.WriteLine(str.IndexOf("he", 10, 20));
            Console.WriteLine(str.IndexOf("he", 0, str.Length - 1));
            Console.WriteLine(str.IndexOf("he", 20, str.Length - 20 - 1));

        }
    }
}
