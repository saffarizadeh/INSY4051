using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string crawledText = "This is a TEXT from a website that wE crawled";
            Console.WriteLine("The original text: " + crawledText);
            Console.WriteLine("The lower-case text: " + crawledText.ToLower());
            Console.WriteLine("The upper-case text: " + crawledText.ToUpper());

        }
    }
}
