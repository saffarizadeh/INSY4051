using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Location: Paris";
            string s2 = "Age: 47";
            string s3 = "Color1=red";
            int position;

            position = s1.IndexOf(": ");
            Console.WriteLine("First one: {0}",
                                s1.Substring(position + 2));
            position = s2.IndexOf(": ");
            Console.WriteLine("First one: {0}",
                                s2.Substring(position + 2));

            position = s3.IndexOf("=");
            Console.WriteLine("Key: {0}, Value: '{1}'",
                                s3.Substring(0, position),
                                s3.Substring(position + 1));

        }
    }
}
