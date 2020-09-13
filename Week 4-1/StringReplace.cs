using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string errString = "This docment uses 3 other docments to docment the docmentation";
            Console.WriteLine(errString);
            string correctString = errString.Replace("docment", "document");
            Console.WriteLine(correctString);

        }
    }
}
