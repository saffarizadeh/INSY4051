using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "  Kambiz  ";
            string s2 = "***Kambiz***";
            string s3 = "999Kambiz999";
            Console.WriteLine("Before Trim:");
            Console.WriteLine("s1: '{0}'", s1);
            Console.WriteLine("s2: '{0}'", s2);
            Console.WriteLine("s3: '{0}'", s3);
            Console.WriteLine();
            Console.WriteLine("After Trim:");
            Console.WriteLine("s1 with Trim(): '{0}'", s1.Trim());
            Console.WriteLine("s1 with Trim(' '): '{0}'", s1.Trim(' '));
            Console.WriteLine("s2 with TrimStart('*'): '{0}'", s2.TrimStart('*'));
            Console.WriteLine("s3 with TrimEnd('9'): '{0}'", s3.TrimEnd('9'));

        }
    }
}
